/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GesMerCa
{
    public partial class FrmConfig : Form
    {
        private List<string[]> listaOpcionesUssGenNoActivas;
        private List<int> listOpcUssNuevas;
        private FrmConfigAltaOpc frmNuevaOpc;

        public FrmConfig()
        {
            InitializeComponent();
            generarOpciones();
            lblUss.Text = Utils.Utilidades.usuarioActual.Nombre + " " +
                          Utils.Utilidades.usuarioActual.Apellido1 + " " +
                          Utils.Utilidades.usuarioActual.Apellido2;
            listOpcUssNuevas = new List<int>();
        }


        private void FrmConfig_Shown(object sender, EventArgs e)
        {
            foreach (string[] modulo in Utils.Utilidades.listaRestriccionesRolUsuario)
            {
                if (modulo[0].Equals("barraHerramientasAdministracionOpcGen"))
                    if (!Convert.ToBoolean(modulo[1]))
                    {
                        tabOpc.TabPages[0].Hide();
                        tabOpc.TabPages[0].Dispose();
                    }
            }
            this.Refresh();
        }

        private void generarOpciones()
        {
            //Carga de los elementos de la primera pestaña
            List<string[]> listaOpcGen = Utils.ConexionBD.consultarRegistroBD("SELECT id, nombre, valor, titulo, dominio, descripcion FROM config;");
            cargarOpcionsPestaña(tabLayOpcGen, listaOpcGen, false);
            //Carga de los elementos de la segunda pestaña
            List<string[]> listaOpcionesGen = Utils.ConexionBD.consultarRegistroBD("SELECT id, nombre, valor, titulo, dominio, descripcion FROM config ORDER BY id;");
            List<string[]> listaOpcionesUsuario = Utils.ConexionBD.consultarRegistroBD("SELECT configusuario.id, nombre, configusuario.valor, titulo, dominio, configusuario.descripcion FROM "
                + "config, configusuario WHERE configusuario.idconfig=config.id AND idusuario = " + Utils.Utilidades.usuarioActual.Id + " ORDER BY config.id;");
            listaOpcionesUssGenNoActivas = new List<string[]>();
            foreach (string[] opc in listaOpcionesGen)
            {
                int cont = 0;
                foreach (string[] opcU in listaOpcionesUsuario)
                {
                    if (opc[1] == opcU[1])
                        cont++;
                }
                if (cont == 0)
                {
                    //listaOpcionesUsuario.Add(opc);
                    listaOpcionesUssGenNoActivas.Add(opc);
                }

            }
            listaOpcionesGen = null;
            cargarOpcionsPestaña(tabLayOpcUss, listaOpcionesUsuario, false);
            cargarOpcionsPestaña(tabLayOpcUss, listaOpcionesUssGenNoActivas, true);
        }

        private void cargarOpcionsPestaña(TableLayoutPanel tabTableActual, List<string[]> listaOpc, bool esOpcGenUssNoActiva)
        {
            string prefijoNomElem = null;
            if (tabTableActual.Name == "tabLayOpcGen")
                prefijoNomElem = "OpcGen";
            else
                if (esOpcGenUssNoActiva)
                prefijoNomElem = "OpcUssNoActiva";
            else
                prefijoNomElem = "OpcUss";
            foreach (string[] opc in listaOpc)
            {
                tabTableActual.Controls.Add(new Label()
                {
                    Text = opc[3],
                    Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                    AutoSize = false,
                    Name = "nombre" + prefijoNomElem + opc[0]
                });

                if (opc[4] == "True;False")
                {
                    tabTableActual.Controls.Add(new CheckBox()
                    {
                        Text = opc[4].Split(';')[0] + "/" + opc[4].Split(';')[1],
                        Checked = Convert.ToBoolean(opc[2]),
                        Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                        AutoSize = false,
                        Name = "valor" + prefijoNomElem + opc[0]
                    });
                }
                else
                {
                    ListBox cmb = new ListBox();
                    cmb.Items.AddRange(opc[4].Split(';'));
                    cmb.SelectedItem = opc[2];
                    cmb.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                    cmb.AutoSize = false;
                    cmb.Name = "valor" + prefijoNomElem + opc[0];
                    tabTableActual.Controls.Add(cmb);
                }

                tabTableActual.Controls.Add(new TextBox()
                {
                    Text = opc[4],
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                    AutoSize = false,
                    Name = "dominio" + prefijoNomElem + opc[0]
                });

                tabTableActual.Controls.Add(new TextBox()
                {
                    Text = opc[1],
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                    AutoSize = false,
                    Name = "nombreOpcion" + prefijoNomElem + opc[0]
                });

                tabTableActual.Controls.Add(new TextBox()
                {
                    Text = opc[5],
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom),
                    AutoSize = true,
                    Name = "descripcion" + prefijoNomElem + opc[0],
                    Multiline = true
                });
                if (!esOpcGenUssNoActiva)
                {
                    tabTableActual.Controls.Add(new Button()
                    {
                        Image = Properties.Resources.saveHS,
                        Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                        AutoSize = true,
                        Text = Properties.Resources.btnGuardar,
                        ImageAlign = ContentAlignment.MiddleLeft,
                        TextAlign = ContentAlignment.MiddleRight,
                        Name = "guardar" + prefijoNomElem + opc[0]
                    });
                }
                else
                {
                    tabTableActual.Controls.Add(new CheckBox()
                    {
                        Width = 23,
                        Height = 23,
                        Anchor = (AnchorStyles.Top | AnchorStyles.Left),
                        AutoSize = true,
                        Text = Properties.Resources.btnActivar,
                        Name = "chkActivar" + prefijoNomElem + opc[0]
                    });
                }

            }
            foreach (Control elem in tabTableActual.Controls)
            {
                if (elem is Button)
                {
                    elem.MouseClick += new MouseEventHandler(guardarOpcion);
                }
                else if (elem.Name.Contains("chkActivar"))
                {
                    elem.MouseClick += new MouseEventHandler(activarOpcion);
                }

                if (prefijoNomElem == "OpcUss" || prefijoNomElem == "OpcUssNoActiva")
                {
                    if (elem is TextBox)
                        elem.Enabled = false;
                }
            }
        }

        private void guardarOpcion(object sender, EventArgs e)
        {
            Button btnGuardar = (Button)sender;
            int numOpc = -1;
            string[] valores = new string[4];
            if (btnGuardar.Parent.Name == "tabLayOpcGen")
            {
                numOpc = Convert.ToInt32(btnGuardar.Name.Substring("guardarOpcGen".Length));
                foreach (Control elem in tabLayOpcGen.Controls)
                {
                    if (elem.Name == "nombreOpcionOpcGen" + numOpc.ToString())
                        valores[0] = elem.Text;
                    else if (elem.Name == "valorOpcGen" + numOpc.ToString())
                        if (elem is CheckBox)
                        {
                            CheckBox chk = (CheckBox)elem;
                            valores[1] = chk.Checked.ToString();
                        }
                        else
                        {
                            ListBox cmb = (ListBox)elem;
                            valores[1] = cmb.SelectedItem.ToString();
                        }

                    else if (elem.Name == "dominioOpcGen" + numOpc.ToString())
                        valores[2] = elem.Text;
                    else if (elem.Name == "descripcionOpcGen" + numOpc.ToString())
                        valores[3] = elem.Text;
                }

                if (Utils.OperBD.actualizarOpciones(numOpc, Utils.Const.TIPO_OPCION_CONFIG.GENERAL, valores) >= 1)
                {
                    MessageBox.Show(Properties.Resources.msgConfigOpcOK, Properties.Resources.msgConfigOpcOKTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                }
                valores = null;
            }
            else
            {
                valores = new string[2];
                numOpc = Convert.ToInt32(btnGuardar.Name.Substring("guardarOpcUss".Length));
                foreach (Control elem in tabLayOpcUss.Controls)
                {
                    if (elem.Name == "valorOpcUss" + numOpc.ToString())
                        if (elem is CheckBox)
                        {
                            CheckBox chk = (CheckBox)elem;
                            valores[0] = chk.Checked.ToString();
                        }
                        else
                        {
                            ListBox cmb = (ListBox)elem;
                            valores[0] = cmb.SelectedItem.ToString();
                        }
                    else if (elem.Name == "descripcionOpcUss" + numOpc.ToString())
                        valores[1] = elem.Text;
                }

                if (Utils.OperBD.actualizarOpciones(numOpc, Utils.Const.TIPO_OPCION_CONFIG.USUARIO, valores) >= 1)
                {
                    MessageBox.Show(Properties.Resources.msgConfigOpcOK, Properties.Resources.msgConfigOpcOKTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnGuardar.Enabled = false;
                }
            }
        }

        private void activarOpcion(object sender, EventArgs e)
        {
            CheckBox chkActvar = (CheckBox)sender;
            chkActvar.Enabled = false;
            listOpcUssNuevas.Add(Convert.ToInt32(chkActvar.Name.Substring("chkActivarOpcUssNoActiva".Length)));
        }

        private void btnInfoOpcUss_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.msgConfigOpcUsuario, Properties.Resources.msgConfigOpcUsuarioTitulo, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            foreach (int opcNueva in listOpcUssNuevas)
            {
                string[] valores = new string[4];
                foreach (Control elem in tabLayOpcUss.Controls)
                {
                    if (elem.Name == "nombreOpcionOpcUssNoActiva" + opcNueva.ToString())
                        valores[0] = elem.Text;
                    else if (elem.Name == "valorOpcUssNoActiva" + opcNueva.ToString())
                        if (elem is CheckBox)
                        {
                            CheckBox chk = (CheckBox)elem;
                            valores[1] = chk.Checked.ToString();
                        }
                        else
                        {
                            ListBox cmb = (ListBox)elem;
                            valores[1] = cmb.SelectedItem.ToString();
                        }
                    else if (elem.Name == "dominioOpcUssNoActiva" + opcNueva.ToString())
                        valores[2] = elem.Text;
                    else if (elem.Name == "descripcionOpcUssNoActiva" + opcNueva.ToString())
                        valores[3] = elem.Text;
                }
                if (Utils.OperBD.insertarOpcionesUsuario(opcNueva, Utils.Const.TIPO_OPCION_CONFIG.USUARIO, valores) <= 0)
                    this.DialogResult = DialogResult.Cancel;
                valores = null;
            }
            if (this.DialogResult == DialogResult.Cancel)
                MessageBox.Show(Properties.Resources.msgConfigOpcErrorGrabacion, Properties.Resources.msgConfigOpcErrorGrabacionTitulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Close();
        }

        private void btnNuevaOpcGen_Click(object sender, EventArgs e)
        {
            if (frmNuevaOpc == null)
            {
                frmNuevaOpc = new FrmConfigAltaOpc();
                frmNuevaOpc.MdiParent = this.MdiParent.MdiParent;
                //frmAltaUsuarios.Owner = this;
                //frmAltaUsuarios.StartPosition = FormStartPosition.Manual;
                //frmAltaUsuarios.Location = new Point((this.ClientSize.Width - frmAltaUsuarios.Width) / 2, (this.ClientSize.Height - frmAltaUsuarios.Height) / 2);
                frmNuevaOpc.ShowDialog();
                frmNuevaOpc.BringToFront();
                frmNuevaOpc.Focus();
                frmNuevaOpc.FormClosed += new FormClosedEventHandler(cierreFrmNuevaOpc);
            }
            else
            {
                frmNuevaOpc.Activate();
            }
        }

        private void cierreFrmNuevaOpc(object sender, FormClosedEventArgs e)
        {
            frmNuevaOpc = null;
        }
    }
}
