using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ClienteDatos
    {
        public void GuardarCliente(Cliente cli)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarCliente";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idCliente", cli.IdCliente);
                    comando.Parameters.AddWithValue("@nombre", cli.Nombre);
                    comando.Parameters.AddWithValue("@apellido1", cli.Apellido1);
                    comando.Parameters.AddWithValue("@apellido2", cli.Apellido2);
                    comando.Parameters.AddWithValue("@email", cli.Email);
                    comando.Parameters.AddWithValue("@direccion", cli.Direccion);
                    if (cli.Activo)
                    {
                        comando.Parameters.AddWithValue("@activo", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@activo", 0);
                    }
                    
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Cliente SeleccionarPorId(int idCliente)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarClientePorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = (int)reader["idCliente"];
                    cli.Nombre = reader["nombre"].ToString();
                    cli.Apellido1 = reader["apellido1"].ToString();
                    cli.Apellido2 = reader["apellido2"].ToString();
                    cli.Email = reader["email"].ToString();
                    cli.Direccion = reader["direccion"].ToString();
                    if ((bool)reader["activo"])
                    {
                        cli.Activo = true;
                    }else
                    {
                        cli.Activo = false;
                    }
                    
                    return cli;
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


        public void ActualizarCliente(Cliente cli)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarCliente";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idCliente", cli.IdCliente);
                    comando.Parameters.AddWithValue("@nombre", cli.Nombre);
                    comando.Parameters.AddWithValue("@apellido1", cli.Apellido1);
                    comando.Parameters.AddWithValue("@apellido2", cli.Apellido2);
                    comando.Parameters.AddWithValue("@email", cli.Email);
                    comando.Parameters.AddWithValue("@direccion", cli.Direccion);
                    if (cli.Activo)
                    {
                        comando.Parameters.AddWithValue("@activo", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@activo", 0);
                    }

                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Cliente> SeleccionarClienteActivos()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarClientesActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = (int)reader["idCliente"];
                    cli.Nombre = reader["nombre"].ToString();
                    cli.Apellido1 = reader["apellido1"].ToString();
                    cli.Apellido2 = reader["apellido2"].ToString();
                    cli.Email = reader["email"].ToString();
                    cli.Direccion = reader["direccion"].ToString();
                    if ((bool)reader["activo"])
                    {
                        cli.Activo = true;
                    }
                    else
                    {
                        cli.Activo = false;
                    }
                    lista.Add(cli);
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

            return lista;
        }



        public List<Cliente> SeleccionarClientesInactivos()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarClientesNoActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Cliente cli = new Cliente();
                    cli.IdCliente = (int)reader["idCliente"];
                    cli.Nombre = reader["nombre"].ToString();
                    cli.Apellido1 = reader["apellido1"].ToString();
                    cli.Apellido2 = reader["apellido2"].ToString();
                    cli.Email = reader["email"].ToString();
                    cli.Direccion = reader["direccion"].ToString();
                    if ((bool)reader["activo"])
                    {
                        cli.Activo = true;
                    }
                    else
                    {
                        cli.Activo = false;
                    }
                    lista.Add(cli);
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

            return lista;
        }
    }
}
