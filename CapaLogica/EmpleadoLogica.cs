using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class EmpleadoLogica
    {
        public static void InsertarEmpleado(Empleado emp)
        {
            try
            {
                EmpleadoDatos datos = new EmpleadoDatos();
                datos.CrearEmpleado(emp);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
