/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GesMerCa
{
    public partial class FrmBloqueoAcceso : Form
    {
        private const int CODIGO_DESBLOQUEO = 5555;
        private int tiempoRestanteBloqueo;
        private int pulsacionIconoBloqueo;
        private bool terminalBloqueado;

        #region Anular teclas especiales

        
        /* Código para desactivar la Winkey, Alt + Tab, Ctrl + Esc comienza aquí */

        // Estructura contener información acerca de eventos de entrada de teclado de bajo nivel
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }
        // funciones a nivel de sistema que se utilizará para la entrada y salida de teclado
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Desactivando tecla Widows

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1; // Si se devuelve 0 entonces todas las teclas anteriores se habilitarán
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        #endregion

        public FrmBloqueoAcceso()
        {
            tiempoRestanteBloqueo = Utils.Const.TIEMPO_BLOQUEO_TERMINAL * 1000;
            inicializar();
        }

        public FrmBloqueoAcceso(int tiempoRestanteBloqueo)
        {
            this.tiempoRestanteBloqueo = tiempoRestanteBloqueo;
            inicializar();
        }

        private void inicializar()
        {
            InitializeComponent();
            pulsacionIconoBloqueo = 0;

            //Activa la anulación de las teclas especiales
            detectarTeclasEspeciales();
            if (tiempoRestanteBloqueo > 0)
            {
                timerBloqueoPantalla.Enabled = true;
                timerBloqueoPantalla.Start();
            }
            terminalBloqueado = true;
        }

        private void FrmBloqueoAcceso_Shown(object sender, EventArgs e)
        {
            setFullScreen();
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2;
            lblTitulo.Top = 50;
            iconoBloqueo.Left = (this.Width - iconoBloqueo.Width) / 2;
            iconoBloqueo.Top = (this.Height - iconoBloqueo.Height) / 2;
            if (tiempoRestanteBloqueo <= 0)
            {
                lblTiempoDisponible.Text = Properties.Resources.msgBloqueoAccesoIntroDesblq;
                Utils.Utilidades.activarTTS(Properties.Resources.msgBloqueoAccesoTTSInfo);
            }
            else
            {
                int min = tiempoRestanteBloqueo / 60000;
                int seg = (tiempoRestanteBloqueo / 1000) - (min * 60);
                Utils.Utilidades.activarTTS(string.Format(Properties.Resources.msgTerminalBloqueadoTiempo, min, seg));
            }
                
            lblTiempoDisponible.Left = (this.Width - lblTiempoDisponible.Width) / 2;
            lblTiempoDisponible.Top = this.Height - (lblTitulo.Height + 10);
            this.Focus();
            
        }

        private void setFullScreen()
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }
        private void timerBloqueoPantalla_Tick(object sender, EventArgs e)
        {
            if (tiempoRestanteBloqueo > 0)
            {
                tiempoRestanteBloqueo--;
                int min = tiempoRestanteBloqueo / 60000;
                int seg = (tiempoRestanteBloqueo / 1000) - (min * 60);
                lblTiempoDisponible.Text = string.Format(Properties.Resources.msgTerminalDisponibleTiempo, min, seg);
                this.Refresh();
            }
            else
            {
                timerBloqueoPantalla.Stop();
                terminalBloqueado = false;
                Close();
            }
        }

        private void iconoBloqueo_Click(object sender, EventArgs e)
        {
            iconoBloqueo.Image = Properties.Resources.unlocked;
            if (tiempoRestanteBloqueo > 0)
            {
                pulsacionIconoBloqueo++;
                if (pulsacionIconoBloqueo >= 5)
                {
                    setCodigoDesbloqueo(true);
                }
            }
            else
            {
                Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso = (Utils.Const.LOGIN_MODO_IDENTIFICACION)Convert.ToInt32(Utils.Utilidades.opcsGen.getValorClave("LOGIN_MODO_IDENTIFICACION"));
                FrmLogin login = new FrmLogin(modoAcceso, Utils.Utilidades.usuarioActual.NombreLogin);
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                {
                    timerBloqueoPantalla.Stop();
                    terminalBloqueado = false;
                    Close();
                }
                else
                {
                    tiempoRestanteBloqueo = Utils.Const.TIEMPO_BLOQUEO_TERMINAL * 1000;
                    timerBloqueoPantalla.Enabled = true;
                    timerBloqueoPantalla.Start();
                    terminalBloqueado = true;
                    this.Refresh();
                }
            }
            iconoBloqueo.Image = Properties.Resources.locked;
        }

        private void timerIconoDesbloqueo_Tick(object sender, EventArgs e)
        {
            pulsacionIconoBloqueo = 0;
            setCodigoDesbloqueo(false);
        }

        private void btnDesbloqueo_Click(object sender, EventArgs e)
        {
            comprobarCodDesbloqueo();
        }

        private void comprobarCodDesbloqueo()
        {
            if (txtCodigoDesbloqueo.Text == CODIGO_DESBLOQUEO.ToString())
            {
                terminalBloqueado = false;
                Close();
            }
            else
            {
                setCodigoDesbloqueo(false);
                pulsacionIconoBloqueo = 0;
                terminalBloqueado = true;
            }
        }

        private void setCodigoDesbloqueo(bool estado)
        {
            lblCodigoDesbloqueo.Visible = estado;
            txtCodigoDesbloqueo.Visible = estado;
            txtCodigoDesbloqueo.Clear();
            txtCodigoDesbloqueo.Focus();
            btnDesbloqueo.Visible = estado;
        }

        private void cerrarFormulario(object sender, FormClosingEventArgs e)
        {
            if (terminalBloqueado)
                e.Cancel = true;
        }

        private void detectarTeclasEspeciales()
        {
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
        }

    }
}
