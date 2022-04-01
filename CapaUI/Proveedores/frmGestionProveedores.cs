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
    public partial class frmGestionProveedores : Form
    {
        public frmGestionProveedores()
        {
            InitializeComponent();
        }

        private void frmGestionProveedores_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void txtIDProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string idProv = txtIDProveedor.Text;
                string nombre = txtNombre.Text;
                string email = txtEmail.Text;
                string direccion = rtxtDireccion.Text;
                bool activo = chkActivo.Checked;
                if (Validacion.VacioNullEnBlanco(idProv))
                {
                    MessageBox.Show("Ingrese el ID del Proveedor.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(nombre))
                {
                    MessageBox.Show("Ingrese el nombre del Proveedor.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(email))
                {
                    MessageBox.Show("Ingrese el email del Proveedor.");
                    return;
                }
                if (!Validacion.VacioNullEnBlanco(email) && !Validacion.IsValidEmail(email))
                {
                    MessageBox.Show("Ingrese un email válido para el proveedor.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(direccion))
                {
                    MessageBox.Show("Ingrese la dirección del Proveedor.");
                    return;
                }
                //Creacion de la instancia
                Proveedor proveedor = new Proveedor()
                {
                    idProveedor = int.Parse(idProv),
                    Nombre = nombre,
                    Email = email,
                    Direccion = direccion,
                    Activo = activo
                };
                ProveedorLogica.Guardar(proveedor);
                MessageBox.Show("Proveedor guardado éxitosamente.");
                Refrescar();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void Refrescar()
        {
            try
            {
                dgvProveedoresActivos.DataSource = ProveedorLogica.SeleccionarActivos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" +
                    ex.ToString());
            }
        }
        private void Limpiar()
        {
            rtxtDireccion.Text = "";
            txtIDProveedor.Text = "";
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtBuscar.Text = "";
            chkActivo.Checked = false;
        }

        private void CargarDatosProveedor(Proveedor pro)
        {
            txtIDProveedor.Text = pro.idProveedor.ToString();
            txtIDProveedor.Enabled = false;
            txtNombre.Text = pro.Nombre;
            txtEmail.Text = pro.Email;
            rtxtDireccion.Text = pro.Direccion;
            chkActivo.Checked = pro.Activo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtIDProveedor.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(txtBuscar.Text))
                {
                    MessageBox.Show("Por favor ingrese la ID del Proveedor a buscar.");
                    return;
                }
                else
                {
                    Proveedor prov = ProveedorLogica.SeleccionarPorId(int.Parse(txtBuscar.Text));
                    if (prov != null)
                    {
                        CargarDatosProveedor(prov);
                    }
                    else
                    {
                        MessageBox.Show("El proveedor no ha sido encontrado, por favor verifique los datos ingresados.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void dgvMaterialesActivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedoresActivos.SelectedRows.Count > 0)
            {
                Proveedor pro = (Proveedor)dgvProveedoresActivos.SelectedRows[0].DataBoundItem;
                CargarDatosProveedor(pro);
            }
        }

        private void btnVerMaterialesInactivos_Click(object sender, EventArgs e)
        {
            frmProveedoresInactivos frm = new frmProveedoresInactivos();
            frm.Show();
        }

        private void frmGestionProveedores_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
