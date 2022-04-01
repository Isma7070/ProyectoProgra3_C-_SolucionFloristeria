using CapaEntidadades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaUI.Productos
{
    public partial class frmAsignacionImagenesProducto : Form
    {
        public Producto producto { get; set; }
        public frmAsignacionImagenesProducto()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog getImage = new OpenFileDialog();
                getImage.InitialDirectory = "C:\\";
                getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
                if (getImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.ImageLocation = getImage.FileName;
                    string rutaImagen = getImage.FileName;
                    byte[] imagen = ConvertirImagenEnByteArray(pictureBox1.Image);
                    ImagenProducto image = new ImagenProducto()
                    {
                        IdProducto = producto.Codigo,
                        IdImagen = pictureBox1.Image.Height,
                        Foto = imagen
                    };
                    ImagenProductoLogica.Insertar(image);
                    MessageBox.Show("Imagen insertada.");
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna imagen.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error :" + ex.ToString());
            }
            
        }

        private byte[] ConvertirImagenEnByteArray(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

        private Image ConvertirByteArrayEnImagen(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void frmAsignacionImagenesProducto_Load(object sender, EventArgs e)
        {
            try
            {
                Image imagen;
                foreach (var item in ImagenProductoLogica.SeleccionarPorProducto(producto.Codigo))
                {
                    imagen = ConvertirByteArrayEnImagen(item.Foto);
                    pictureBox1.Image = imagen;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error :" + ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ImagenProductoLogica.Eliminar(producto.Codigo, pictureBox1.Image.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error :" + ex.ToString());
            }
        }
    }
}
