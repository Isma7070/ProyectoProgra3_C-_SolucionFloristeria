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

namespace CapaUI.Materiales
{
    public partial class frmMaterialesInactivos : Form
    {
        Material mat;
        public frmMaterialesInactivos()
        {
            InitializeComponent();
        }

        private void frmMaterialesInactivos_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                dataGridView1.DataSource = MaterialLogica.SeleccionarNoActivos();
                txtId.Text = "";
                txtNombre.Text = "";
                mat = null;
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
                mat = (Material)dataGridView1.SelectedRows[0].DataBoundItem;
                txtNombre.Text = mat.Descripcion;
                txtId.Text = mat.IdMaterial.ToString();
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (mat != null)
                {
                    mat.Activo = true;
                    MaterialLogica.Guardar(mat);
                    MessageBox.Show("Material activado.");
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Seleccione el material que desea activar.");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }
    }
}
