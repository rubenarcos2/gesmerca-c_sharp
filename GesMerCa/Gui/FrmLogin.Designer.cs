namespace GesMerCa
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpUssPass = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUss = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.controlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.barraNivelDeteccion = new System.Windows.Forms.ProgressBar();
            this.lblNivelDeteccion = new System.Windows.Forms.Label();
            this.lblNivelPrecision = new System.Windows.Forms.Label();
            this.barraNivelPrecision = new System.Windows.Forms.ProgressBar();
            this.grpUssPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
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
            // grpUssPass
            // 
            resources.ApplyResources(this.grpUssPass, "grpUssPass");
            this.grpUssPass.Controls.Add(this.lblPass);
            this.grpUssPass.Controls.Add(this.lblUss);
            this.grpUssPass.Controls.Add(this.txtPassword);
            this.grpUssPass.Controls.Add(this.txtNombre);
            this.controlErrores.SetError(this.grpUssPass, resources.GetString("grpUssPass.Error"));
            this.controlErrores.SetIconAlignment(this.grpUssPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grpUssPass.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.grpUssPass, ((int)(resources.GetObject("grpUssPass.IconPadding"))));
            this.grpUssPass.Name = "grpUssPass";
            this.grpUssPass.TabStop = false;
            // 
            // lblPass
            // 
            resources.ApplyResources(this.lblPass, "lblPass");
            this.controlErrores.SetError(this.lblPass, resources.GetString("lblPass.Error"));
            this.controlErrores.SetIconAlignment(this.lblPass, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblPass.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblPass, ((int)(resources.GetObject("lblPass.IconPadding"))));
            this.lblPass.Name = "lblPass";
            // 
            // lblUss
            // 
            resources.ApplyResources(this.lblUss, "lblUss");
            this.controlErrores.SetError(this.lblUss, resources.GetString("lblUss.Error"));
            this.controlErrores.SetIconAlignment(this.lblUss, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblUss.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblUss, ((int)(resources.GetObject("lblUss.IconPadding"))));
            this.lblUss.Name = "lblUss";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.controlErrores.SetError(this.txtPassword, resources.GetString("txtPassword.Error"));
            this.controlErrores.SetIconAlignment(this.txtPassword, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtPassword.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtPassword, ((int)(resources.GetObject("txtPassword.IconPadding"))));
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.controlErrores.SetError(this.txtNombre, resources.GetString("txtNombre.Error"));
            this.controlErrores.SetIconAlignment(this.txtNombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNombre.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtNombre, ((int)(resources.GetObject("txtNombre.IconPadding"))));
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtLogin_TextChanged);
            this.txtNombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyUp);
            // 
            // controlErrores
            // 
            this.controlErrores.ContainerControl = this;
            resources.ApplyResources(this.controlErrores, "controlErrores");
            // 
            // imgLogin
            // 
            resources.ApplyResources(this.imgLogin, "imgLogin");
            this.imgLogin.BackColor = System.Drawing.Color.Transparent;
            this.controlErrores.SetError(this.imgLogin, resources.GetString("imgLogin.Error"));
            this.controlErrores.SetIconAlignment(this.imgLogin, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("imgLogin.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.imgLogin, ((int)(resources.GetObject("imgLogin.IconPadding"))));
            this.imgLogin.Image = global::GesMerCa.Properties.Resources.key;
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.TabStop = false;
            // 
            // imageBoxFrameGrabber
            // 
            resources.ApplyResources(this.imageBoxFrameGrabber, "imageBoxFrameGrabber");
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlErrores.SetError(this.imageBoxFrameGrabber, resources.GetString("imageBoxFrameGrabber.Error"));
            this.controlErrores.SetIconAlignment(this.imageBoxFrameGrabber, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("imageBoxFrameGrabber.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.imageBoxFrameGrabber, ((int)(resources.GetObject("imageBoxFrameGrabber.IconPadding"))));
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // barraNivelDeteccion
            // 
            resources.ApplyResources(this.barraNivelDeteccion, "barraNivelDeteccion");
            this.barraNivelDeteccion.BackColor = System.Drawing.Color.Black;
            this.controlErrores.SetError(this.barraNivelDeteccion, resources.GetString("barraNivelDeteccion.Error"));
            this.barraNivelDeteccion.ForeColor = System.Drawing.Color.GreenYellow;
            this.controlErrores.SetIconAlignment(this.barraNivelDeteccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("barraNivelDeteccion.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.barraNivelDeteccion, ((int)(resources.GetObject("barraNivelDeteccion.IconPadding"))));
            this.barraNivelDeteccion.Maximum = 50;
            this.barraNivelDeteccion.Name = "barraNivelDeteccion";
            this.barraNivelDeteccion.Step = 1;
            this.barraNivelDeteccion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblNivelDeteccion
            // 
            resources.ApplyResources(this.lblNivelDeteccion, "lblNivelDeteccion");
            this.lblNivelDeteccion.BackColor = System.Drawing.Color.Transparent;
            this.controlErrores.SetError(this.lblNivelDeteccion, resources.GetString("lblNivelDeteccion.Error"));
            this.lblNivelDeteccion.ForeColor = System.Drawing.Color.Green;
            this.controlErrores.SetIconAlignment(this.lblNivelDeteccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNivelDeteccion.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblNivelDeteccion, ((int)(resources.GetObject("lblNivelDeteccion.IconPadding"))));
            this.lblNivelDeteccion.Name = "lblNivelDeteccion";
            // 
            // lblNivelPrecision
            // 
            resources.ApplyResources(this.lblNivelPrecision, "lblNivelPrecision");
            this.lblNivelPrecision.BackColor = System.Drawing.Color.Transparent;
            this.controlErrores.SetError(this.lblNivelPrecision, resources.GetString("lblNivelPrecision.Error"));
            this.lblNivelPrecision.ForeColor = System.Drawing.Color.Green;
            this.controlErrores.SetIconAlignment(this.lblNivelPrecision, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNivelPrecision.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblNivelPrecision, ((int)(resources.GetObject("lblNivelPrecision.IconPadding"))));
            this.lblNivelPrecision.Name = "lblNivelPrecision";
            // 
            // barraNivelPrecision
            // 
            resources.ApplyResources(this.barraNivelPrecision, "barraNivelPrecision");
            this.barraNivelPrecision.BackColor = System.Drawing.Color.Black;
            this.controlErrores.SetError(this.barraNivelPrecision, resources.GetString("barraNivelPrecision.Error"));
            this.barraNivelPrecision.ForeColor = System.Drawing.Color.GreenYellow;
            this.controlErrores.SetIconAlignment(this.barraNivelPrecision, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("barraNivelPrecision.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.barraNivelPrecision, ((int)(resources.GetObject("barraNivelPrecision.IconPadding"))));
            this.barraNivelPrecision.Maximum = 250;
            this.barraNivelPrecision.Name = "barraNivelPrecision";
            this.barraNivelPrecision.Step = 5;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.lblNivelPrecision);
            this.Controls.Add(this.barraNivelPrecision);
            this.Controls.Add(this.lblNivelDeteccion);
            this.Controls.Add(this.barraNivelDeteccion);
            this.Controls.Add(this.imgLogin);
            this.Controls.Add(this.grpUssPass);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.grpUssPass.ResumeLayout(false);
            this.grpUssPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpUssPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUss;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ErrorProvider controlErrores;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.ProgressBar barraNivelDeteccion;
        private System.Windows.Forms.Label lblNivelDeteccion;
        private System.Windows.Forms.Label lblNivelPrecision;
        private System.Windows.Forms.ProgressBar barraNivelPrecision;
    }
}