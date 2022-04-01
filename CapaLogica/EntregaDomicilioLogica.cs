using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class EntregaDomicilioLogica
    {
        public static void Guardar(EntregaDomicilio ent)
        {
            try
            {
                EntregaDomicilioDatos datos = new EntregaDomicilioDatos();
                if (datos.SeleccionarPorId(ent.IdEntrega) == null)
                    datos.Guardar(ent);
                else
                    datos.Actualizar(ent);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<EntregaDomicilio> SeleccionarEntregas()
        {
            try
            {
                EntregaDomicilioDatos datos = new EntregaDomicilioDatos();
                return datos.SeleccionarEntregas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static EntregaDomicilio SeleccionarPorId(int idEntrega)
        {
            try
            {
                EntregaDomicilioDatos datos = new EntregaDomicilioDatos();
                return datos.SeleccionarPorId(idEntrega);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AgregarProducto(Producto prod, EntregaDomicilio ent, int cantidad)
        {
            try
            {
                EntregaDomicilioDatos datos = new EntregaDomicilioDatos();
                datos.InsertarProductos(prod.Codigo, ent.IdEntrega, cantidad);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void EliminarProducto(Producto prod, EntregaDomicilio ent)
        {
            try
            {
                EntregaDomicilioDatos datos = new EntregaDomicilioDatos();
                datos.EliminarMaterial(prod.Codigo, ent.IdEntrega);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
