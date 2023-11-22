namespace GesMerCa
{
    partial class FrmAltaUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaUsuarios));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.barraNievelPassword = new System.Windows.Forms.ProgressBar();
            this.lblNivelPassword = new System.Windows.Forms.Label();
            this.lblFortalezaPassword = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPasswordRepetido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLogin = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddImagenUsuario = new System.Windows.Forms.Button();
            this.btnDelImagenUsuario = new System.Windows.Forms.Button();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.controlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.BackColor = System.Drawing.Color.DarkOrange;
            this.controlErrores.SetError(this.lblTitulo, resources.GetString("lblTitulo.Error"));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.controlErrores.SetIconAlignment(this.lblTitulo, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTitulo.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblTitulo, ((int)(resources.GetObject("lblTitulo.IconPadding"))));
            this.lblTitulo.Name = "lblTitulo";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.controlErrores.SetError(this.btnCancelar, resources.GetString("btnCancelar.Error"));
            this.controlErrores.SetIconAlignment(this.btnCancelar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancelar.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.btnCancelar, ((int)(resources.GetObject("btnCancelar.IconPadding"))));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.controlErrores.SetError(this.btnAceptar, resources.GetString("btnAceptar.Error"));
            this.controlErrores.SetIconAlignment(this.btnAceptar, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAceptar.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.btnAceptar, ((int)(resources.GetObject("btnAceptar.IconPadding"))));
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtApellido2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.controlErrores.SetError(this.groupBox1, resources.GetString("groupBox1.Error"));
            this.controlErrores.SetIconAlignment(this.groupBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox1.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.groupBox1, ((int)(resources.GetObject("groupBox1.IconPadding"))));
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.controlErrores.SetError(this.lblEmail, resources.GetString("lblEmail.Error"));
            this.controlErrores.SetIconAlignment(this.lblEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblEmail.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblEmail, ((int)(resources.GetObject("lblEmail.IconPadding"))));
            this.lblEmail.Name = "lblEmail";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.controlErrores.SetError(this.txtEmail, resources.GetString("txtEmail.Error"));
            this.controlErrores.SetIconAlignment(this.txtEmail, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtEmail.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtEmail, ((int)(resources.GetObject("txtEmail.IconPadding"))));
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.comprobarEmail);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.controlErrores.SetError(this.label6, resources.GetString("label6.Error"));
            this.controlErrores.SetIconAlignment(this.label6, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label6.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label6, ((int)(resources.GetObject("label6.IconPadding"))));
            this.label6.Name = "label6";
            // 
            // txtApellido2
            // 
            resources.ApplyResources(this.txtApellido2, "txtApellido2");
            this.controlErrores.SetError(this.txtApellido2, resources.GetString("txtApellido2.Error"));
            this.controlErrores.SetIconAlignment(this.txtApellido2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtApellido2.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtApellido2, ((int)(resources.GetObject("txtApellido2.IconPadding"))));
            this.txtApellido2.Name = "txtApellido2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.controlErrores.SetError(this.label3, resources.GetString("label3.Error"));
            this.controlErrores.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.controlErrores.SetError(this.label2, resources.GetString("label2.Error"));
            this.controlErrores.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // txtApellido1
            // 
            resources.ApplyResources(this.txtApellido1, "txtApellido1");
            this.controlErrores.SetError(this.txtApellido1, resources.GetString("txtApellido1.Error"));
            this.controlErrores.SetIconAlignment(this.txtApellido1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtApellido1.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtApellido1, ((int)(resources.GetObject("txtApellido1.IconPadding"))));
            this.txtApellido1.Name = "txtApellido1";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.controlErrores.SetError(this.txtNombre, resources.GetString("txtNombre.Error"));
            this.controlErrores.SetIconAlignment(this.txtNombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNombre.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtNombre, ((int)(resources.GetObject("txtNombre.IconPadding"))));
            this.txtNombre.Name = "txtNombre";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.barraNievelPassword);
            this.groupBox2.Controls.Add(this.lblNivelPassword);
            this.groupBox2.Controls.Add(this.lblFortalezaPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPasswordRepetido);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNombreLogin);
            this.controlErrores.SetError(this.groupBox2, resources.GetString("groupBox2.Error"));
            this.controlErrores.SetIconAlignment(this.groupBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox2.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.groupBox2, ((int)(resources.GetObject("groupBox2.IconPadding"))));
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // barraNievelPassword
            // 
            resources.ApplyResources(this.barraNievelPassword, "barraNievelPassword");
            this.barraNievelPassword.BackColor = System.Drawing.Color.DarkRed;
            this.controlErrores.SetError(this.barraNievelPassword, resources.GetString("barraNievelPassword.Error"));
            this.barraNievelPassword.ForeColor = System.Drawing.Color.YellowGreen;
            this.controlErrores.SetIconAlignment(this.barraNievelPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("barraNievelPassword.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.barraNievelPassword, ((int)(resources.GetObject("barraNievelPassword.IconPadding"))));
            this.barraNievelPassword.Maximum = 5;
            this.barraNievelPassword.Name = "barraNievelPassword";
            this.barraNievelPassword.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblNivelPassword
            // 
            resources.ApplyResources(this.lblNivelPassword, "lblNivelPassword");
            this.controlErrores.SetError(this.lblNivelPassword, resources.GetString("lblNivelPassword.Error"));
            this.controlErrores.SetIconAlignment(this.lblNivelPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNivelPassword.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblNivelPassword, ((int)(resources.GetObject("lblNivelPassword.IconPadding"))));
            this.lblNivelPassword.Name = "lblNivelPassword";
            // 
            // lblFortalezaPassword
            // 
            resources.ApplyResources(this.lblFortalezaPassword, "lblFortalezaPassword");
            this.controlErrores.SetError(this.lblFortalezaPassword, resources.GetString("lblFortalezaPassword.Error"));
            this.controlErrores.SetIconAlignment(this.lblFortalezaPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblFortalezaPassword.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblFortalezaPassword, ((int)(resources.GetObject("lblFortalezaPassword.IconPadding"))));
            this.lblFortalezaPassword.Name = "lblFortalezaPassword";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.controlErrores.SetError(this.label7, resources.GetString("label7.Error"));
            this.controlErrores.SetIconAlignment(this.label7, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label7.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label7, ((int)(resources.GetObject("label7.IconPadding"))));
            this.label7.Name = "label7";
            // 
            // txtPasswordRepetido
            // 
            resources.ApplyResources(this.txtPasswordRepetido, "txtPasswordRepetido");
            this.controlErrores.SetError(this.txtPasswordRepetido, resources.GetString("txtPasswordRepetido.Error"));
            this.controlErrores.SetIconAlignment(this.txtPasswordRepetido, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPasswordRepetido.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtPasswordRepetido, ((int)(resources.GetObject("txtPasswordRepetido.IconPadding"))));
            this.txtPasswordRepetido.Name = "txtPasswordRepetido";
            this.txtPasswordRepetido.UseSystemPasswordChar = true;
            this.txtPasswordRepetido.Validating += new System.ComponentModel.CancelEventHandler(this.comprobarRepeticionPassword);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.controlErrores.SetError(this.label5, resources.GetString("label5.Error"));
            this.controlErrores.SetIconAlignment(this.label5, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label5.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label5, ((int)(resources.GetObject("label5.IconPadding"))));
            this.label5.Name = "label5";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.controlErrores.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.controlErrores.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.comprobarPassword);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.controlErrores.SetError(this.label4, resources.GetString("label4.Error"));
            this.controlErrores.SetIconAlignment(this.label4, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label4.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.label4, ((int)(resources.GetObject("label4.IconPadding"))));
            this.label4.Name = "label4";
            // 
            // txtNombreLogin
            // 
            resources.ApplyResources(this.txtNombreLogin, "txtNombreLogin");
            this.controlErrores.SetError(this.txtNombreLogin, resources.GetString("txtNombreLogin.Error"));
            this.controlErrores.SetIconAlignment(this.txtNombreLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNombreLogin.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtNombreLogin, ((int)(resources.GetObject("txtNombreLogin.IconPadding"))));
            this.txtNombreLogin.Name = "txtNombreLogin";
            this.txtNombreLogin.Validating += new System.ComponentModel.CancelEventHandler(this.comprobarExistenciaUsuario);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.btnAddImagenUsuario);
            this.groupBox3.Controls.Add(this.btnDelImagenUsuario);
            this.groupBox3.Controls.Add(this.imgUsuario);
            this.controlErrores.SetError(this.groupBox3, resources.GetString("groupBox3.Error"));
            this.controlErrores.SetIconAlignment(this.groupBox3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("groupBox3.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.groupBox3, ((int)(resources.GetObject("groupBox3.IconPadding"))));
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // btnAddImagenUsuario
            // 
            resources.ApplyResources(this.btnAddImagenUsuario, "btnAddImagenUsuario");
            this.btnAddImagenUsuario.BackgroundImage = global::GesMerCa.Properties.Resources.base_picture_32;
            this.controlErrores.SetError(this.btnAddImagenUsuario, resources.GetString("btnAddImagenUsuario.Error"));
            this.controlErrores.SetIconAlignment(this.btnAddImagenUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnAddImagenUsuario.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.btnAddImagenUsuario, ((int)(resources.GetObject("btnAddImagenUsuario.IconPadding"))));
            this.btnAddImagenUsuario.Name = "btnAddImagenUsuario";
            this.btnAddImagenUsuario.UseVisualStyleBackColor = true;
            this.btnAddImagenUsuario.Click += new System.EventHandler(this.btnAddImagenUsuario_Click);
            // 
            // btnDelImagenUsuario
            // 
            resources.ApplyResources(this.btnDelImagenUsuario, "btnDelImagenUsuario");
            this.controlErrores.SetError(this.btnDelImagenUsuario, resources.GetString("btnDelImagenUsuario.Error"));
            this.controlErrores.SetIconAlignment(this.btnDelImagenUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnDelImagenUsuario.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.btnDelImagenUsuario, ((int)(resources.GetObject("btnDelImagenUsuario.IconPadding"))));
            this.btnDelImagenUsuario.Name = "btnDelImagenUsuario";
            this.btnDelImagenUsuario.UseVisualStyleBackColor = true;
            this.btnDelImagenUsuario.Click += new System.EventHandler(this.btnDelImagenUsuario_Click);
            // 
            // imgUsuario
            // 
            resources.ApplyResources(this.imgUsuario, "imgUsuario");
            this.controlErrores.SetError(this.imgUsuario, resources.GetString("imgUsuario.Error"));
            this.controlErrores.SetIconAlignment(this.imgUsuario, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("imgUsuario.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.imgUsuario, ((int)(resources.GetObject("imgUsuario.IconPadding"))));
            this.imgUsuario.Image = global::GesMerCa.Properties.Resources.profile1;
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.TabStop = false;
            // 
            // controlErrores
            // 
            this.controlErrores.ContainerControl = this;
            resources.ApplyResources(this.controlErrores, "controlErrores");
            // 
            // FrmAltaUsuarios
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaUsuarios";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPasswordRepetido;
        private System.Windows.Forms.Label lblFortalezaPassword;
        private System.Windows.Forms.Label lblNivelPassword;
        private System.Windows.Forms.ProgressBar barraNievelPassword;
        private System.Windows.Forms.ErrorProvider controlErrores;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.Button btnDelImagenUsuario;
        private System.Windows.Forms.Button btnAddImagenUsuario;
    }
}