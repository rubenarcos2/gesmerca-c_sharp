namespace GesMerCa
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.contenedorBarraHerramienta = new System.Windows.Forms.ToolStripContainer();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModulosProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModulosProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModulosRecMercancia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdminSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentana = new System.Windows.Forms.ToolStripMenuItem();
            this.menVentanasCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.menVentanasApiladas = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarVentanasEnParaleloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVentanasOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraHerramientas = new System.Windows.Forms.ToolStrip();
            this.barraHerramientasProveedores = new System.Windows.Forms.ToolStripButton();
            this.barraHerramientasProductos = new System.Windows.Forms.ToolStripButton();
            this.barraHerramientasRecMercancia = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.barraHerramientasAdministracion = new System.Windows.Forms.ToolStripButton();
            this.barraHerramientasUsuarios = new System.Windows.Forms.ToolStripButton();
            this.barraHerramientasSeguridad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.barraHerramientasBloquearTerminal = new System.Windows.Forms.ToolStripButton();
            this.barraEstado = new System.Windows.Forms.StatusStrip();
            this.barraEstadoTxtReloj = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUssActual = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.nuevoBotonPresentacion = new System.Windows.Forms.ToolStripButton();
            this.contenedorBarraHerramienta.TopToolStripPanel.SuspendLayout();
            this.contenedorBarraHerramienta.SuspendLayout();
            this.menu.SuspendLayout();
            this.barraHerramientas.SuspendLayout();
            this.barraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorBarraHerramienta
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta, "contenedorBarraHerramienta");
            // 
            // contenedorBarraHerramienta.BottomToolStripPanel
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta.BottomToolStripPanel, "contenedorBarraHerramienta.BottomToolStripPanel");
            this.contenedorBarraHerramienta.BottomToolStripPanelVisible = false;
            // 
            // contenedorBarraHerramienta.ContentPanel
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta.ContentPanel, "contenedorBarraHerramienta.ContentPanel");
            // 
            // contenedorBarraHerramienta.LeftToolStripPanel
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta.LeftToolStripPanel, "contenedorBarraHerramienta.LeftToolStripPanel");
            this.contenedorBarraHerramienta.LeftToolStripPanelVisible = false;
            this.contenedorBarraHerramienta.Name = "contenedorBarraHerramienta";
            // 
            // contenedorBarraHerramienta.RightToolStripPanel
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta.RightToolStripPanel, "contenedorBarraHerramienta.RightToolStripPanel");
            this.contenedorBarraHerramienta.RightToolStripPanelVisible = false;
            // 
            // contenedorBarraHerramienta.TopToolStripPanel
            // 
            resources.ApplyResources(this.contenedorBarraHerramienta.TopToolStripPanel, "contenedorBarraHerramienta.TopToolStripPanel");
            this.contenedorBarraHerramienta.TopToolStripPanel.Controls.Add(this.menu);
            this.contenedorBarraHerramienta.TopToolStripPanel.Controls.Add(this.barraHerramientas);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuModulos,
            this.menuAdmin,
            this.menuVentana,
            this.ayudaToolStripMenuItem});
            this.menu.MdiWindowListItem = this.menuVentana;
            this.menu.Name = "menu";
            this.menu.TabStop = true;
            // 
            // menuArchivo
            // 
            resources.ApplyResources(this.menuArchivo, "menuArchivo");
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.menuArchivoSalir});
            this.menuArchivo.Name = "menuArchivo";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // menuArchivoSalir
            // 
            resources.ApplyResources(this.menuArchivoSalir, "menuArchivoSalir");
            this.menuArchivoSalir.Image = global::GesMerCa.Properties.Resources.Close_16x16_72;
            this.menuArchivoSalir.Name = "menuArchivoSalir";
            this.menuArchivoSalir.Click += new System.EventHandler(this.menuArchivoSalir_Click);
            // 
            // menuModulos
            // 
            resources.ApplyResources(this.menuModulos, "menuModulos");
            this.menuModulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModulosProveedores,
            this.menuModulosProductos,
            this.menuModulosRecMercancia});
            this.menuModulos.Name = "menuModulos";
            // 
            // menuModulosProveedores
            // 
            resources.ApplyResources(this.menuModulosProveedores, "menuModulosProveedores");
            this.menuModulosProveedores.Image = global::GesMerCa.Properties.Resources.contacts;
            this.menuModulosProveedores.Name = "menuModulosProveedores";
            this.menuModulosProveedores.Click += new System.EventHandler(this.barraHerramientasProveedores_Click);
            // 
            // menuModulosProductos
            // 
            resources.ApplyResources(this.menuModulosProductos, "menuModulosProductos");
            this.menuModulosProductos.Image = global::GesMerCa.Properties.Resources.cart;
            this.menuModulosProductos.Name = "menuModulosProductos";
            this.menuModulosProductos.Click += new System.EventHandler(this.barraHerramientasProductos_Click);
            // 
            // menuModulosRecMercancia
            // 
            resources.ApplyResources(this.menuModulosRecMercancia, "menuModulosRecMercancia");
            this.menuModulosRecMercancia.Image = global::GesMerCa.Properties.Resources.dolly;
            this.menuModulosRecMercancia.Name = "menuModulosRecMercancia";
            this.menuModulosRecMercancia.Click += new System.EventHandler(this.barraHerramientasRecepcionMercancia_Click);
            // 
            // menuAdmin
            // 
            resources.ApplyResources(this.menuAdmin, "menuAdmin");
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdminAdministracion,
            this.menuAdminUsuarios,
            this.menuAdminSeguridad});
            this.menuAdmin.Name = "menuAdmin";
            // 
            // menuAdminAdministracion
            // 
            resources.ApplyResources(this.menuAdminAdministracion, "menuAdminAdministracion");
            this.menuAdminAdministracion.Image = global::GesMerCa.Properties.Resources.gear;
            this.menuAdminAdministracion.Name = "menuAdminAdministracion";
            this.menuAdminAdministracion.Click += new System.EventHandler(this.barraHerramientasConfig_Click);
            // 
            // menuAdminUsuarios
            // 
            resources.ApplyResources(this.menuAdminUsuarios, "menuAdminUsuarios");
            this.menuAdminUsuarios.Image = global::GesMerCa.Properties.Resources.key;
            this.menuAdminUsuarios.Name = "menuAdminUsuarios";
            this.menuAdminUsuarios.Click += new System.EventHandler(this.barraHerramientasUsuarios_Click);
            // 
            // menuAdminSeguridad
            // 
            resources.ApplyResources(this.menuAdminSeguridad, "menuAdminSeguridad");
            this.menuAdminSeguridad.Image = global::GesMerCa.Properties.Resources.security;
            this.menuAdminSeguridad.Name = "menuAdminSeguridad";
            this.menuAdminSeguridad.Click += new System.EventHandler(this.barraHerramientasSeguridad_Click);
            // 
            // menuVentana
            // 
            resources.ApplyResources(this.menuVentana, "menuVentana");
            this.menuVentana.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menVentanasCascada,
            this.menVentanasApiladas,
            this.mostrarVentanasEnParaleloToolStripMenuItem,
            this.menuVentanasOrdenar});
            this.menuVentana.Name = "menuVentana";
            // 
            // menVentanasCascada
            // 
            resources.ApplyResources(this.menVentanasCascada, "menVentanasCascada");
            this.menVentanasCascada.Image = global::GesMerCa.Properties.Resources.CascadeWindows;
            this.menVentanasCascada.Name = "menVentanasCascada";
            this.menVentanasCascada.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // menVentanasApiladas
            // 
            resources.ApplyResources(this.menVentanasApiladas, "menVentanasApiladas");
            this.menVentanasApiladas.Image = global::GesMerCa.Properties.Resources.TileWindowsHorizontallyHS;
            this.menVentanasApiladas.Name = "menVentanasApiladas";
            this.menVentanasApiladas.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // mostrarVentanasEnParaleloToolStripMenuItem
            // 
            resources.ApplyResources(this.mostrarVentanasEnParaleloToolStripMenuItem, "mostrarVentanasEnParaleloToolStripMenuItem");
            this.mostrarVentanasEnParaleloToolStripMenuItem.Image = global::GesMerCa.Properties.Resources.TileVertically_2065_32;
            this.mostrarVentanasEnParaleloToolStripMenuItem.Name = "mostrarVentanasEnParaleloToolStripMenuItem";
            this.mostrarVentanasEnParaleloToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // menuVentanasOrdenar
            // 
            resources.ApplyResources(this.menuVentanasOrdenar, "menuVentanasOrdenar");
            this.menuVentanasOrdenar.Name = "menuVentanasOrdenar";
            this.menuVentanasOrdenar.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            resources.ApplyResources(this.ayudaToolStripMenuItem, "ayudaToolStripMenuItem");
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // acercadeToolStripMenuItem
            // 
            resources.ApplyResources(this.acercadeToolStripMenuItem, "acercadeToolStripMenuItem");
            this.acercadeToolStripMenuItem.Image = global::GesMerCa.Properties.Resources.settings;
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Click += new System.EventHandler(this.acercadeToolStripMenuItem_Click);
            // 
            // barraHerramientas
            // 
            resources.ApplyResources(this.barraHerramientas, "barraHerramientas");
            this.barraHerramientas.AllowItemReorder = true;
            this.barraHerramientas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraHerramientasProveedores,
            this.barraHerramientasProductos,
            this.barraHerramientasRecMercancia,
            this.toolStripSeparator8,
            this.barraHerramientasAdministracion,
            this.barraHerramientasUsuarios,
            this.barraHerramientasSeguridad,
            this.toolStripSeparator1,
            this.barraHerramientasBloquearTerminal,
            this.nuevoBotonPresentacion});
            this.barraHerramientas.Name = "barraHerramientas";
            // 
            // barraHerramientasProveedores
            // 
            resources.ApplyResources(this.barraHerramientasProveedores, "barraHerramientasProveedores");
            this.barraHerramientasProveedores.Image = global::GesMerCa.Properties.Resources.contacts;
            this.barraHerramientasProveedores.Name = "barraHerramientasProveedores";
            this.barraHerramientasProveedores.Click += new System.EventHandler(this.barraHerramientasProveedores_Click);
            // 
            // barraHerramientasProductos
            // 
            resources.ApplyResources(this.barraHerramientasProductos, "barraHerramientasProductos");
            this.barraHerramientasProductos.Image = global::GesMerCa.Properties.Resources.cart;
            this.barraHerramientasProductos.Name = "barraHerramientasProductos";
            this.barraHerramientasProductos.Click += new System.EventHandler(this.barraHerramientasProductos_Click);
            // 
            // barraHerramientasRecMercancia
            // 
            resources.ApplyResources(this.barraHerramientasRecMercancia, "barraHerramientasRecMercancia");
            this.barraHerramientasRecMercancia.Image = global::GesMerCa.Properties.Resources.dolly;
            this.barraHerramientasRecMercancia.Name = "barraHerramientasRecMercancia";
            this.barraHerramientasRecMercancia.Click += new System.EventHandler(this.barraHerramientasRecepcionMercancia_Click);
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // barraHerramientasAdministracion
            // 
            resources.ApplyResources(this.barraHerramientasAdministracion, "barraHerramientasAdministracion");
            this.barraHerramientasAdministracion.Image = global::GesMerCa.Properties.Resources.gear;
            this.barraHerramientasAdministracion.Name = "barraHerramientasAdministracion";
            this.barraHerramientasAdministracion.Click += new System.EventHandler(this.barraHerramientasConfig_Click);
            // 
            // barraHerramientasUsuarios
            // 
            resources.ApplyResources(this.barraHerramientasUsuarios, "barraHerramientasUsuarios");
            this.barraHerramientasUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.barraHerramientasUsuarios.Image = global::GesMerCa.Properties.Resources.key;
            this.barraHerramientasUsuarios.Name = "barraHerramientasUsuarios";
            this.barraHerramientasUsuarios.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.barraHerramientasUsuarios.Click += new System.EventHandler(this.barraHerramientasUsuarios_Click);
            // 
            // barraHerramientasSeguridad
            // 
            resources.ApplyResources(this.barraHerramientasSeguridad, "barraHerramientasSeguridad");
            this.barraHerramientasSeguridad.Image = global::GesMerCa.Properties.Resources.security;
            this.barraHerramientasSeguridad.Name = "barraHerramientasSeguridad";
            this.barraHerramientasSeguridad.Click += new System.EventHandler(this.barraHerramientasSeguridad_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // barraHerramientasBloquearTerminal
            // 
            resources.ApplyResources(this.barraHerramientasBloquearTerminal, "barraHerramientasBloquearTerminal");
            this.barraHerramientasBloquearTerminal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barraHerramientasBloquearTerminal.Image = global::GesMerCa.Properties.Resources.unlocked;
            this.barraHerramientasBloquearTerminal.Name = "barraHerramientasBloquearTerminal";
            this.barraHerramientasBloquearTerminal.Click += new System.EventHandler(this.barraHerramientasBloquearTerminal_Click);
            // 
            // barraEstado
            // 
            resources.ApplyResources(this.barraEstado, "barraEstado");
            this.barraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraEstadoTxtReloj,
            this.lblUssActual});
            this.barraEstado.Name = "barraEstado";
            this.barraEstado.ShowItemToolTips = true;
            // 
            // barraEstadoTxtReloj
            // 
            resources.ApplyResources(this.barraEstadoTxtReloj, "barraEstadoTxtReloj");
            this.barraEstadoTxtReloj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.barraEstadoTxtReloj.Name = "barraEstadoTxtReloj";
            // 
            // lblUssActual
            // 
            resources.ApplyResources(this.lblUssActual, "lblUssActual");
            this.lblUssActual.Name = "lblUssActual";
            // 
            // timerReloj
            // 
            this.timerReloj.Enabled = true;
            this.timerReloj.Tick += new System.EventHandler(this.actualizarReloj);
            // 
            // BottomToolStripPanel
            // 
            resources.ApplyResources(this.BottomToolStripPanel, "BottomToolStripPanel");
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // TopToolStripPanel
            // 
            resources.ApplyResources(this.TopToolStripPanel, "TopToolStripPanel");
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // RightToolStripPanel
            // 
            resources.ApplyResources(this.RightToolStripPanel, "RightToolStripPanel");
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // LeftToolStripPanel
            // 
            resources.ApplyResources(this.LeftToolStripPanel, "LeftToolStripPanel");
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            // 
            // ContentPanel
            // 
            resources.ApplyResources(this.ContentPanel, "ContentPanel");
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            // 
            // nuevoBotonPresentacion
            // 
            resources.ApplyResources(this.nuevoBotonPresentacion, "nuevoBotonPresentacion");
            this.nuevoBotonPresentacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevoBotonPresentacion.Name = "nuevoBotonPresentacion";
            // 
            // FrmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GesMerCa.Properties.Resources.dolly;
            this.Controls.Add(this.barraEstado);
            this.Controls.Add(this.contenedorBarraHerramienta);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.contenedorBarraHerramienta.TopToolStripPanel.ResumeLayout(false);
            this.contenedorBarraHerramienta.TopToolStripPanel.PerformLayout();
            this.contenedorBarraHerramienta.ResumeLayout(false);
            this.contenedorBarraHerramienta.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.barraHerramientas.ResumeLayout(false);
            this.barraHerramientas.PerformLayout();
            this.barraEstado.ResumeLayout(false);
            this.barraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuAdminAdministracion;
        private System.Windows.Forms.ToolStripMenuItem menuAdminUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuVentana;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraHerramientas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton barraHerramientasAdministracion;
        private System.Windows.Forms.ToolStripButton barraHerramientasProveedores;
        private System.Windows.Forms.StatusStrip barraEstado;
        private System.Windows.Forms.ToolStripStatusLabel barraEstadoTxtReloj;
        private System.Windows.Forms.ToolStripMenuItem menVentanasCascada;
        private System.Windows.Forms.ToolStripMenuItem menVentanasApiladas;
        private System.Windows.Forms.ToolStripMenuItem mostrarVentanasEnParaleloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuVentanasOrdenar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripContainer contenedorBarraHerramienta;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton barraHerramientasUsuarios;
        private System.Windows.Forms.ToolStripButton barraHerramientasBloquearTerminal;
        private System.Windows.Forms.ToolStripStatusLabel lblUssActual;
        private System.Windows.Forms.ToolStripButton barraHerramientasProductos;
        private System.Windows.Forms.ToolStripButton barraHerramientasRecMercancia;
        private System.Windows.Forms.ToolStripMenuItem menuModulos;
        private System.Windows.Forms.ToolStripMenuItem menuModulosProveedores;
        private System.Windows.Forms.ToolStripMenuItem menuModulosProductos;
        private System.Windows.Forms.ToolStripMenuItem menuModulosRecMercancia;
        private System.Windows.Forms.ToolStripButton barraHerramientasSeguridad;
        private System.Windows.Forms.ToolStripMenuItem menuAdminSeguridad;
        private System.Windows.Forms.ToolStripButton nuevoBotonPresentacion;
    }
}

