namespace GesMerCa
{
    partial class FrmRecepcionMercancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecepcionMercancia));
            this.barraOpcionesRecepcionMercancia = new System.Windows.Forms.ToolStrip();
            this.barraAltaRecepcionMercancia = new System.Windows.Forms.ToolStripButton();
            this.barraOpcionesRecepcionMercancia.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraOpcionesRecepcionMercancia
            // 
            resources.ApplyResources(this.barraOpcionesRecepcionMercancia, "barraOpcionesRecepcionMercancia");
            this.barraOpcionesRecepcionMercancia.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraAltaRecepcionMercancia});
            this.barraOpcionesRecepcionMercancia.Name = "barraOpcionesRecepcionMercancia";
            this.barraOpcionesRecepcionMercancia.Stretch = true;
            // 
            // barraAltaRecepcionMercancia
            // 
            resources.ApplyResources(this.barraAltaRecepcionMercancia, "barraAltaRecepcionMercancia");
            this.barraAltaRecepcionMercancia.Image = global::GesMerCa.Properties.Resources.AddNodefromFile_354;
            this.barraAltaRecepcionMercancia.Name = "barraAltaRecepcionMercancia";
            // 
            // FrmRecepcionMercancia
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraOpcionesRecepcionMercancia);
            this.Name = "FrmRecepcionMercancia";
            this.barraOpcionesRecepcionMercancia.ResumeLayout(false);
            this.barraOpcionesRecepcionMercancia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraOpcionesRecepcionMercancia;
        private System.Windows.Forms.ToolStripButton barraAltaRecepcionMercancia;
    }
}