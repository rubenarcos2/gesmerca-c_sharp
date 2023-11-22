namespace GesMerCa
{
    partial class FrmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.barraOpcionesProveedores = new System.Windows.Forms.ToolStrip();
            this.barraAltaProveedor = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.barraOpcionesProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            resources.ApplyResources(this.toolStripContainer1, "toolStripContainer1");
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.BottomToolStripPanel, "toolStripContainer1.BottomToolStripPanel");
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.ContentPanel, "toolStripContainer1.ContentPanel");
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.LeftToolStripPanel, "toolStripContainer1.LeftToolStripPanel");
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.RightToolStripPanel, "toolStripContainer1.RightToolStripPanel");
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            resources.ApplyResources(this.toolStripContainer1.TopToolStripPanel, "toolStripContainer1.TopToolStripPanel");
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.barraOpcionesProveedores);
            // 
            // barraOpcionesProveedores
            // 
            resources.ApplyResources(this.barraOpcionesProveedores, "barraOpcionesProveedores");
            this.barraOpcionesProveedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraAltaProveedor});
            this.barraOpcionesProveedores.Name = "barraOpcionesProveedores";
            this.barraOpcionesProveedores.Stretch = true;
            // 
            // barraAltaProveedor
            // 
            resources.ApplyResources(this.barraAltaProveedor, "barraAltaProveedor");
            this.barraAltaProveedor.Image = global::GesMerCa.Properties.Resources.AddNodefromFile_354;
            this.barraAltaProveedor.Name = "barraAltaProveedor";
            this.barraAltaProveedor.Click += new System.EventHandler(this.btnAltaProveedor_Click);
            // 
            // FrmProveedores
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FrmProveedores";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.barraOpcionesProveedores.ResumeLayout(false);
            this.barraOpcionesProveedores.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraOpcionesProveedores;
        private System.Windows.Forms.ToolStripButton barraAltaProveedor;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}