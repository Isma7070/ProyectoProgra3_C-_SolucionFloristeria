using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ProveedorDatos
    {
        public void Guardar(Proveedor prov)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarProveedor";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idProveedor", prov.idProveedor);
                    comando.Parameters.AddWithValue("@nombre", prov.Nombre);
                    comando.Parameters.AddWithValue("@direccion", prov.Direccion);
                    comando.Parameters.AddWithValue("@email", prov.Email);
                    if (prov.Activo)
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

        public Proveedor SeleccionarPorId(int idProveedor)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarProveedorPorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Proveedor prov = new Proveedor();
                    prov.idProveedor = int.Parse(reader["idProveedor"].ToString());
                    prov.Nombre = reader["nombre"].ToString();
                    prov.Direccion = reader["direccion"].ToString();
                    prov.Email = reader["email"].ToString();
                    if ((bool)reader["activo"])
                    {
                        prov.Activo = true;
                    }
                    else
                    {
                        prov.Activo = false;
                    }

                    return prov;
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


        public void Actualizar(Proveedor prov)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarProveedor";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idProveedor", prov.idProveedor);
                    comando.Parameters.AddWithValue("@nombre", prov.Nombre);
                    comando.Parameters.AddWithValue("@direccion", prov.Direccion);
                    comando.Parameters.AddWithValue("@email", prov.Email);
                    if (prov.Activo)
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

        public List<Proveedor> SeleccionarActivos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarProveedoresActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Proveedor prov = new Proveedor();
                    prov.idProveedor = int.Parse(reader["idProveedor"].ToString());
                    prov.Nombre = reader["nombre"].ToString();
                    prov.Direccion = reader["direccion"].ToString();
                    prov.Email = reader["email"].ToString();
                    if ((bool)reader["activo"])
                    {
                        prov.Activo = true;
                    }
                    else
                    {
                        prov.Activo = false;
                    }
                    lista.Add(prov);
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



        public List<Proveedor> SeleccionarInactivos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarProveedoresInactivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Proveedor prov = new Proveedor();
                    prov.idProveedor = int.Parse(reader["idProveedor"].ToString());
                    prov.Nombre = reader["nombre"].ToString();
                    prov.Direccion = reader["direccion"].ToString();
                    prov.Email = reader["email"].ToString();
                    if ((bool)reader["activo"])
                    {
                            prov.Activo = true;
                    }
                        else
                        {
                            prov.Activo = false;
                        }
                        lista.Add(prov);
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
