namespace GesMerCa
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.grpFiltroUsuarios = new System.Windows.Forms.GroupBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnAltaLoginFacial = new System.Windows.Forms.Button();
            this.btnCambiarImgUss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            this.grpFiltroUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.BackColor = System.Drawing.Color.Orange;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // dataGridUsuarios
            // 
            resources.ApplyResources(this.dataGridUsuarios, "dataGridUsuarios");
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToOrderColumns = true;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.MultiSelect = false;
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellClick);
            this.dataGridUsuarios.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_RowValidated);
            // 
            // grpUsuarios
            // 
            resources.ApplyResources(this.grpUsuarios, "grpUsuarios");
            this.grpUsuarios.Controls.Add(this.dataGridUsuarios);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.TabStop = false;
            // 
            // grpFiltroUsuarios
            // 
            resources.ApplyResources(this.grpFiltroUsuarios, "grpFiltroUsuarios");
            this.grpFiltroUsuarios.Controls.Add(this.txtApellido2);
            this.grpFiltroUsuarios.Controls.Add(this.lblApellido2);
            this.grpFiltroUsuarios.Controls.Add(this.txtApellido1);
            this.grpFiltroUsuarios.Controls.Add(this.lblApellido1);
            this.grpFiltroUsuarios.Controls.Add(this.txtNombre);
            this.grpFiltroUsuarios.Controls.Add(this.lblNombre);
            this.grpFiltroUsuarios.Controls.Add(this.txtUsuario);
            this.grpFiltroUsuarios.Controls.Add(this.lblUsuario);
            this.grpFiltroUsuarios.Name = "grpFiltroUsuarios";
            this.grpFiltroUsuarios.TabStop = false;
            // 
            // txtApellido2
            // 
            resources.ApplyResources(this.txtApellido2, "txtApellido2");
            this.txtApellido2.Name = "txtApellido2";
            // 
            // lblApellido2
            // 
            resources.ApplyResources(this.lblApellido2, "lblApellido2");
            this.lblApellido2.Name = "lblApellido2";
            // 
            // txtApellido1
            // 
            resources.ApplyResources(this.txtApellido1, "txtApellido1");
            this.txtApellido1.Name = "txtApellido1";
            // 
            // lblApellido1
            // 
            resources.ApplyResources(this.lblApellido1, "lblApellido1");
            this.lblApellido1.Name = "lblApellido1";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnFiltrar
            // 
            resources.ApplyResources(this.btnFiltrar, "btnFiltrar");
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.Image = global::GesMerCa.Properties.Resources.Filter;
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnAltaUsuario
            // 
            resources.ApplyResources(this.btnAltaUsuario, "btnAltaUsuario");
            this.btnAltaUsuario.Image = global::GesMerCa.Properties.Resources.profle;
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnAltaLoginFacial
            // 
            resources.ApplyResources(this.btnAltaLoginFacial, "btnAltaLoginFacial");
            this.btnAltaLoginFacial.Image = global::GesMerCa.Properties.Resources.camera;
            this.btnAltaLoginFacial.Name = "btnAltaLoginFacial";
            this.btnAltaLoginFacial.UseVisualStyleBackColor = true;
            this.btnAltaLoginFacial.Click += new System.EventHandler(this.btnAltaLoginFacial_Click);
            // 
            // btnCambiarImgUss
            // 
            resources.ApplyResources(this.btnCambiarImgUss, "btnCambiarImgUss");
            this.btnCambiarImgUss.FlatAppearance.BorderSize = 0;
            this.btnCambiarImgUss.Image = global::GesMerCa.Properties.Resources.base_picture_32;
            this.btnCambiarImgUss.Name = "btnCambiarImgUss";
            this.btnCambiarImgUss.UseVisualStyleBackColor = true;
            this.btnCambiarImgUss.Click += new System.EventHandler(this.btnCambiarImgUss_Click);
            // 
            // FrmUsuarios
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCambiarImgUss);
            this.Controls.Add(this.btnAltaLoginFacial);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnAltaUsuario);
            this.Controls.Add(this.grpFiltroUsuarios);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            this.Shown += new System.EventHandler(this.FrmUsuarios_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpFiltroUsuarios.ResumeLayout(false);
            this.grpFiltroUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.GroupBox grpFiltroUsuarios;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnAltaLoginFacial;
        private System.Windows.Forms.Button btnCambiarImgUss;
    }
}