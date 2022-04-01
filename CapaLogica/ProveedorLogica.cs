using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProveedorLogica
    {
        public static void Guardar(Proveedor prov)
        {
            try
            {
                ProveedorDatos datos = new ProveedorDatos();
                if (datos.SeleccionarPorId(prov.idProveedor) == null)
                    datos.Guardar(prov);
                else
                    datos.Actualizar(prov);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Proveedor> SeleccionarActivos()
        {
            try
            {
                ProveedorDatos datos = new ProveedorDatos();
                return datos.SeleccionarActivos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Proveedor> SeleccionarNoActivos()
        {
            try
            {
                ProveedorDatos datos = new ProveedorDatos();
                return datos.SeleccionarInactivos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Proveedor SeleccionarPorId(int idProveedor)
        {
            try
            {
                ProveedorDatos datos = new ProveedorDatos();
                return datos.SeleccionarPorId(idProveedor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
