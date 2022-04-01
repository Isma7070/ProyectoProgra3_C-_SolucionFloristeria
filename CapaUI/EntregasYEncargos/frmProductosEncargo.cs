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

namespace CapaUI.EntregasYEncargos
{
    public partial class frmProductosEncargo : Form
    {
        public EntregaDomicilio entrega { get; set; }
        public frmProductosEncargo()
        {
            InitializeComponent();
        }

        private void frmProductosEncargo_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                if (entrega == null)
                    return;
                Disponibles.DataSource = ProductoLogica.SeleccionarDisponibles(entrega.IdEntrega);
                Disponibles.DisplayMember = "Nombre";

                Asignados.DataSource = ProductoLogica.SeleccionarPorProducto(entrega.IdEntrega);
                Asignados.DisplayMember = "Nombre";

                numericUpDown1.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Disponibles.SelectedItem != null)
                {
                    var pro = (Producto)Disponibles.SelectedItem;
                    EntregaDomicilioLogica.AgregarProducto(pro, entrega, (int)numericUpDown1.Value);
                    Refrescar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Asignados.SelectedItem != null)
                {
                    var pro = (Producto)Asignados.SelectedItem;
                    EntregaDomicilioLogica.EliminarProducto(pro, entrega);
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
