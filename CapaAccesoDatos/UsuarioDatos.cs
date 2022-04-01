using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class UsuarioDatos
    {
        public void GuardarUsuario(Usuario usu)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarUsuario";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idPuesto", usu.IdPuesto);
                    comando.Parameters.AddWithValue("@idEmpleado", usu.IdEmpleado);
                    comando.Parameters.AddWithValue("@clave", SqlDbType.VarBinary).Value = usu.Clave;
                    comando.Parameters.AddWithValue("@salt", SqlDbType.VarBinary).Value = usu.Salt;
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        public Usuario ObtenerUsuario(int numeroUsuario)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarUsuario";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idUsuario", numeroUsuario);
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Usuario usu = new Usuario();
                    usu.IdUsuario = (int)reader["idUsuario"];
                    usu.IdPuesto = (int)reader["idPuesto"];
                    usu.IdEmpleado = (int)reader["idEmpleado"];
                    usu.Salt = (byte[])reader["salt"];
                    usu.Clave = (byte[])reader["clave"];
                    return usu;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public int ObtenerUltimoNumeroUsuario()
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_ObtenerUltimoNumeroUsuario";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    int numeroUsuario = int.Parse(reader["numero"].ToString());
                    return numeroUsuario;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return 1;
        }
    }
}
