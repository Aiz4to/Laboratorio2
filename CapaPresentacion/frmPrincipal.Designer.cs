namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.pnlOpciones = new System.Windows.Forms.Panel();
            this.pcbMinizar = new System.Windows.Forms.PictureBox();
            this.pcbClose = new System.Windows.Forms.PictureBox();
            this.pcbShow = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pcbVentana = new System.Windows.Forms.PictureBox();
            this.pnlTitulo.SuspendLayout();
            this.pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShow)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTitulo.Controls.Add(this.pnlOpciones);
            this.pnlTitulo.Controls.Add(this.pcbShow);
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(226, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(403, 53);
            this.pnlTitulo.TabIndex = 2;
            // 
            // pnlOpciones
            // 
            this.pnlOpciones.Controls.Add(this.pcbVentana);
            this.pnlOpciones.Controls.Add(this.pcbMinizar);
            this.pnlOpciones.Controls.Add(this.pcbClose);
            this.pnlOpciones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOpciones.Location = new System.Drawing.Point(255, 0);
            this.pnlOpciones.Name = "pnlOpciones";
            this.pnlOpciones.Size = new System.Drawing.Size(148, 53);
            this.pnlOpciones.TabIndex = 2;
            // 
            // pcbMinizar
            // 
            this.pcbMinizar.Image = ((System.Drawing.Image)(resources.GetObject("pcbMinizar.Image")));
            this.pcbMinizar.Location = new System.Drawing.Point(3, 11);
            this.pcbMinizar.Name = "pcbMinizar";
            this.pcbMinizar.Size = new System.Drawing.Size(30, 30);
            this.pcbMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbMinizar.TabIndex = 2;
            this.pcbMinizar.TabStop = false;
            this.pcbMinizar.Click += new System.EventHandler(this.pcbMinimizar);
            // 
            // pcbClose
            // 
            this.pcbClose.Image = ((System.Drawing.Image)(resources.GetObject("pcbClose.Image")));
            this.pcbClose.Location = new System.Drawing.Point(98, 3);
            this.pcbClose.Name = "pcbClose";
            this.pcbClose.Size = new System.Drawing.Size(38, 38);
            this.pcbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbClose.TabIndex = 1;
            this.pcbClose.TabStop = false;
            this.pcbClose.Click += new System.EventHandler(this.pcbClose_Click);
            // 
            // pcbShow
            // 
            this.pcbShow.Image = ((System.Drawing.Image)(resources.GetObject("pcbShow.Image")));
            this.pcbShow.Location = new System.Drawing.Point(6, 3);
            this.pcbShow.Name = "pcbShow";
            this.pcbShow.Size = new System.Drawing.Size(38, 38);
            this.pcbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbShow.TabIndex = 2;
            this.pcbShow.TabStop = false;
            this.pcbShow.Click += new System.EventHandler(this.pcbShow_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(52, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(76, 23);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.pnlMenu.Controls.Add(this.btnProductos);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(226, 450);
            this.pnlMenu.TabIndex = 3;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.DimGray;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Location = new System.Drawing.Point(33, 12);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(161, 49);
            this.btnProductos.TabIndex = 0;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pcbVentana
            // 
            this.pcbVentana.Image = ((System.Drawing.Image)(resources.GetObject("pcbVentana.Image")));
            this.pcbVentana.Location = new System.Drawing.Point(50, 9);
            this.pcbVentana.Name = "pcbVentana";
            this.pcbVentana.Size = new System.Drawing.Size(32, 32);
            this.pcbVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbVentana.TabIndex = 3;
            this.pcbVentana.TabStop = false;
            this.pcbVentana.Click += new System.EventHandler(this.pcbVentana_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.pnlOpciones.ResumeLayout(false);
            this.pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbShow)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbVentana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.PictureBox pcbClose;
        private System.Windows.Forms.PictureBox pcbShow;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.PictureBox pcbMinizar;
        private System.Windows.Forms.PictureBox pcbVentana;
    }
}