using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ImagenProductoLogica
    {
        public static void Insertar(ImagenProducto image)
        {
            try
            {
                ImagenProductoDatos datos = new ImagenProductoDatos();
                datos.Guardar(image);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Eliminar(int idProducto, int idImagen )
        {
            try
            {
                ImagenProductoDatos datos = new ImagenProductoDatos();
                datos.Eliminar(idProducto, idImagen);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<ImagenProducto> SeleccionarPorProducto(int idProducto)
        {
            try
            {
                ImagenProductoDatos datos = new ImagenProductoDatos();
                return datos.SeleccionarPorProducto(idProducto);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
