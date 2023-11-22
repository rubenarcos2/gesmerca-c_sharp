/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using GesMerCa.Objs;
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
    public partial class FrmAltaUsuarios : Form
    {
        public FrmAltaUsuarios()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = null;

            try
            {
                foreach (Control ctl in this.Controls)
                {
                    ctl.Focus();
                }
                if (!String.IsNullOrEmpty(txtNombreLogin.Text) && !String.IsNullOrEmpty(txtPassword.Text) && barraNievelPassword.Value >= 3)
                {
                    usuario = new Usuario(txtNombreLogin.Text, txtPassword.Text);
                    if (!String.IsNullOrEmpty(txtNombre.Text))
                        usuario.Nombre = txtNombre.Text;
                    if (!String.IsNullOrEmpty(txtApellido1.Text))
                        usuario.Apellido1 = txtApellido1.Text;
                    if (!String.IsNullOrEmpty(txtApellido2.Text))
                        usuario.Apellido2 = txtApellido2.Text;
                    if (!String.IsNullOrEmpty(txtEmail.Text))
                        usuario.Email = txtEmail.Text;
                    usuario = Login.Insert(usuario);
                    System.Threading.Thread hilo = new System.Threading.Thread(delegate ()
                    {
                        Utils.OperBD.insertarImagenUsuario(imgUsuario.Image, usuario.Id, imgUsuario.Image.RawFormat);
                    });
                    hilo.Start();
                    hilo.IsBackground = true;
                    MessageBox.Show(string.Format(Properties.Resources.msgAltaUsuario, usuario.Id));
                    this.DialogResult = DialogResult.OK;
                    Close();
                }else
                {
                    MessageBox.Show(Properties.Resources.msgAltaUsuarioComp, Properties.Resources.msgAltaUsuarioCompTitulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void comprobarPassword(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                lblFortalezaPassword.Visible = false;
                lblNivelPassword.Visible = false;
                barraNievelPassword.Visible = false;
            }
            else
            {
                lblFortalezaPassword.Visible = true;
                lblNivelPassword.Visible = true;
                barraNievelPassword.Visible = true;
                Utils.Const.NIVEL_PASSWORD nivel = Utils.Seguridad.comprobarNivelPassword(txtPassword.Text);
                lblNivelPassword.Text = nivel.ToString();
                barraNievelPassword.Value = (int)nivel;
                if (nivel > Utils.Const.NIVEL_PASSWORD.Aceptable)
                {
                    barraNievelPassword.ForeColor = Color.YellowGreen;
                }
                else
                {
                    barraNievelPassword.ForeColor = Color.DarkRed;
                }
            }
        }

        private void comprobarEmail(object sender, CancelEventArgs e)
        {
            if (!Utils.Utilidades.ComprobarFormatoEmail(txtEmail.Text))
                controlErrores.SetError(txtEmail, Properties.Resources.msgAltaUsuarioErrorEmail);
            else
                controlErrores.Dispose();
        }

        private void comprobarRepeticionPassword(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text != txtPasswordRepetido.Text)
                controlErrores.SetError(txtPasswordRepetido, Properties.Resources.msgAltaUsuarioErrorPass);
            else
                controlErrores.Dispose();
        }

        private void comprobarExistenciaUsuario(object sender, CancelEventArgs e)
        {
            if (Utils.Utilidades.comprobarExistenciaUsuario(txtNombreLogin.Text))
                controlErrores.SetError(txtNombreLogin, Properties.Resources.msgAltaUsuarioErrorLogin);
            else
                controlErrores.Dispose();
        }

        private void btnAddImagenUsuario_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = Properties.Resources.msgAbrirImagenUsuarioTitulo;
            dlg.Filter = Properties.Resources.msgAbrirImagenUsuario;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgUsuario.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void btnDelImagenUsuario_Click(object sender, EventArgs e)
        {
            imgUsuario.Image = Properties.Resources.profile;
        }
    }
}
