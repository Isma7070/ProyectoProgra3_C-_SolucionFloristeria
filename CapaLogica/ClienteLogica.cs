using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ClienteLogica
    {
        public static void GuardarCliente(Cliente cli)
        {
            try
            {
                ClienteDatos datos = new ClienteDatos();
                if (datos.SeleccionarPorId(cli.IdCliente) == null)
                    datos.GuardarCliente(cli);
                else
                   datos.ActualizarCliente(cli);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Cliente> SeleccionarClientesActivos()
        {
            try
            {
                ClienteDatos datos = new ClienteDatos();
                return datos.SeleccionarClienteActivos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Cliente> SeleccionarClientesNoActivos()
        {
            try
            {
                ClienteDatos datos = new ClienteDatos();
                return datos.SeleccionarClientesInactivos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Cliente SeleccionarClientePorID(int id)
        {
            try
            {
                ClienteDatos datos = new ClienteDatos();
                return datos.SeleccionarPorId(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
