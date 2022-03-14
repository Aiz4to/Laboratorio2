namespace CapaPresentacion
{
    partial class frmListaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProductos));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lstVista = new System.Windows.Forms.ListView();
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioCosto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPorcutilidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImpuesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colcantStack = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pcbVentana = new System.Windows.Forms.PictureBox();
            this.pcbMinizar = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
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
            this.pnlTitulo.Size = new System.Drawing.Size(1042, 53);
            this.pnlTitulo.TabIndex = 1;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pcbVentana);
            this.pnlOpciones.Controls.Add(this.pcbMinizar);
            this.pnlOpciones.Controls.Add(this.pcbClose);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(887, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(155, 53);
            this.pnlOpciones.TabIndex = 2;
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.Location = new System.Drawing.Point(105, 3);
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
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Consolas", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(918, 64);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 76);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lstVista
            // 
            this.lstVista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigo,
            this.colNombre,
            this.colCategoria,
            this.colPrecioCosto,
            this.colPorcutilidad,
            this.colImpuesto,
            this.colcantStack});
            this.lstVista.FullRowSelect = true;
            this.lstVista.GridLines = true;
            this.lstVista.HideSelection = false;
            this.lstVista.Location = new System.Drawing.Point(12, 146);
            this.lstVista.MultiSelect = false;
            this.lstVista.Name = "lstVista";
            this.lstVista.Size = new System.Drawing.Size(1018, 326);
            this.lstVista.TabIndex = 4;
            this.lstVista.UseCompatibleStateImageBehavior = false;
            this.lstVista.View = System.Windows.Forms.View.Details;
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 100;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 100;
            // 
            // colCategoria
            // 
            this.colCategoria.Text = "Categoría";
            this.colCategoria.Width = 100;
            // 
            // colPrecioCosto
            // 
            this.colPrecioCosto.Text = "Precio-Costo";
            this.colPrecioCosto.Width = 100;
            // 
            // colPorcutilidad
            // 
            this.colPorcutilidad.Text = "Porcentaje Utilidad";
            this.colPorcutilidad.Width = 150;
            // 
            // colImpuesto
            // 
            this.colImpuesto.Text = "Impuesto";
            this.colImpuesto.Width = 100;
            // 
            // colcantStack
            // 
            this.colcantStack.Text = "Cantidad Stack";
            this.colcantStack.Width = 150;
            // 
            // pcbVentana
            // 
            this.pcbVentana.Image = ((System.Drawing.Image)(resources.GetObject("pcbVentana.Image")));
            this.pcbVentana.Location = new System.Drawing.Point(60, 10);
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
            this.pcbMinizar.Location = new System.Drawing.Point(13, 12);
            this.pcbMinizar.Name = "pcbMinizar";
            this.pcbMinizar.Size = new System.Drawing.Size(30, 30);
            this.pcbMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMinizar.TabIndex = 4;
            this.pcbMinizar.TabStop = false;
            this.pcbMinizar.Click += new System.EventHandler(this.pcbMinizar_Click);
            // 
            // frmListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 484);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstVista);
            this.Controls.Add(this.pnlTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaProductos";
            this.Load += new System.EventHandler(this.frmListaProductos_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListView lstVista;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCategoria;
        private System.Windows.Forms.ColumnHeader colPrecioCosto;
        private System.Windows.Forms.ColumnHeader colPorcutilidad;
        private System.Windows.Forms.ColumnHeader colImpuesto;
        private System.Windows.Forms.ColumnHeader colcantStack;
        private System.Windows.Forms.PictureBox pcbVentana;
        private System.Windows.Forms.PictureBox pcbMinizar;
    }
}