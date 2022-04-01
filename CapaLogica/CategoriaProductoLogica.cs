using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaProductoLogica
    {
        public static void Guardar(CategoriaProducto cat)
        {
            try
            {
                CategoriaProductoDatos datos = new CategoriaProductoDatos();
                if (datos.SeleccionarPorId(cat.IdCategoria) == null)
                    datos.Guardar(cat);
                else
                    datos.Actualizar(cat);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<CategoriaProducto> SeleccionarTodos()
        {
            try
            {
                CategoriaProductoDatos datos = new CategoriaProductoDatos();
                return datos.SeleccionarTodo();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                CategoriaProductoDatos datos = new CategoriaProductoDatos();
                datos.Eliminar(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
