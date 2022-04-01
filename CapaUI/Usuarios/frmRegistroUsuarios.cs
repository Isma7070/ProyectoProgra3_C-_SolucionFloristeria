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

namespace CapaUI.Usuarios
{
    public partial class frmRegistroUsuarios : Form
    {
        public frmRegistroUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtIdEmpleado.Text) ||
                    string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido1.Text)
                    || string.IsNullOrEmpty(txtApellido2.Text) || string.IsNullOrEmpty(txtContraseña.Text)
                    || string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Por favor complete todos los datos solicitados.");
                    return;
                }
                else
                {
                    if (!string.Equals(txtContraseña.Text,txtContraseña.Text))
                    {
                        MessageBox.Show("La confirmación de contraseña y la contraseña que desea almacenar deben ser iguales. Por favor verifique los datos solicitados.");
                        txtConfirmarConstraseña.SelectAll();
                        return;
                    }else
                    {
                        Empleado emp = new Empleado()
                        {
                            IdEmpleado = int.Parse(txtIdEmpleado.Text),
                            Nombre = txtNombre.Text,
                            Apellido1 = txtApellido1.Text,
                            Apellido2 = txtApellido2.Text
                        };
                        EmpleadoLogica.InsertarEmpleado(emp);

                        //Procesar Clave
                        string clave = txtContraseña.Text.Trim();
                        byte[] salt = CapaLogica.Seguridad.Cryptographic.GenerateSalt();
                        var hashedPassword = CapaLogica.Seguridad.Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(clave), salt);
                        Usuario usu = new Usuario()
                        {
                            IdUsuario = int.Parse(txtNumeroUsuario.Text),
                            IdPuesto = ((Puesto)cboPuestos.SelectedItem).IdPuesto,
                            IdEmpleado = int.Parse(txtIdEmpleado.Text),
                            Salt = salt,
                            Clave = hashedPassword
                        };
                        UsuarioLogica.GuardarUsuario(usu);
                        MessageBox.Show("Usuario guardado éxitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void frmRegistroUsuarios_Load(object sender, EventArgs e)
        {
            txtNumeroUsuario.ReadOnly = true;
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                cboPuestos.DataSource = PuestoLogica.SeleccionarPuestos();
                cboPuestos.DisplayMember = "Descripcion";
                cboPuestos.ValueMember = "IdPuesto";
                int numeroUsuarioNuevo = UsuarioLogica.ObtenerUltimoNumeroUsuario() + 1;
                txtNumeroUsuario.Text = numeroUsuarioNuevo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtIdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }
    }
}
