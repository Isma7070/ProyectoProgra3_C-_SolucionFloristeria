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

namespace CapaUI.EntregasYEncargos
{
    public partial class frmGestionEntregasYEncargos : Form
    {
        public frmGestionEntregasYEncargos()
        {
            InitializeComponent();
        }

        private void frmGestionEntregasYEncargos_Load(object sender, EventArgs e)
        {
            try
            {
                cboClientes.DataSource = ClienteLogica.SeleccionarClientesActivos();
                cboClientes.DisplayMember = "ToString()";
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "+ ex.ToString());
            }
        }

        private void Refrescar()
        {
            try
            {
                dgvMaterialesActivos.DataSource = EntregaDomicilioLogica.SeleccionarEntregas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(richTextBox1.Text))
                {
                    MessageBox.Show("Ingrese la direccion de la entrega.");
                }
                EntregaDomicilio entrega = new EntregaDomicilio()
                {
                    IdEntrega = Validacion.VacioNullEnBlanco(txtBuscar.Text)?0: int.Parse(txtBuscar.Text),
                    IdCliente = ((Cliente)cboClientes.SelectedItem).IdCliente,
                    DireccionEntrega = richTextBox1.Text,
                    Autorizacion = chkAutorizado.Checked
                };
                EntregaDomicilioLogica.Guardar(entrega);
                MessageBox.Show("Entrega a domicilio ha sido guardada.");
                Refrescar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void dgvMaterialesActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMaterialesActivos.SelectedRows.Count > 0)
            {
                EntregaDomicilio ent = (EntregaDomicilio)dgvMaterialesActivos.SelectedRows[0].DataBoundItem;
                CargarDatos(ent);
            }
        }
        private void CargarDatos(EntregaDomicilio ent)
        {
            txtBuscar.Text = ent.IdEntrega.ToString();
            richTextBox1.Text = ent.DireccionEntrega;
            foreach (var item in cboClientes.Items)
            {
                if (((Cliente)item).IdCliente == ent.IdCliente)
                {
                    cboClientes.SelectedItem = item;
                }
            }
            chkAutorizado.Checked = ent.Autorizacion;
        }

        private void Limpiar()
        {
            richTextBox1.Text = "";
            txtBuscar.Text = "";
            chkAutorizado.Checked = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                EntregaDomicilio ent = EntregaDomicilioLogica.SeleccionarPorId(int.Parse(txtBuscar.Text));
                if (ent != null)
                {
                    CargarDatos(ent);
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

        private void btnProductosPedido_Click(object sender, EventArgs e)
        {
            if (dgvMaterialesActivos.SelectedRows.Count > 0)
            {
                EntregaDomicilio ent = (EntregaDomicilio)dgvMaterialesActivos.SelectedRows[0].DataBoundItem;
                EntregasYEncargos.frmProductosEncargo frm = new frmProductosEncargo();
                frm.entrega = ent;
                frm.ShowDialog();
            }
        }
    }
}
