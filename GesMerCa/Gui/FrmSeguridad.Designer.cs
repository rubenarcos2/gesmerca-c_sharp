namespace GesMerCa
{
    partial class FrmSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSeguridad));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabSeguridad = new System.Windows.Forms.TabControl();
            this.tabRoles = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelUssRol = new System.Windows.Forms.Button();
            this.btnAddUssRol = new System.Windows.Forms.Button();
            this.lblCmbRoles = new System.Windows.Forms.Label();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.listBoxUssRol = new System.Windows.Forms.ListBox();
            this.listBoxTodosUss = new System.Windows.Forms.ListBox();
            this.tabModulos = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxElementosRestringidosRol = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelModuloRol = new System.Windows.Forms.Button();
            this.btnAddModuloRol = new System.Windows.Forms.Button();
            this.btnDelElmModulo = new System.Windows.Forms.Button();
            this.btnAddElmModulo = new System.Windows.Forms.Button();
            this.listBoxElementosRestringidos = new System.Windows.Forms.ListBox();
            this.listBoxTodosElementosApp = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRolesMod = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabSeguridad.SuspendLayout();
            this.tabRoles.SuspendLayout();
            this.tabModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.BackColor = System.Drawing.Color.DarkRed;
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // tabSeguridad
            // 
            resources.ApplyResources(this.tabSeguridad, "tabSeguridad");
            this.tabSeguridad.Controls.Add(this.tabRoles);
            this.tabSeguridad.Controls.Add(this.tabModulos);
            this.tabSeguridad.Name = "tabSeguridad";
            this.tabSeguridad.SelectedIndex = 0;
            // 
            // tabRoles
            // 
            resources.ApplyResources(this.tabRoles, "tabRoles");
            this.tabRoles.Controls.Add(this.label3);
            this.tabRoles.Controls.Add(this.label2);
            this.tabRoles.Controls.Add(this.btnDelUssRol);
            this.tabRoles.Controls.Add(this.btnAddUssRol);
            this.tabRoles.Controls.Add(this.lblCmbRoles);
            this.tabRoles.Controls.Add(this.cmbRoles);
            this.tabRoles.Controls.Add(this.listBoxUssRol);
            this.tabRoles.Controls.Add(this.listBoxTodosUss);
            this.tabRoles.Name = "tabRoles";
            this.tabRoles.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnDelUssRol
            // 
            resources.ApplyResources(this.btnDelUssRol, "btnDelUssRol");
            this.btnDelUssRol.Name = "btnDelUssRol";
            this.btnDelUssRol.UseVisualStyleBackColor = true;
            this.btnDelUssRol.Click += new System.EventHandler(this.btnDelUssRol_Click);
            // 
            // btnAddUssRol
            // 
            resources.ApplyResources(this.btnAddUssRol, "btnAddUssRol");
            this.btnAddUssRol.Name = "btnAddUssRol";
            this.btnAddUssRol.UseVisualStyleBackColor = true;
            this.btnAddUssRol.Click += new System.EventHandler(this.btnAddUssRol_Click);
            // 
            // lblCmbRoles
            // 
            resources.ApplyResources(this.lblCmbRoles, "lblCmbRoles");
            this.lblCmbRoles.Name = "lblCmbRoles";
            // 
            // cmbRoles
            // 
            resources.ApplyResources(this.cmbRoles, "cmbRoles");
            this.cmbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.SelectedIndexChanged += new System.EventHandler(this.cmbRoles_SelectedIndexChanged);
            // 
            // listBoxUssRol
            // 
            resources.ApplyResources(this.listBoxUssRol, "listBoxUssRol");
            this.listBoxUssRol.FormattingEnabled = true;
            this.listBoxUssRol.Name = "listBoxUssRol";
            // 
            // listBoxTodosUss
            // 
            resources.ApplyResources(this.listBoxTodosUss, "listBoxTodosUss");
            this.listBoxTodosUss.FormattingEnabled = true;
            this.listBoxTodosUss.Name = "listBoxTodosUss";
            // 
            // tabModulos
            // 
            resources.ApplyResources(this.tabModulos, "tabModulos");
            this.tabModulos.Controls.Add(this.label7);
            this.tabModulos.Controls.Add(this.listBoxElementosRestringidosRol);
            this.tabModulos.Controls.Add(this.label6);
            this.tabModulos.Controls.Add(this.label5);
            this.tabModulos.Controls.Add(this.label4);
            this.tabModulos.Controls.Add(this.btnDelModuloRol);
            this.tabModulos.Controls.Add(this.btnAddModuloRol);
            this.tabModulos.Controls.Add(this.btnDelElmModulo);
            this.tabModulos.Controls.Add(this.btnAddElmModulo);
            this.tabModulos.Controls.Add(this.listBoxElementosRestringidos);
            this.tabModulos.Controls.Add(this.listBoxTodosElementosApp);
            this.tabModulos.Controls.Add(this.label1);
            this.tabModulos.Controls.Add(this.cmbRolesMod);
            this.tabModulos.Name = "tabModulos";
            this.tabModulos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // listBoxElementosRestringidosRol
            // 
            resources.ApplyResources(this.listBoxElementosRestringidosRol, "listBoxElementosRestringidosRol");
            this.listBoxElementosRestringidosRol.FormattingEnabled = true;
            this.listBoxElementosRestringidosRol.Name = "listBoxElementosRestringidosRol";
            this.listBoxElementosRestringidosRol.DoubleClick += new System.EventHandler(this.listBoxElementosRestringidosRol_ItemCheck);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnDelModuloRol
            // 
            resources.ApplyResources(this.btnDelModuloRol, "btnDelModuloRol");
            this.btnDelModuloRol.Name = "btnDelModuloRol";
            this.btnDelModuloRol.UseVisualStyleBackColor = true;
            this.btnDelModuloRol.Click += new System.EventHandler(this.btnDelModuloRol_Click);
            // 
            // btnAddModuloRol
            // 
            resources.ApplyResources(this.btnAddModuloRol, "btnAddModuloRol");
            this.btnAddModuloRol.Name = "btnAddModuloRol";
            this.btnAddModuloRol.UseVisualStyleBackColor = true;
            this.btnAddModuloRol.Click += new System.EventHandler(this.btnAddModuloRol_Click);
            // 
            // btnDelElmModulo
            // 
            resources.ApplyResources(this.btnDelElmModulo, "btnDelElmModulo");
            this.btnDelElmModulo.Name = "btnDelElmModulo";
            this.btnDelElmModulo.UseVisualStyleBackColor = true;
            this.btnDelElmModulo.Click += new System.EventHandler(this.btnDelElmModulo_Click);
            // 
            // btnAddElmModulo
            // 
            resources.ApplyResources(this.btnAddElmModulo, "btnAddElmModulo");
            this.btnAddElmModulo.Name = "btnAddElmModulo";
            this.btnAddElmModulo.UseVisualStyleBackColor = true;
            this.btnAddElmModulo.Click += new System.EventHandler(this.btnAddElmModulo_Click);
            // 
            // listBoxElementosRestringidos
            // 
            resources.ApplyResources(this.listBoxElementosRestringidos, "listBoxElementosRestringidos");
            this.listBoxElementosRestringidos.FormattingEnabled = true;
            this.listBoxElementosRestringidos.Name = "listBoxElementosRestringidos";
            // 
            // listBoxTodosElementosApp
            // 
            resources.ApplyResources(this.listBoxTodosElementosApp, "listBoxTodosElementosApp");
            this.listBoxTodosElementosApp.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxTodosElementosApp.FormattingEnabled = true;
            this.listBoxTodosElementosApp.Name = "listBoxTodosElementosApp";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbRolesMod
            // 
            resources.ApplyResources(this.cmbRolesMod, "cmbRolesMod");
            this.cmbRolesMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolesMod.FormattingEnabled = true;
            this.cmbRolesMod.Name = "cmbRolesMod";
            this.cmbRolesMod.SelectedIndexChanged += new System.EventHandler(this.cmbRolesMod_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmSeguridad
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.tabSeguridad);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmSeguridad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSeguridad_FormClosing);
            this.Load += new System.EventHandler(this.FrmSeguridad_Load);
            this.tabSeguridad.ResumeLayout(false);
            this.tabRoles.ResumeLayout(false);
            this.tabRoles.PerformLayout();
            this.tabModulos.ResumeLayout(false);
            this.tabModulos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabControl tabSeguridad;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabModulos;
        private System.Windows.Forms.Button btnDelUssRol;
        private System.Windows.Forms.Button btnAddUssRol;
        private System.Windows.Forms.Label lblCmbRoles;
        private System.Windows.Forms.ComboBox cmbRoles;
        private System.Windows.Forms.ListBox listBoxUssRol;
        private System.Windows.Forms.ListBox listBoxTodosUss;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRolesMod;
        private System.Windows.Forms.Button btnDelModuloRol;
        private System.Windows.Forms.Button btnAddModuloRol;
        private System.Windows.Forms.Button btnDelElmModulo;
        private System.Windows.Forms.Button btnAddElmModulo;
        private System.Windows.Forms.ListBox listBoxElementosRestringidos;
        private System.Windows.Forms.ListBox listBoxTodosElementosApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox listBoxElementosRestringidosRol;
        private System.Windows.Forms.Label label7;
    }
}