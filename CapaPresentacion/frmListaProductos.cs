using Entidades;
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
using Utilidades.Interfaces;

namespace CapaPresentacion
{
    public partial class frmListaProductos : Form
    {
        List<clsProducto> lista;

        public INegocio<clsProducto> ProductoNegocio { get; }
        public IServiceProvider ServiceProvider { get; }

        public frmListaProductos(INegocio<clsProducto> _clienteNegocio, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            ProductoNegocio = _clienteNegocio;
            ServiceProvider = serviceProvider;
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListaProductos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Mantenimiento de Productos";
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            try
            {
                lista = ProductoNegocio.getAll();
                cargarListView(lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cargarListView(List<clsProducto> lista)
        {
            lstVista.Items.Clear();

            foreach (var producto in lista)
            {
                ListViewItem item = new ListViewItem();
                item.Text = producto.codigo;
                item.SubItems.Add(producto.nombre.ToUpper());
                item.SubItems.Add(producto.categoria.ToString());
                item.SubItems.Add(producto.precioCosto.ToString());
                item.SubItems.Add(producto.porcUtilidad.ToString());
                item.SubItems.Add(producto.impuesto.ToString());
                item.SubItems.Add(producto.cantidadStock.ToString());
                lstVista.Items.Add(item);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var form = ServiceProvider.GetRequiredService<frmProducto>();
            form.ShowDialog();

            obtenerDatos();
        }

        private void pcbMinizar_Click(object sender, EventArgs e)
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
