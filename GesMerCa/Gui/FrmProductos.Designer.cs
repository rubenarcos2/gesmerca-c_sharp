namespace GesMerCa
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.barraOpcionesProductos = new System.Windows.Forms.ToolStrip();
            this.barraAltaProducto = new System.Windows.Forms.ToolStripButton();
            this.barraOpcionesProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraOpcionesProductos
            // 
            resources.ApplyResources(this.barraOpcionesProductos, "barraOpcionesProductos");
            this.barraOpcionesProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraAltaProducto});
            this.barraOpcionesProductos.Name = "barraOpcionesProductos";
            this.barraOpcionesProductos.Stretch = true;
            // 
            // barraAltaProducto
            // 
            resources.ApplyResources(this.barraAltaProducto, "barraAltaProducto");
            this.barraAltaProducto.Image = global::GesMerCa.Properties.Resources.AddNodefromFile_354;
            this.barraAltaProducto.Name = "barraAltaProducto";
            // 
            // FrmProductos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraOpcionesProductos);
            this.Name = "FrmProductos";
            this.barraOpcionesProductos.ResumeLayout(false);
            this.barraOpcionesProductos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraOpcionesProductos;
        private System.Windows.Forms.ToolStripButton barraAltaProducto;
    }
}