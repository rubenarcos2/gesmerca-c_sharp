namespace GesMerCa
{
    partial class FrmBloqueoAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBloqueoAcceso));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTiempoDisponible = new System.Windows.Forms.Label();
            this.timerBloqueoPantalla = new System.Windows.Forms.Timer(this.components);
            this.lblCodigoDesbloqueo = new System.Windows.Forms.Label();
            this.txtCodigoDesbloqueo = new System.Windows.Forms.TextBox();
            this.timerIconoDesbloqueo = new System.Windows.Forms.Timer(this.components);
            this.btnDesbloqueo = new System.Windows.Forms.Button();
            this.iconoBloqueo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconoBloqueo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblTiempoDisponible
            // 
            resources.ApplyResources(this.lblTiempoDisponible, "lblTiempoDisponible");
            this.lblTiempoDisponible.Name = "lblTiempoDisponible";
            // 
            // timerBloqueoPantalla
            // 
            this.timerBloqueoPantalla.Interval = 1;
            this.timerBloqueoPantalla.Tick += new System.EventHandler(this.timerBloqueoPantalla_Tick);
            // 
            // lblCodigoDesbloqueo
            // 
            resources.ApplyResources(this.lblCodigoDesbloqueo, "lblCodigoDesbloqueo");
            this.lblCodigoDesbloqueo.Name = "lblCodigoDesbloqueo";
            this.lblCodigoDesbloqueo.Click += new System.EventHandler(this.iconoBloqueo_Click);
            // 
            // txtCodigoDesbloqueo
            // 
            resources.ApplyResources(this.txtCodigoDesbloqueo, "txtCodigoDesbloqueo");
            this.txtCodigoDesbloqueo.Name = "txtCodigoDesbloqueo";
            // 
            // timerIconoDesbloqueo
            // 
            this.timerIconoDesbloqueo.Enabled = true;
            this.timerIconoDesbloqueo.Interval = 5000;
            this.timerIconoDesbloqueo.Tick += new System.EventHandler(this.timerIconoDesbloqueo_Tick);
            // 
            // btnDesbloqueo
            // 
            resources.ApplyResources(this.btnDesbloqueo, "btnDesbloqueo");
            this.btnDesbloqueo.BackgroundImage = global::GesMerCa.Properties.Resources.unlocked;
            this.btnDesbloqueo.FlatAppearance.BorderSize = 0;
            this.btnDesbloqueo.Name = "btnDesbloqueo";
            this.btnDesbloqueo.UseVisualStyleBackColor = true;
            this.btnDesbloqueo.Click += new System.EventHandler(this.btnDesbloqueo_Click);
            // 
            // iconoBloqueo
            // 
            resources.ApplyResources(this.iconoBloqueo, "iconoBloqueo");
            this.iconoBloqueo.Image = global::GesMerCa.Properties.Resources.roadblock;
            this.iconoBloqueo.Name = "iconoBloqueo";
            this.iconoBloqueo.TabStop = false;
            this.iconoBloqueo.Click += new System.EventHandler(this.iconoBloqueo_Click);
            // 
            // FrmBloqueoAcceso
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CausesValidation = false;
            this.ControlBox = false;
            this.Controls.Add(this.btnDesbloqueo);
            this.Controls.Add(this.txtCodigoDesbloqueo);
            this.Controls.Add(this.lblCodigoDesbloqueo);
            this.Controls.Add(this.lblTiempoDisponible);
            this.Controls.Add(this.iconoBloqueo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBloqueoAcceso";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.cerrarFormulario);
            this.Shown += new System.EventHandler(this.FrmBloqueoAcceso_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.iconoBloqueo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox iconoBloqueo;
        private System.Windows.Forms.Label lblTiempoDisponible;
        private System.Windows.Forms.Timer timerBloqueoPantalla;
        private System.Windows.Forms.Label lblCodigoDesbloqueo;
        private System.Windows.Forms.TextBox txtCodigoDesbloqueo;
        private System.Windows.Forms.Timer timerIconoDesbloqueo;
        private System.Windows.Forms.Button btnDesbloqueo;
    }
}