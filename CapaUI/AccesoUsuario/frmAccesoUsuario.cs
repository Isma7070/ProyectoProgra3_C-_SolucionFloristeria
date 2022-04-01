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

namespace CapaUI
{
    public partial class frmAccesoUsuario : Form
    {
        public frmAccesoUsuario()
        {
            InitializeComponent();
        }

        private void txtNumeroUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNumeroUsuario.Text)||string.IsNullOrEmpty(txtContraseña.Text))
                {
                    MessageBox.Show("Por favor complete todos los datos solicitados.");
                    return;
                }else
                {
                    int numeroUsuario = int.Parse(txtNumeroUsuario.Text);
                    string clave = txtContraseña.Text;
                    Usuario unUsuario = UsuarioLogica.ComprobarClaveValida(numeroUsuario, clave);
                    if (unUsuario !=null)
                    {
                        MessageBox.Show("Ingreso éxitoso. Bienvenido(a).");
                        frmPrincipal frm = new frmPrincipal();
                        frm.miUsuario = unUsuario;
                        txtContraseña.Text = "";
                        txtNumeroUsuario.Text = "";
                        frm.Show();
                    }else
                    {
                        MessageBox.Show("Número de usuario o contraseña son incorrectos, por favor verifique los datos e ingreselos nuevamente.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }
    }
}
