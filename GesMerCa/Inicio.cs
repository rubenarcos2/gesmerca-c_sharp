/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace GesMerCa
{
    static class Inicio
    {
        internal static Utils.Log log;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Cambia al idioma Inglés
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSplash());
            if (FrmSplash.cargaProcesada)
            {
                comprobarAcceso();
            }
        }

        private static void comprobarAcceso()
        {
            try
            {
                if (Utils.Utilidades.opcsGen != null)
                {
                    Utils.Const.LOGIN_MODO_IDENTIFICACION modoAcceso = (Utils.Const.LOGIN_MODO_IDENTIFICACION)Convert.ToInt32(Utils.Utilidades.opcsGen.getValorClave("LOGIN_MODO_IDENTIFICACION"));
                    FrmLogin login = new FrmLogin(modoAcceso, Utils.Const.LOGINFACIAL_MODO_ACCESO.Reconocimiento);
                    login.ShowDialog();
                    if (login.DialogResult == DialogResult.OK)
                    {
                        login.Dispose();
                        Utils.Utilidades.activarTTS(Properties.Resources.msgInfoTTS_2 + Utils.Utilidades.usuarioActual.Nombre);
                        Application.Run(new FrmPrincipal());
                    }
                    else
                    {
                        login.Dispose();
                        if (login.getBloqueadoAcceso())
                        {
                            FrmBloqueoAcceso frmBloqueo = new FrmBloqueoAcceso();
                            frmBloqueo.ShowDialog();
                            comprobarAcceso();
                        }
                    }
                }else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(Properties.Resources.msgInicioErrorGeneral, Properties.Resources.msgInicioErrorGeneralTitulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Inicio.log.Registro.Error("Error general: " + ex);
            }

        }
    }
}
