namespace GesMerCa
{
    partial class frmAcercaDe
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcercaDe));
            this.textBoxDescription = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.logoSJPictureBox = new System.Windows.Forms.PictureBox();
            this.fondoPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionProductName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoSJPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.BackColor = System.Drawing.Color.Magenta;
            this.textBoxDescription.Name = "textBoxDescription";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.MouseLeave += new System.EventHandler(this.ratonFuera);
            this.btnAceptar.MouseHover += new System.EventHandler(this.ratonEncima);
            // 
            // logoSJPictureBox
            // 
            resources.ApplyResources(this.logoSJPictureBox, "logoSJPictureBox");
            this.logoSJPictureBox.BackColor = System.Drawing.Color.Magenta;
            this.logoSJPictureBox.BackgroundImage = global::GesMerCa.Properties.Resources.logoSanJose;
            this.logoSJPictureBox.Name = "logoSJPictureBox";
            this.logoSJPictureBox.TabStop = false;
            // 
            // fondoPictureBox
            // 
            resources.ApplyResources(this.fondoPictureBox, "fondoPictureBox");
            this.fondoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.fondoPictureBox.Image = global::GesMerCa.Properties.Resources.acercaDe;
            this.fondoPictureBox.Name = "fondoPictureBox";
            this.fondoPictureBox.TabStop = false;
            // 
            // descriptionProductName
            // 
            resources.ApplyResources(this.descriptionProductName, "descriptionProductName");
            this.descriptionProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.descriptionProductName.Name = "descriptionProductName";
            this.descriptionProductName.UseWaitCursor = true;
            // 
            // labelProductName
            // 
            resources.ApplyResources(this.labelProductName, "labelProductName");
            this.labelProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.UseWaitCursor = true;
            // 
            // labelCompanyName
            // 
            resources.ApplyResources(this.labelCompanyName, "labelCompanyName");
            this.labelCompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.UseWaitCursor = true;
            // 
            // labelCopyright
            // 
            resources.ApplyResources(this.labelCopyright, "labelCopyright");
            this.labelCopyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.UseWaitCursor = true;
            // 
            // labelVersion
            // 
            resources.ApplyResources(this.labelVersion, "labelVersion");
            this.labelVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.labelVersion.Name = "labelVersion";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Magenta;
            this.label1.Name = "label1";
            // 
            // frmAcercaDe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.logoSJPictureBox);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.descriptionProductName);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fondoPictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcercaDe";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            ((System.ComponentModel.ISupportInitialize)(this.logoSJPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fondoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textBoxDescription;
        private System.Windows.Forms.PictureBox logoSJPictureBox;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox fondoPictureBox;
        private System.Windows.Forms.Label descriptionProductName;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label label1;
    }
}
