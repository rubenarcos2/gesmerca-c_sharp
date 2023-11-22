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
    public partial class FrmAltaProveedores : Form
    {
        public FrmAltaProveedores()
        {
            InitializeComponent();
        }

        private void txtCifNif_Leave(object sender, EventArgs e)
        {
            if (cmbCifNif.SelectedText == "CIF")
            {
                if (!Utils.Utilidades.Valida_CIF(txtCifNif.Text))
                    controlErrores.SetError(txtCifNif, Properties.Resources.msgAltaProveedorCif);
                else
                    controlErrores.Dispose();
            }
            else if (cmbCifNif.SelectedText == "NIF")
            {
                if (!Utils.Utilidades.VerificarNIF(txtCifNif.Text))
                    controlErrores.SetError(txtCifNif, Properties.Resources.msgAltaProveedorNif);
                else
                    controlErrores.Dispose();
            }

        }

        private void txtCifNif_Enter(object sender, EventArgs e)
        {
            txtCifNif.Clear();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            controlErrores.Dispose();

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                controlErrores.SetError(txtNombre, Properties.Resources.msgAltaProveedorErrorProv);
                error = true;
            }
            if (string.IsNullOrEmpty(txtCifNif.Text))
            {
                controlErrores.SetError(txtCifNif, Properties.Resources.msgAltaProveedorErrorCif);
                error = true;
            }
            else
            {
                if (cmbCifNif.SelectedText == "CIF")
                {
                    if (!Utils.Utilidades.Valida_CIF(txtCifNif.Text))
                    {
                        controlErrores.SetError(txtCifNif, Properties.Resources.msgAltaProveedorErrorCifValido);
                        error = true;
                    }
                }
                else if (cmbCifNif.SelectedText == "NIF")
                {
                    if (!Utils.Utilidades.VerificarNIF(txtCifNif.Text))
                    {
                        controlErrores.SetError(txtCifNif, Properties.Resources.msgAltaProveedorErrorCifValido);
                        error = true;
                    }
                }
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                controlErrores.SetError(txtDireccion, Properties.Resources.msgAltaProveedorErrorDireccion);
                error = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))//Campo no obligatorio
            {
                controlErrores.SetError(txtEmail, Properties.Resources.msgAltaProveedorErrorEmail);
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))//Campo no obligatorio
            {
                controlErrores.SetError(txtTelefono, Properties.Resources.msgAltaProveedorErrorTlf);
            }
            if (string.IsNullOrEmpty(txtWeb.Text))//Campo no obligatorio
            {
                controlErrores.SetError(txtWeb, Properties.Resources.msgAltaProveedorErrorWeb);
            }
            if (string.IsNullOrEmpty(txtObservaciones.Text))//Campo no obligatorio
            {
                controlErrores.SetError(txtObservaciones, Properties.Resources.msgAltaProveedorErrorObs);
            }
            if (!error)
                try
                {
                    if (Utils.OperBD.insertarProveedor(new string[] { cmbCifNif.Text, txtCifNif.Text, txtNombre.Text, txtDireccion.Text, txtLocalidad.Text, txtTelefono.Text, txtEmail.Text, txtWeb.Text, txtObservaciones.Text }) > 0)
                    {
                        MessageBox.Show(Properties.Resources.msgAltaProveedorOK);
                        Close();
                    }
                    else
                    {
                        throw new Exception(Properties.Resources.msgAltaProveedorError);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Properties.Resources.msgAltaProveedorError, Properties.Resources.msgAltaProveedorError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Inicio.log.Registro.Error("Error grabación proveedor: " + ex);
                }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
