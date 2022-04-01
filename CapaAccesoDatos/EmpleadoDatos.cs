using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class EmpleadoDatos
    {
        public void CrearEmpleado(Empleado emp)
        {
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                string sql = "PA_InsertarEmpleado";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEmpleado", emp.IdEmpleado);
                comando.Parameters.AddWithValue("@nombre", emp.Nombre);
                comando.Parameters.AddWithValue("@apellido1", emp.Apellido1);
                comando.Parameters.AddWithValue("@apellido2", emp.Apellido2);
                // Ejecutar comando Sin Consulta
                comando.ExecuteNonQuery();
            }
        }
    }
}
