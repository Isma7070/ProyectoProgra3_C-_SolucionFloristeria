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
    public partial class frmGestionClientes : Form
    {
        public frmGestionClientes()
        {
            InitializeComponent();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e);

        }

        private void txtBuscarClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIdentificacion.Text);
            string nombre = txtNombre.Text;
            string apellido1 = txtApellido1.Text;
            string apellido2 = txtApellido2.Text;
            string email = txtEmail.Text;
            string direccion = txBDireccion.Text;
            bool activo = chkActivo.Checked;
            try
            {
                if (Validacion.VacioNullEnBlanco(idCliente.ToString()))
                {
                    MessageBox.Show("Ingrese la identificación del cliente.");
                    return;
                }

                if (Validacion.VacioNullEnBlanco(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del cliente.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(apellido1))
                {
                    MessageBox.Show("Ingrese el primer apellido del cliente.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(apellido2))
                {
                    MessageBox.Show("Ingrese el segundo apellido del cliente.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(email))
                {
                    MessageBox.Show("Ingrese el email del cliente.");
                    return;
                }
                if (!Validacion.IsValidEmail(email) && !Validacion.VacioNullEnBlanco(email))
                {
                    MessageBox.Show("Por favor ingrese un email válido.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(direccion))
                {
                    MessageBox.Show("Por favor ingrese la dirección del cliente.");
                    return;
                }
                //Construccion de la instancia
                Cliente cliente = new Cliente()
                {
                    IdCliente = idCliente,
                    Nombre = nombre,
                    Apellido1 = apellido1,
                    Apellido2 = apellido2,
                    Email = email,
                    Direccion = direccion,
                    Activo = activo 
                };
                ClienteLogica.GuardarCliente(cliente);
                MessageBox.Show("Cliente guardado éxitosamente.");
                Limpiar();
                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void Limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtEmail.Text = "";
            txBDireccion.Text = "";
            chkActivo.Checked = false;
            txtBuscarClienteID.Text = "";
            
        }

        private void Refrescar()
        {
            try
            {
                dgvClientesActivos.DataSource = ClienteLogica.SeleccionarClientesActivos();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" +
                    ex.ToString());
            }
        }

        private void CargarDatosCliente(Cliente cli)
        {
            txtIdentificacion.Text = cli.IdCliente.ToString();
            txtIdentificacion.Enabled = false;
            txtNombre.Text = cli.Nombre;
            txtApellido1.Text = cli.Apellido1;
            txtApellido2.Text = cli.Apellido2;
            txtEmail.Text = cli.Email;
            txBDireccion.Text = cli.Direccion;
            chkActivo.Checked = cli.Activo;
        }

        private void frmGestionClientes_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(txtBuscarClienteID.Text))
                {
                    MessageBox.Show("Por favor la identificación del cliente a buscar.");
                    return;
                }
                else
                {
                    Cliente cliente = ClienteLogica.SeleccionarClientePorID(int.Parse(txtBuscarClienteID.Text));
                    if (cliente != null)
                    {
                        CargarDatosCliente(cliente);
                    }else
                    {
                        MessageBox.Show("El cliente no ha sido encontrado, por favor verifique los datos ingresados.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtIdentificacion.Enabled = true;
        }

        private void dgvClientesActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientesActivos.SelectedRows.Count > 0)
            {
                Cliente cli= (Cliente)dgvClientesActivos.SelectedRows[0].DataBoundItem;
                CargarDatosCliente(cli);
            }
        }

        private void btnVerClientesInactivos_Click(object sender, EventArgs e)
        {
            frmClientesInactivos frm = new frmClientesInactivos();
            frm.Show();
        }

        private void frmGestionClientes_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
