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
    public partial class FrmConfigAltaOpc : Form
    {
        public FrmConfigAltaOpc()
        {
            InitializeComponent();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool error = false;
            controlErrores.Dispose();

            if (string.IsNullOrEmpty(txtPropiedad.Text))
            {
                controlErrores.SetError(txtPropiedad, Properties.Resources.msgControlErrorAltaOpcPropiedad);
                error = true;
            }
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                controlErrores.SetError(txtTitulo, Properties.Resources.msgControlErrorAltaOpcTitulo);
                error = true;
            }
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                controlErrores.SetError(txtValor, Properties.Resources.msgControlErrorAltaOpcValor);
                error = true;
            }
            if (string.IsNullOrEmpty(txtDominio.Text))
            {
                controlErrores.SetError(txtDominio, Properties.Resources.msgControlErrorAltaOpcDominio);
                error = true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                controlErrores.SetError(txtDescripcion, Properties.Resources.msgControlErrorAltaOpcDescripcion);
                error = true;
            }
            if (!error)
                try
                {
                    if (Utils.OperBD.insertarOpcionesUsuario(-1, Utils.Const.TIPO_OPCION_CONFIG.GENERAL, new string[] { txtPropiedad.Text, txtValor.Text, txtTitulo.Text, txtDescripcion.Text, txtDominio.Text }) > 0)
                    {
                        MessageBox.Show(Properties.Resources.msgNuevaOpcionOK, Properties.Resources.msgNuevaOpcionOK, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        throw new Exception(Properties.Resources.msgAltaOpcSinModificaciones);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(Properties.Resources.msgAltaOpcSinModificaciones);
                    Inicio.log.Registro.Error("Error en la grabación de la nueva opción: " + ex);
                }
                
        }

        private void txtDominio_Enter(object sender, EventArgs e)
        {
            MessageBox.Show(Properties.Resources.msgAltaOpcValoresDominio);
        }
    }
}
