/*
* PROYECTO.............: Proyecto integrado
* NOMBRE y APELLIDOS...: Rubén Arcos Ortega
* CURSO y GRUPO........: 2º Desarrollo de aplicaciones multiplataforma (D.A.M.)
* TÍTULO de la PRÁCTICA: GesMerCa - Gestión de Recepcionamiento de Mercancías con Control de Acceso
* FECHA de ENTREGA.....: 15 / 06 / 2016
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GesMerCa
{
    public partial class FrmPrincipal : Form
    {
        private bool horaConFecha = false;
        private string modoOcultacionElementos = null;

        private FrmProveedores proveedores;
        private FrmProductos productos;
        private FrmRecepcionMercancia recepcionMercancia;

        private FrmConfig configuracion;
        private FrmUsuarios usuarios;
        private FrmSeguridad seguridad;

        private Timer timerEsperaTTS;

        public FrmPrincipal()
        {
            InitializeComponent();
            cargarOpciones();
            cargarDatosUsuario();
            activaRestriccionesAcceso();
        }

        private void cargarOpciones()
        {
            pantallaCompleta(Convert.ToBoolean(Utils.Utilidades.opcsGen.getValorClave("fullscreen")));
            horaConFecha = Convert.ToBoolean(Utils.Utilidades.opcsGen.getValorClave("horaConFecha"));
            modoOcultacionElementos = Utils.Utilidades.opcsGen.getValorClave("modoOcultacionElementos");
        }

        #region Gestión privilegios

        private void activaRestriccionesAcceso()
        {
            //Extrae todas las restricciones disponibles en la BD
            Utils.Utilidades.listaRestriccionesRolUsuario = Utils.OperBD.consultarModulosDisponibles(Utils.Utilidades.usuarioActual.IdRol);

            //Recorre todos los elementos de la barra de herramientas
            foreach (ToolStripButton btnBarra in getElementosBarraHerramienta(barraHerramientas))
            {
                foreach (string[] restrinccion in Utils.Utilidades.listaRestriccionesRolUsuario)
                {
                    if (btnBarra.Name == restrinccion[0] && !Convert.ToBoolean(restrinccion[1]))
                    {
                        if (modoOcultacionElementos == "Enabled")//Se verán los botonse deshabilitados
                            btnBarra.Enabled = false;
                        else                                    //Desaparecerán los botones
                            btnBarra.Visible = false;
                    }
                }
                btnBarra.MouseHover += new EventHandler(lanzarTTS);
            }

            foreach (ToolStripMenuItem elmMenu in getElementosMenuSuperior(menuModulos))
            {
                foreach (string[] restrinccion in Utils.Utilidades.listaRestriccionesRolUsuario)
                {
                    if (elmMenu.Name == restrinccion[0] && !Convert.ToBoolean(restrinccion[1]))
                    {
                        if (modoOcultacionElementos == "Enabled")//Se verán los botonse deshabilitados
                            elmMenu.Enabled = false;
                        else                                    //Desaparecerán los botones
                            elmMenu.Visible = false;
                    }
                    elmMenu.MouseHover += new EventHandler(lanzarTTS);
                }
            }

            foreach (ToolStripMenuItem elmMenu in getElementosMenuSuperior(menuAdmin))
            {
                foreach (string[] restrinccion in Utils.Utilidades.listaRestriccionesRolUsuario)
                {
                    if (elmMenu.Name == restrinccion[0] && !Convert.ToBoolean(restrinccion[1]))
                    {
                        if (modoOcultacionElementos == "Enabled")//Se verán los botonse deshabilitados
                            elmMenu.Enabled = false;
                        else                                    //Desaparecerán los botones
                            elmMenu.Visible = false;
                    }
                    elmMenu.MouseHover += new EventHandler(lanzarTTS);
                }
            }
            menu.Refresh();
            this.Refresh();
        }

        //Obtiene todos los elementos de la barra de herramientas
        private List<ToolStripButton> getElementosBarraHerramienta(ToolStrip barraHerramientas)
        {
            bool creadaListaElem = false;

            List<ToolStripButton> listaBotonesBarra = new List<ToolStripButton>();
            //Si la lista de elementos pública no existe aún
            if (Utils.Utilidades.listaElementosBarraHerramientas == null)
            {
                Utils.Utilidades.listaElementosBarraHerramientas = new List<string>();
            }
            else
            {
                creadaListaElem = true;
            }


            foreach (ToolStripItem botonBarra in barraHerramientas.Items)
            {
                if (botonBarra is ToolStripButton)
                {
                    listaBotonesBarra.Add((ToolStripButton)botonBarra);
                    //Añade el elemento a la lista de elementos pública
                    if (!creadaListaElem)
                        Utils.Utilidades.listaElementosBarraHerramientas.Add(botonBarra.Name);
                }
            }

            return listaBotonesBarra;
        }

        //Obtiene todos los elementos del menú superior
        private List<ToolStripMenuItem> getElementosMenuSuperior(ToolStripMenuItem barraHerramientas)
        {
            //bool creadaListaElem = false;

            List<ToolStripMenuItem> listaElementosMenu = new List<ToolStripMenuItem>();
            //Si la lista de elementos pública no existe aún
            if (Utils.Utilidades.listaElementosMenuSuperior == null)
            {
                Utils.Utilidades.listaElementosMenuSuperior = new List<string>();
            }
            foreach (ToolStripMenuItem elemMenu in barraHerramientas.DropDownItems)
            {
                if (elemMenu is ToolStripMenuItem)
                {
                    listaElementosMenu.Add((ToolStripMenuItem)elemMenu);
                    //Añade el elemento a la lista de elementos pública
                    Utils.Utilidades.listaElementosMenuSuperior.Add(elemMenu.Name);
                }
            }
            return listaElementosMenu;
        }
        #endregion

        #region Aspecto ventana

        private void pantallaCompleta(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
                this.TopMost = true;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.TopMost = false;
            }
        }

        private void actualizarReloj(object sender, EventArgs e)
        {
            if (horaConFecha)
                barraEstadoTxtReloj.Text = DateTime.Now.ToShortTimeString() + "\n" + DateTime.Now.ToShortDateString();
            else
                barraEstadoTxtReloj.Text = DateTime.Now.ToShortTimeString();
            barraEstadoTxtReloj.ToolTipText = DateTime.Now.ToLongDateString();
            barraEstadoTxtReloj.MouseHover += new EventHandler(lanzarTTS);
        }

        private void cargarDatosUsuario()
        {
            lblUssActual.Text = Utils.Utilidades.usuarioActual.NombreLogin;
            lblUssActual.ToolTipText = Utils.Utilidades.usuarioActual.Nombre + " " +
                Utils.Utilidades.usuarioActual.Apellido1 + " " +
                Utils.Utilidades.usuarioActual.Apellido2 + "\n(" +
                Utils.OperBD.consultarRolUsuario(Utils.Utilidades.usuarioActual.IdRol) + ")";
            lblUssActual.Image = Utils.OperBD.consultarImagenUsuario(Utils.Utilidades.usuarioActual.Id);
            if (horaConFecha)
                lblUssActual.TextImageRelation = TextImageRelation.ImageAboveText;
            else
                lblUssActual.TextImageRelation = TextImageRelation.TextBeforeImage;
            lblUssActual.MouseHover += new EventHandler(lanzarTTS);
        }

        private void lanzarTTS(object sender, EventArgs e)
        {
            if (timerEsperaTTS == null)
            {
                timerEsperaTTS = new Timer();
                timerEsperaTTS.Interval = 3000;
                timerEsperaTTS.Tick += new EventHandler(pararTTS);
            }
            if (!timerEsperaTTS.Enabled)
            {
                if (sender is ToolStripButton)
                {
                    ToolStripButton btn = (ToolStripButton)sender;
                    Utils.Utilidades.activarTTS(btn.ToolTipText);
                }
                else if (sender is ToolStripMenuItem)
                {
                    ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                    Utils.Utilidades.activarTTS(menu.Text);
                }
                else if (sender is Label)
                {
                    Label lbl = (Label)sender;
                    Utils.Utilidades.activarTTS(lbl.Text);
                }
                else if (sender is ToolStripStatusLabel)
                {
                    ToolStripStatusLabel lbl = (ToolStripStatusLabel)sender;
                    Utils.Utilidades.activarTTS(lbl.ToolTipText);
                }
                else
                {
                    Button btn = (Button)sender;
                    Utils.Utilidades.activarTTS(btn.Text);
                }
                timerEsperaTTS.Start();
            }
        }

        private void pararTTS(object sender, EventArgs e)
        {
            timerEsperaTTS.Stop();
        }

        #endregion

        #region Eventos Botones

        #region Botones Barra de Menús

        private void menuArchivoSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe frmAcercaDe = new frmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        #endregion

        #region Botones Barra Herramientas

        private void barraHerramientasProveedores_Click(object sender, EventArgs e)
        {
            if (proveedores == null)
            {
                proveedores = new FrmProveedores();
                proveedores.MdiParent = this;
                proveedores.StartPosition = FormStartPosition.Manual;
                proveedores.Location = new Point((this.ClientSize.Width - proveedores.Width) / 2, (this.ClientSize.Height - proveedores.Height) / 2);
                proveedores.Show();
                proveedores.BringToFront();
                proveedores.Focus();
                proveedores.FormClosed += new FormClosedEventHandler(cierreProveedores);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + proveedores.Text);
            }
            else
            {
                proveedores.Activate();
            }
        }
        private void cierreProveedores(object sender, FormClosedEventArgs e)
        {
            proveedores = null;
        }

        private void barraHerramientasProductos_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new FrmProductos();
                productos.MdiParent = this;
                productos.StartPosition = FormStartPosition.Manual;
                productos.Location = new Point((this.ClientSize.Width - productos.Width) / 2, (this.ClientSize.Height - productos.Height) / 2);
                productos.Show();
                productos.BringToFront();
                productos.Focus();
                productos.FormClosed += new FormClosedEventHandler(cierreProductos);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + productos.Text);
            }
            else
            {
                proveedores.Activate();
            }
        }
        private void cierreProductos(object sender, FormClosedEventArgs e)
        {
            productos = null;
        }

        private void barraHerramientasRecepcionMercancia_Click(object sender, EventArgs e)
        {
            if (recepcionMercancia == null)
            {
                recepcionMercancia = new FrmRecepcionMercancia();
                recepcionMercancia.MdiParent = this;
                recepcionMercancia.StartPosition = FormStartPosition.Manual;
                recepcionMercancia.Location = new Point((this.ClientSize.Width - recepcionMercancia.Width) / 2, (this.ClientSize.Height - recepcionMercancia.Height) / 2);
                recepcionMercancia.Show();
                recepcionMercancia.BringToFront();
                recepcionMercancia.Focus();
                recepcionMercancia.FormClosed += new FormClosedEventHandler(cierreRecepcionMercancia);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + recepcionMercancia.Text);
            }
            else
            {
                recepcionMercancia.Activate();
            }
        }
        private void cierreRecepcionMercancia(object sender, FormClosedEventArgs e)
        {
            recepcionMercancia = null;
        }

        private void barraHerramientasConfig_Click(object sender, EventArgs e)
        {
            if (configuracion == null)
            {
                configuracion = new FrmConfig();
                configuracion.MdiParent = this;
                configuracion.StartPosition = FormStartPosition.Manual;
                configuracion.Location = new Point((this.ClientSize.Width - configuracion.Width) / 2, (this.ClientSize.Height - configuracion.Height) / 2);
                configuracion.Show();
                configuracion.BringToFront();
                configuracion.Focus();
                configuracion.FormClosed += new FormClosedEventHandler(cierreConfig);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + configuracion.Text);
            }
            else
            {
                configuracion.Activate();
            }
        }

        private void cierreConfig(object sender, FormClosedEventArgs e)
        {
            configuracion = null;
        }

        private void barraHerramientasUsuarios_Click(object sender, EventArgs e)
        {
            if (usuarios == null)
            {
                usuarios = new FrmUsuarios();
                usuarios.MdiParent = this;
                usuarios.StartPosition = FormStartPosition.Manual;
                usuarios.Location = new Point((this.ClientSize.Width - usuarios.Width) / 2, (this.ClientSize.Height - usuarios.Height) / 2);
                usuarios.Show();
                usuarios.BringToFront();
                usuarios.Focus();
                usuarios.FormClosed += new FormClosedEventHandler(cierreUsuarios);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + usuarios.Text);
            }
            else
            {
                usuarios.Activate();
            }
        }

        private void cierreUsuarios(object sender, FormClosedEventArgs e)
        {
            usuarios = null;
        }

        private void barraHerramientasSeguridad_Click(object sender, EventArgs e)
        {
            if (seguridad == null)
            {
                seguridad = new FrmSeguridad();
                seguridad.MdiParent = this;
                seguridad.StartPosition = FormStartPosition.Manual;
                seguridad.Location = new Point((this.ClientSize.Width - seguridad.Width) / 2, (this.ClientSize.Height - seguridad.Height) / 2);
                seguridad.Show();
                seguridad.BringToFront();
                seguridad.Focus();
                seguridad.FormClosed += new FormClosedEventHandler(cierreSeguridad);
                Utils.Utilidades.activarTTS(Properties.Resources.msgVentana + seguridad.Text);
            }
            else
            {
                seguridad.Activate();
            }
        }

        private void cierreSeguridad(object sender, FormClosedEventArgs e)
        {
            seguridad = null;
        }

        private void barraHerramientasBloquearTerminal_Click(object sender, EventArgs e)
        {
            FrmBloqueoAcceso frmBloqueo = new FrmBloqueoAcceso(0);
            Utils.Utilidades.activarTTS(Properties.Resources.msgTerminalBloqueado);
            frmBloqueo.ShowDialog();
        }

        #endregion

        #endregion

        #region Eventos Formulario

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show(Properties.Resources.msgPrincipalSalir, Properties.Resources.msgPrincipalSalirTitulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            Utils.Utilidades.activarTTS(Properties.Resources.msgPrincipalSalir);
            if (dialogo != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        #endregion

        #region Control Ventanas MDI Child

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

    }
}
