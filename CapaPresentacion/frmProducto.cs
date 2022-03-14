using Entidades;
using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.Interfaces;
using static Utilidades.Enumeradores;

namespace CapaPresentacion
{
    public partial class frmProducto : Form
    {
        public clsProducto producto { get; set; }

        public INegocio<clsProducto> ProductoNegocio { get; }

        public frmProducto(INegocio<clsProducto> _productoNegocio)
        {
            InitializeComponent();
            ProductoNegocio = _productoNegocio;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Crear Producto";
            cargarCombos();
            cmbCategoria.SelectedIndex = 0;
        }

        private void cargarCombos()
        {
            cmbCategoria.DataSource = Enum.GetValues(typeof(categoria));
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool isCorrect = validarDatos();
            CultureInfo culture = new CultureInfo("en-US");

            try
            {
                if (isCorrect)
                {
                    clsProducto producto = new clsProducto();
                    producto.codigo = txtCodigo.Text.Trim().ToUpper();
                    producto.nombre = txtNombre.Text.Trim().ToUpper();
                    producto.categoria = (int) cmbCategoria.SelectedValue;
                    producto.precioCosto = Convert.ToDecimal(txtPrecioCosto.Text.ToString(), culture);
                    producto.porcUtilidad = Convert.ToDecimal(txtPorcUtilidad.Text.ToString(), culture);
                    producto.impuesto = int.Parse(txtImpuesto.Text.ToString());
                    producto.cantidadStock = Convert.ToDecimal(txtCantStock.Text.ToString(), culture);
                    producto.estado = true;

                    ProductoNegocio.save(producto);
                    MessageBox.Show("Producto guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            catch (EntityExistException ex)
            {
                MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar, contacte el Administrador", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Falta el Código", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("Falta el Nombre", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPrecioCosto.Text == string.Empty)
            {
                MessageBox.Show("Falta el Precio-Costo", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtPorcUtilidad.Text == string.Empty)
            {
                MessageBox.Show("Falta el Porcentaje Utilidad", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtImpuesto.Text == string.Empty)
            {
                MessageBox.Show("Falta el Impuesto", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtCantStock.Text == string.Empty)
            {
                MessageBox.Show("Falta la Cantidad Stock", "Faltan Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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

        private void pcbMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
