using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class PuestoLogica
    {
        public static List<Puesto> SeleccionarPuestos()
        {
            try
            {
                PuestoDatos datos = new PuestoDatos();
                return datos.SeleccionarPuestos();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
