namespace CapaPresentacion
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCantStock = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.txtPorcUtilidad = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCantidadStock = new System.Windows.Forms.Label();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.lblPorcUtilidad = new System.Windows.Forms.Label();
            this.lblPrecioCosto = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pcbVentana = new System.Windows.Forms.PictureBox();
            this.pcbMinizar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinizar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTitulo.Controls.Add(this.pnlOpciones);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(410, 53);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pcbVentana);
            this.pnlOpciones.Controls.Add(this.pcbMinizar);
            this.pnlOpciones.Controls.Add(this.pcbClose);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(260, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(150, 53);
            this.pnlOpciones.TabIndex = 2;
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.Location = new System.Drawing.Point(100, 3);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(38, 38);
            this.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbClose.TabIndex = 1;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Green;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(295, 314);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 42);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(166, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 42);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.cmbCategoria);
            this.grpDatos.Controls.Add(this.txtCantStock);
            this.grpDatos.Controls.Add(this.txtImpuesto);
            this.grpDatos.Controls.Add(this.txtPorcUtilidad);
            this.grpDatos.Controls.Add(this.txtPrecioCosto);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Controls.Add(this.txtCodigo);
            this.grpDatos.Controls.Add(this.lblCantidadStock);
            this.grpDatos.Controls.Add(this.lblImpuesto);
            this.grpDatos.Controls.Add(this.lblPorcUtilidad);
            this.grpDatos.Controls.Add(this.lblPrecioCosto);
            this.grpDatos.Controls.Add(this.lblCategoria);
            this.grpDatos.Controls.Add(this.lblCodigo);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Location = new System.Drawing.Point(16, 74);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(382, 234);
            this.grpDatos.TabIndex = 10;
            this.grpDatos.TabStop = false;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(149, 82);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(214, 24);
            this.cmbCategoria.TabIndex = 14;
            // 
            // txtCantStock
            // 
            this.txtCantStock.Location = new System.Drawing.Point(149, 193);
            this.txtCantStock.Name = "txtCantStock";
            this.txtCantStock.Size = new System.Drawing.Size(214, 22);
            this.txtCantStock.TabIndex = 13;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(149, 165);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(214, 22);
            this.txtImpuesto.TabIndex = 12;
            // 
            // txtPorcUtilidad
            // 
            this.txtPorcUtilidad.Location = new System.Drawing.Point(149, 137);
            this.txtPorcUtilidad.Name = "txtPorcUtilidad";
            this.txtPorcUtilidad.Size = new System.Drawing.Size(214, 22);
            this.txtPorcUtilidad.TabIndex = 11;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(149, 109);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(214, 22);
            this.txtPrecioCosto.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(149, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(214, 22);
            this.txtCodigo.TabIndex = 7;
            // 
            // lblCantidadStock
            // 
            this.lblCantidadStock.AutoSize = true;
            this.lblCantidadStock.Location = new System.Drawing.Point(38, 199);
            this.lblCantidadStock.Name = "lblCantidadStock";
            this.lblCantidadStock.Size = new System.Drawing.Size(101, 16);
            this.lblCantidadStock.TabIndex = 6;
            this.lblCantidadStock.Text = "Cantidad Stock:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(74, 171);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(65, 16);
            this.lblImpuesto.TabIndex = 5;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // lblPorcUtilidad
            // 
            this.lblPorcUtilidad.AutoSize = true;
            this.lblPorcUtilidad.Location = new System.Drawing.Point(12, 143);
            this.lblPorcUtilidad.Name = "lblPorcUtilidad";
            this.lblPorcUtilidad.Size = new System.Drawing.Size(131, 16);
            this.lblPorcUtilidad.TabIndex = 4;
            this.lblPorcUtilidad.Text = "Porcentenja Utilidad:";
            // 
            // lblPrecioCosto
            // 
            this.lblPrecioCosto.AutoSize = true;
            this.lblPrecioCosto.Location = new System.Drawing.Point(55, 115);
            this.lblPrecioCosto.Name = "lblPrecioCosto";
            this.lblPrecioCosto.Size = new System.Drawing.Size(88, 16);
            this.lblPrecioCosto.TabIndex = 3;
            this.lblPrecioCosto.Text = "Precio-Costo:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(74, 87);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 16);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(89, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // pcbVentana
            // 
            this.pcbVentana.Image = ((System.Drawing.Image)(resources.GetObject("pcbVentana.Image")));
            this.pcbVentana.Location = new System.Drawing.Point(50, 9);
            this.pcbVentana.Name = "pcbVentana";
            this.pcbVentana.Size = new System.Drawing.Size(32, 32);
            this.pcbVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbVentana.TabIndex = 5;
            this.pcbVentana.TabStop = false;
            this.pcbVentana.Click += new System.EventHandler(this.pcbVentana_Click);
            // 
            // pcbMinizar
            // 
            this.pcbMinizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinizar.Image")));
            this.pcbMinizar.Location = new System.Drawing.Point(3, 11);
            this.pcbMinizar.Name = "pcbMinizar";
            this.pcbMinizar.Size = new System.Drawing.Size(30, 30);
            this.pcbMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMinizar.TabIndex = 4;
            this.pcbMinizar.TabStop = false;
            this.pcbMinizar.Click += new System.EventHandler(this.pcbMinizar_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 369);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProducto";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtCantStock;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.TextBox txtPorcUtilidad;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCantidadStock;
        private System.Windows.Forms.Label lblImpuesto;
        private System.Windows.Forms.Label lblPorcUtilidad;
        private System.Windows.Forms.Label lblPrecioCosto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.PictureBox pcbVentana;
        private System.Windows.Forms.PictureBox pcbMinizar;
    }
}