using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public IServiceProvider ServiceProvider { get; }

        public frmPrincipal(IServiceProvider _serviceProvider)
        {
            InitializeComponent();
            ServiceProvider = _serviceProvider;
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcbShow_Click(object sender, EventArgs e)
        {
            //Ocultar panel del menú cuando está desplegado
            if (pnlMenu.Width == 170)
            {
                //Cambia ancho a 0
                pnlMenu.Width = 0;
            }
            else
            {
                //Si es 0, está oculto, me lo pasa a 170, lo muestra
                pnlMenu.Width = 170;
            }
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var form = ServiceProvider.GetRequiredService<frmListaProductos>();
            form.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "UTN App";
        }

        private void pcbMinimizar(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbVentana_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
