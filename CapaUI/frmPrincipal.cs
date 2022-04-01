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

namespace CapaUI
{
    public partial class frmPrincipal : Form
    {
        public Usuario miUsuario { get; set; }
        public frmPrincipal()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() +"    "+ DateTime.Now.ToShortTimeString(); ;
        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productoFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionProductos frm = new frmGestionProductos();
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() +"    "+ DateTime.Now.ToShortTimeString();
        }

        private void volverAInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea cerrar la aplicación?", "Cerrar Aplicación", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUI.Materiales.frmGestionMateriales frm = new Materiales.frmGestionMateriales();
            frm.Show();
        }

        private void mantenimientoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUI.Clientes.frmGestionClientes frm = new Clientes.frmGestionClientes();
            frm.Show();
        }

        private void gestiónDeRepartosADomicilioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUI.EntregasYEncargos.frmGestionEntregasYEncargos frm = new EntregasYEncargos.frmGestionEntregasYEncargos();
            frm.Show();
        }

        private void gestiónDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUI.Proveedores.frmGestionProveedores frm = new Proveedores.frmGestionProveedores();
            frm.Show();
        }

        private void gestionDeCostosPreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapaUI.Costos_y_Precios.frmGestionCostosYPrecios frm = new Costos_y_Precios.frmGestionCostosYPrecios();
            frm.Show();
        }
    }
}
