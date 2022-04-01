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
    public partial class frmGestionMateriales : Form
    {
        public frmGestionMateriales()
        {
            InitializeComponent();
        }

        private void txtIDMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void frmGestionMateriales_Load(object sender, EventArgs e)
        {
            Refrescar();
            cboProveedores.DataSource = ProveedorLogica.SeleccionarActivos();
            cboProveedores.DisplayMember = "Nombre";
        }

        private void Refrescar()
        {
            try
            {
                dgvMaterialesActivos.DataSource = MaterialLogica.SeleccionarActivos();
                //cboProveedores.DataSource = ProveedorLogica.SeleccionarActivos();
                //cboProveedores.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error:" +
                    ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int idMat = int.Parse(txtIDMaterial.Text);
                string descripcion = txtDescripcion.Text;
                double precioCosto = double.Parse(txtPrecioCosto.Text);
                int stock = (int)nudStock.Value;
                int minimoStock = (int)nudMinimoStock.Value;
                int idProveedor = ((Proveedor)cboProveedores.SelectedItem).idProveedor;
                bool activo = chkActivo.Checked;

                if (Validacion.VacioNullEnBlanco(txtIDMaterial.Text))
                {
                    MessageBox.Show("Ingrese el ID del material.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(descripcion))
                {
                    MessageBox.Show("Ingrese la descripcion del material.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(txtPrecioCosto.Text))
                {
                    MessageBox.Show("Ingrese el precio de Costo del material.");
                    return;
                }
                if (Validacion.VacioNullEnBlanco(txtIDMaterial.Text))
                {
                    MessageBox.Show("Ingrese el ID del material.");
                    return;
                }

                //Creacion de instancia
                Material material = new Material()
                {
                    IdMaterial = idMat,
                    Descripcion = descripcion,
                    Precio = precioCosto,
                    Stock = stock,
                    IdProveedor = idProveedor,
                    MinimoEnStock = minimoStock,
                    Activo = activo
                };
                MaterialLogica.Guardar(material);
                MessageBox.Show("Material guardado éxitosamente.");
                Refrescar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.ToString());
            }
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtIDMaterial.Text = "";
            txtDescripcion.Text = "";
            txtPrecioCosto.Text = "";
            nudMinimoStock.Value = 1;
            nudStock.Value = 1;
            chkActivo.Checked = false;
        }

        private void CargarDatosMaterial(Material mat)
        {
            txtIDMaterial.Text = mat.IdMaterial.ToString();
            txtIDMaterial.Enabled = false;
            txtDescripcion.Text = mat.Descripcion;
            txtPrecioCosto.Text = mat.Precio.ToString();
            nudMinimoStock.Value = mat.MinimoEnStock;
            nudStock.Value = mat.Stock;
            foreach (var item in cboProveedores.Items)
            {
                if (((Proveedor)item).idProveedor == mat.IdProveedor )
                {
                    cboProveedores.SelectedItem = item;
                }
            }
            chkActivo.Checked = mat.Activo;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            txtIDMaterial.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacion.VacioNullEnBlanco(txtBuscar.Text))
                {
                    MessageBox.Show("Por favor ingrese el ID del material a buscar.");
                    return;
                }
                else
                {
                    Material mat = MaterialLogica.SeleccionarPorId(int.Parse(txtBuscar.Text));
                    if (mat != null)
                    {
                        CargarDatosMaterial(mat);
                    }
                    else
                    {
                        MessageBox.Show("El material no ha sido encontrado, por favor verifique los datos ingresados.");
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
            if (dgvMaterialesActivos.SelectedRows.Count > 0)
            {
                Material mat = (Material)dgvMaterialesActivos.SelectedRows[0].DataBoundItem;
                CargarDatosMaterial(mat);
            }
        }

        private void btnVerMaterialesInactivos_Click(object sender, EventArgs e)
        {
            frmMaterialesInactivos frm = new frmMaterialesInactivos();
            frm.Show();
        }

        private void frmGestionMateriales_Activated(object sender, EventArgs e)
        {
            Refrescar();
        }
    }
}
