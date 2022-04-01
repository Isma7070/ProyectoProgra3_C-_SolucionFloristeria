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

namespace CapaUI.Productos
{
    public partial class frmAsignacionMateriales : Form
    {
        public Producto producto { get; set; }
        public frmAsignacionMateriales()
        {
            InitializeComponent();
        }

        private void frmAsignacionMateriales_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                if (producto == null)
                    return;
                Disponibles.DataSource = MaterialLogica.SeleccionarDisponibles(producto.Codigo);
                Disponibles.DisplayMember = "Descripcion";

                Asignados.DataSource = MaterialLogica.SeleccionarPorProducto(producto.Codigo);
                Asignados.DisplayMember = "Descripcion";

                numericUpDown1.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Disponibles.SelectedItem != null)
                {
                    var material = (Material)Disponibles.SelectedItem;
                    ProductoLogica.AgregarMaterial(producto, material, (int)numericUpDown1.Value);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Asignados.SelectedItem != null)
                {
                    var material = (Material)Asignados.SelectedItem;
                    ProductoLogica.EliminarProveedor(producto, material);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }

        }
    }
}
