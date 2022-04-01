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

namespace CapaUI.Proveedores
{
    public partial class frmProveedoresInactivos : Form
    {
        Proveedor prov;
        public frmProveedoresInactivos()
        {
            InitializeComponent();
        }

        private void frmProveedoresInactivos_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Refrescar();
        }

        private void dgvClienteInactivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedoresInactivos.SelectedRows.Count > 0)
            {
                prov = (Proveedor)dgvProveedoresInactivos.SelectedRows[0].DataBoundItem;
                txtNombre.Text = prov.Nombre;
                txtId.Text = prov.idProveedor.ToString();
            }
        }

        private void Refrescar()
        {
            try
            {
                dgvProveedoresInactivos.DataSource = ProveedorLogica.SeleccionarNoActivos();
                txtId.Text = "";
                txtNombre.Text = "";
                prov = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (prov != null)
                {
                    prov.Activo = true;
                    ProveedorLogica.Guardar(prov);
                    MessageBox.Show("Proveedor activado.");
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Seleccione el proveedor que desea activar.");
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
