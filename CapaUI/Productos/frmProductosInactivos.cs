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

namespace CapaUI.Productos
{
    public partial class frmProductosInactivos : Form
    {
        Producto pro;
        public frmProductosInactivos()
        {
            InitializeComponent();
        }

        private void frmProductosInactivos_Load(object sender, EventArgs e)
        {
            Refrescar();
            txtCodigo.Enabled = false;
        }
        private void Refrescar()
        {
            try
            {
                dataGridView1.DataSource = ProductoLogica.SeleccionarNoActivos();
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
                pro = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                CargarDatos(pro);
            }
        }

        private void CargarDatos(Producto prod)
        {
            txtCodigo.Text = prod.Codigo.ToString();
            txtNombre.Text = prod.Nombre;
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pro != null)
                {
                    pro.Activo = true;
                    ProductoLogica.Guardar(pro);
                    MessageBox.Show("Producto activado.");
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Seleccione el producto que desea activar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }
    }
}
