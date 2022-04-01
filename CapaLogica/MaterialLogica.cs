using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MaterialLogica
    {
        public static void Guardar(Material mat)
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                if (datos.SeleccionarPorId(mat.IdMaterial) == null)
                    datos.GuardarMaterial(mat);
                else
                    datos.Actualizar(mat);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Material> SeleccionarActivos()
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                return datos.SeleccionarActivos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Material> SeleccionarNoActivos()
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                return datos.SeleccionarInactivos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Material SeleccionarPorId(int idMaterial)
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                return datos.SeleccionarPorId(idMaterial);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Material> SeleccionarDisponibles(int codigo)
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                var todos = datos.SeleccionarActivos();
                var seleccionados = datos.SeleccionarPorProducto(codigo);
                var disponibles = new List<Material>();

                foreach (var mat in todos)
                {
                    var m = seleccionados.FirstOrDefault(x => x.IdMaterial == mat.IdMaterial);
                    if (m == null)
                    {
                        disponibles.Add(mat);
                    }
                }

                return disponibles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Material> SeleccionarPorProducto(int codigo)
        {
            try
            {
                MaterialDatos datos = new MaterialDatos();
                return datos.SeleccionarPorProducto(codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
