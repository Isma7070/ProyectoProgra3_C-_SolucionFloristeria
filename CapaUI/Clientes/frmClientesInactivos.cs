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

namespace CapaUI.Clientes
{
    public partial class frmClientesInactivos : Form
    {
        Cliente cli;
        public frmClientesInactivos()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClienteInactivos.SelectedRows.Count > 0)
            {
                cli = (Cliente)dgvClienteInactivos.SelectedRows[0].DataBoundItem;
                txtNombre.Text = cli.Nombre  + " " + cli.Apellido1 + " " + cli.Apellido2;
                txtId.Text = cli.IdCliente.ToString();
            }
        }

        private void frmClientesInactivos_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            Refrescar();
        }
        private void Refrescar()
        {
            try
            {
                dgvClienteInactivos.DataSource = ClienteLogica.SeleccionarClientesNoActivos();
                txtId.Text = "";
                txtNombre.Text = "";
                cli = null;
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
                if (cli != null)
                {
                    cli.Activo = true;
                    ClienteLogica.GuardarCliente(cli);
                    MessageBox.Show("Cliente activado.");
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("Seleccione el cliente que desea activar.");
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
