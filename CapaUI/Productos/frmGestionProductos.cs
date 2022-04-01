using CapaAccesoDatos;
using CapaEntidadades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI
{
    public partial class frmGestionProductos : Form
    {
        public frmGestionProductos()
        {
            InitializeComponent();
        }

        private void frmGestionProductos_Load(object sender, EventArgs e)
        {
            cboCategoria.DataSource = CategoriaProductoLogica.SeleccionarTodos();
            cboCategoria.DisplayMember = "Nombre";
            Refrescar();
            Limpiar();
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

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txbDescripcion.Text = "";
            chkActivo.Checked = false;
            txtCodigo.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                string descripcion = txbDescripcion.Text;
                int idCategoria = ((CategoriaProducto)cboCategoria.SelectedItem).IdCategoria;
                bool activo = chkActivo.Checked;

                if (Validacion.VacioNullEnBlanco(txtCodigo.Text))
                {
                    MessageBox.Show("Ingrese el código del producto.");
                    return;
                }
                if(Validacion.VacioNullEnBlanco(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del producto.");
                    return;
                }
                if(Validacion.VacioNullEnBlanco(descripcion))
                {
                    MessageBox.Show("Ingrese la descripción del producto.");
                    return;
                }

                Producto producto = new Producto()
                {
                    Codigo = codigo,
                    Nombre = nombre,
                    Descripcion = descripcion,
                    IdCategoria  = idCategoria,
                    Activo = activo,
                    PrecioVenta = 0
                };
                ProductoLogica.Guardar(producto);
                MessageBox.Show("Producto guardado éxitosamente.");
                Refrescar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(txtCodigo.Text))
                {
                    MessageBox.Show("Ingrese el código del producto a buscar.");
                    return;
                }
                Producto prod = ProductoLogica.SeleccionarPorId(int.Parse(txtCodigo.Text));
                if (prod != null)
                {
                    CargarDatos(prod);
                    MessageBox.Show("Producto encontrado.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void CargarDatos(Producto prod)
        {
            txtCodigo.Text = prod.Codigo.ToString();
            txtCodigo.Enabled = false;
            txtNombre.Text = prod.Nombre;
            txbDescripcion.Text = prod.Descripcion;
            foreach (var item in cboCategoria.Items)
            {
                if (((CategoriaProducto)item).IdCategoria == prod.IdCategoria)
                {
                    cboCategoria.SelectedItem = item;
                }
            }
            chkActivo.Checked = prod.Activo;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Producto pro = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                CargarDatos(pro);
            }
        }

        private void frmGestionProductos_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnVerProductoInactivos_Click(object sender, EventArgs e)
        {
            Productos.frmProductosInactivos frm = new Productos.frmProductosInactivos();
            frm.Show();
        }

        private void btnAsignarMateriales_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Producto pro = (Producto)dataGridView1.SelectedRows[0].DataBoundItem;
                Productos.frmAsignacionMateriales frm = new Productos.frmAsignacionMateriales();
                frm.producto = pro;
                frm.ShowDialog();
            }
        }
    }
}
