using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI.Costos_y_Precios
{
    public partial class frmGestionCostosYPrecios : Form
    {
        Producto pro;
        public frmGestionCostosYPrecios()
        {
            InitializeComponent();
        }

        private void frmGestionCostosYPrecios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }
        private void Refrescar()
        {
            try
            {
                dataGridView1.DataSource = ProductoLogica.SeleccionarActivos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Producto pro = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                CargarDatos(pro);
            }
        }

        private void CargarDatos(Producto pro)
        {
            txtCodigo.Text = pro.Codigo.ToString();
            txtNombre.Text = pro.Nombre;
            txtCosto.Text = ((int)ProductoLogica.CalcularCostoProducto(pro)).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtCostoManoObra.Text = "";
            txtGanancia.Text = "";
        }

        private void btnCalcularPrecioVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(txtCostoManoObra.Text))
                {
                    MessageBox.Show("Ingrese el costo de mano de obra");
                }
                if (Validacion.VacioNullEnBlanco(txtGanancia.Text))
                {
                    MessageBox.Show("Ingrese la ganancia.");
                }
                pro = ProductoLogica.SeleccionarPorId(int.Parse(txtCodigo.Text));
                double precioVenta = ProductoLogica.CalcularCostoProducto(pro) + int.Parse(txtCostoManoObra.Text) + int.Parse(txtGanancia.Text);
                
                txtPrecioVenta.Text = precioVenta.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void txtCostoManoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btnGuardarPrecio_Click(object sender, EventArgs e)
        {
            try
            {
                pro.PrecioVenta = double.Parse(txtPrecioVenta.Text);
                ProductoLogica.Guardar(pro);
                MessageBox.Show("Precio de Venta guardado éxitosamente.");
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }
    }
}
