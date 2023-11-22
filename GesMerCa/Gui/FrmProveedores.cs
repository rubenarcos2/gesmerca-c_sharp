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
    public partial class FrmProveedores : Form
    {
        private FrmAltaProveedores frmAltaProveedor;

        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void btnAltaProveedor_Click(object sender, EventArgs e)
        {
            if (frmAltaProveedor == null)
            {
                frmAltaProveedor = new FrmAltaProveedores();
                frmAltaProveedor.MdiParent = this.MdiParent.MdiParent;
                frmAltaProveedor.ShowDialog();
                frmAltaProveedor.BringToFront();
                frmAltaProveedor.Focus();
                frmAltaProveedor.FormClosed += new FormClosedEventHandler(cierreFrmAltaProveedor);
            }
            else
            {
                frmAltaProveedor.Activate();
            }
        }

        private void cierreFrmAltaProveedor(object sender, FormClosedEventArgs e)
        {
            frmAltaProveedor = null;
        }
    }
}
