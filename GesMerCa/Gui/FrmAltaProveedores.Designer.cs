namespace GesMerCa
{
    partial class FrmAltaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaProveedores));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpBoxDatosFiscales = new System.Windows.Forms.GroupBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbCifNif = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCifNif = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.controlErrores = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBoxDatosFiscales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            // grpBoxDatosFiscales
            // 
            resources.ApplyResources(this.grpBoxDatosFiscales, "grpBoxDatosFiscales");
            this.grpBoxDatosFiscales.Controls.Add(this.lblObservaciones);
            this.grpBoxDatosFiscales.Controls.Add(this.txtObservaciones);
            this.grpBoxDatosFiscales.Controls.Add(this.lblWeb);
            this.grpBoxDatosFiscales.Controls.Add(this.txtWeb);
            this.grpBoxDatosFiscales.Controls.Add(this.lblEmail);
            this.grpBoxDatosFiscales.Controls.Add(this.txtEmail);
            this.grpBoxDatosFiscales.Controls.Add(this.lblTelefono);
            this.grpBoxDatosFiscales.Controls.Add(this.txtTelefono);
            this.grpBoxDatosFiscales.Controls.Add(this.cmbCifNif);
            this.grpBoxDatosFiscales.Controls.Add(this.lblLocalidad);
            this.grpBoxDatosFiscales.Controls.Add(this.txtLocalidad);
            this.grpBoxDatosFiscales.Controls.Add(this.lblDireccion);
            this.grpBoxDatosFiscales.Controls.Add(this.txtDireccion);
            this.grpBoxDatosFiscales.Controls.Add(this.lblNombre);
            this.grpBoxDatosFiscales.Controls.Add(this.txtCifNif);
            this.grpBoxDatosFiscales.Controls.Add(this.txtNombre);
            this.controlErrores.SetError(this.grpBoxDatosFiscales, resources.GetString("grpBoxDatosFiscales.Error"));
            this.controlErrores.SetIconAlignment(this.grpBoxDatosFiscales, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("grpBoxDatosFiscales.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.grpBoxDatosFiscales, ((int)(resources.GetObject("grpBoxDatosFiscales.IconPadding"))));
            this.grpBoxDatosFiscales.Name = "grpBoxDatosFiscales";
            this.grpBoxDatosFiscales.TabStop = false;
            // 
            // lblObservaciones
            // 
            resources.ApplyResources(this.lblObservaciones, "lblObservaciones");
            this.controlErrores.SetError(this.lblObservaciones, resources.GetString("lblObservaciones.Error"));
            this.controlErrores.SetIconAlignment(this.lblObservaciones, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblObservaciones.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblObservaciones, ((int)(resources.GetObject("lblObservaciones.IconPadding"))));
            this.lblObservaciones.Name = "lblObservaciones";
            // 
            // txtObservaciones
            // 
            resources.ApplyResources(this.txtObservaciones, "txtObservaciones");
            this.controlErrores.SetError(this.txtObservaciones, resources.GetString("txtObservaciones.Error"));
            this.controlErrores.SetIconAlignment(this.txtObservaciones, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtObservaciones.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtObservaciones, ((int)(resources.GetObject("txtObservaciones.IconPadding"))));
            this.txtObservaciones.Name = "txtObservaciones";
            // 
            // lblWeb
            // 
            resources.ApplyResources(this.lblWeb, "lblWeb");
            this.controlErrores.SetError(this.lblWeb, resources.GetString("lblWeb.Error"));
            this.controlErrores.SetIconAlignment(this.lblWeb, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblWeb.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblWeb, ((int)(resources.GetObject("lblWeb.IconPadding"))));
            this.lblWeb.Name = "lblWeb";
            // 
            // txtWeb
            // 
            resources.ApplyResources(this.txtWeb, "txtWeb");
            this.controlErrores.SetError(this.txtWeb, resources.GetString("txtWeb.Error"));
            this.controlErrores.SetIconAlignment(this.txtWeb, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtWeb.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtWeb, ((int)(resources.GetObject("txtWeb.IconPadding"))));
            this.txtWeb.Name = "txtWeb";
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
            // 
            // lblTelefono
            // 
            resources.ApplyResources(this.lblTelefono, "lblTelefono");
            this.controlErrores.SetError(this.lblTelefono, resources.GetString("lblTelefono.Error"));
            this.controlErrores.SetIconAlignment(this.lblTelefono, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblTelefono.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblTelefono, ((int)(resources.GetObject("lblTelefono.IconPadding"))));
            this.lblTelefono.Name = "lblTelefono";
            // 
            // txtTelefono
            // 
            resources.ApplyResources(this.txtTelefono, "txtTelefono");
            this.controlErrores.SetError(this.txtTelefono, resources.GetString("txtTelefono.Error"));
            this.controlErrores.SetIconAlignment(this.txtTelefono, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtTelefono.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtTelefono, ((int)(resources.GetObject("txtTelefono.IconPadding"))));
            this.txtTelefono.Name = "txtTelefono";
            // 
            // cmbCifNif
            // 
            resources.ApplyResources(this.cmbCifNif, "cmbCifNif");
            this.controlErrores.SetError(this.cmbCifNif, resources.GetString("cmbCifNif.Error"));
            this.cmbCifNif.FormattingEnabled = true;
            this.controlErrores.SetIconAlignment(this.cmbCifNif, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cmbCifNif.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.cmbCifNif, ((int)(resources.GetObject("cmbCifNif.IconPadding"))));
            this.cmbCifNif.Items.AddRange(new object[] {
            resources.GetString("cmbCifNif.Items"),
            resources.GetString("cmbCifNif.Items1")});
            this.cmbCifNif.Name = "cmbCifNif";
            // 
            // lblLocalidad
            // 
            resources.ApplyResources(this.lblLocalidad, "lblLocalidad");
            this.controlErrores.SetError(this.lblLocalidad, resources.GetString("lblLocalidad.Error"));
            this.controlErrores.SetIconAlignment(this.lblLocalidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblLocalidad.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblLocalidad, ((int)(resources.GetObject("lblLocalidad.IconPadding"))));
            this.lblLocalidad.Name = "lblLocalidad";
            // 
            // txtLocalidad
            // 
            resources.ApplyResources(this.txtLocalidad, "txtLocalidad");
            this.controlErrores.SetError(this.txtLocalidad, resources.GetString("txtLocalidad.Error"));
            this.controlErrores.SetIconAlignment(this.txtLocalidad, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtLocalidad.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtLocalidad, ((int)(resources.GetObject("txtLocalidad.IconPadding"))));
            this.txtLocalidad.Name = "txtLocalidad";
            // 
            // lblDireccion
            // 
            resources.ApplyResources(this.lblDireccion, "lblDireccion");
            this.controlErrores.SetError(this.lblDireccion, resources.GetString("lblDireccion.Error"));
            this.controlErrores.SetIconAlignment(this.lblDireccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblDireccion.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblDireccion, ((int)(resources.GetObject("lblDireccion.IconPadding"))));
            this.lblDireccion.Name = "lblDireccion";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.controlErrores.SetError(this.txtDireccion, resources.GetString("txtDireccion.Error"));
            this.controlErrores.SetIconAlignment(this.txtDireccion, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtDireccion.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtDireccion, ((int)(resources.GetObject("txtDireccion.IconPadding"))));
            this.txtDireccion.Name = "txtDireccion";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.controlErrores.SetError(this.lblNombre, resources.GetString("lblNombre.Error"));
            this.controlErrores.SetIconAlignment(this.lblNombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("lblNombre.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.lblNombre, ((int)(resources.GetObject("lblNombre.IconPadding"))));
            this.lblNombre.Name = "lblNombre";
            // 
            // txtCifNif
            // 
            resources.ApplyResources(this.txtCifNif, "txtCifNif");
            this.controlErrores.SetError(this.txtCifNif, resources.GetString("txtCifNif.Error"));
            this.controlErrores.SetIconAlignment(this.txtCifNif, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtCifNif.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtCifNif, ((int)(resources.GetObject("txtCifNif.IconPadding"))));
            this.txtCifNif.Name = "txtCifNif";
            this.txtCifNif.Enter += new System.EventHandler(this.txtCifNif_Enter);
            this.txtCifNif.Leave += new System.EventHandler(this.txtCifNif_Leave);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.controlErrores.SetError(this.txtNombre, resources.GetString("txtNombre.Error"));
            this.controlErrores.SetIconAlignment(this.txtNombre, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtNombre.IconAlignment"))));
            this.controlErrores.SetIconPadding(this.txtNombre, ((int)(resources.GetObject("txtNombre.IconPadding"))));
            this.txtNombre.Name = "txtNombre";
            // 
            // controlErrores
            // 
            this.controlErrores.ContainerControl = this;
            resources.ApplyResources(this.controlErrores, "controlErrores");
            // 
            // FrmAltaProveedores
            // 
            this.AcceptButton = this.btnAceptar;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.Controls.Add(this.grpBoxDatosFiscales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaProveedores";
            this.TopMost = true;
            this.grpBoxDatosFiscales.ResumeLayout(false);
            this.grpBoxDatosFiscales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpBoxDatosFiscales;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCifNif;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.ErrorProvider controlErrores;
        private System.Windows.Forms.ComboBox cmbCifNif;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
    }
}