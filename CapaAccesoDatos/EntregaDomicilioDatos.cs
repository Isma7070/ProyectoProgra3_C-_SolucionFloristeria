using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class EntregaDomicilioDatos
    {
        public void Guardar(EntregaDomicilio ent)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarEntregaDomicilio";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@direccionEncargo", ent.DireccionEntrega);
                    comando.Parameters.AddWithValue("@idCliente", ent.IdCliente);
                    if (ent.Autorizacion)
                    {
                        comando.Parameters.AddWithValue("@autorizacion", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@autorizacion", 0);
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

        public EntregaDomicilio SeleccionarPorId(int idEntrega)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarEntregasADomicilioPorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEntrega", idEntrega);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    EntregaDomicilio ent = new EntregaDomicilio();
                    ent.IdEntrega = int.Parse(reader["idEntrega"].ToString());
                    ent.DireccionEntrega = reader["direccionEncargo"].ToString();
                    ent.IdCliente = int.Parse(reader["idCliente"].ToString());
                    if ((bool)reader["autorizacion"])
                    {
                        ent.Autorizacion = true;
                    }
                    else
                    {
                        ent.Autorizacion = false;
                    }
                    return ent;
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


        public void Actualizar(EntregaDomicilio ent)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarEntregaDomicilio";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idEntrega", ent.IdEntrega);
                    comando.Parameters.AddWithValue("@direccionEncargo", ent.DireccionEntrega);
                    comando.Parameters.AddWithValue("@idCliente", ent.IdCliente);
                    if (ent.Autorizacion)
                    {
                        comando.Parameters.AddWithValue("@autorizacion", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@autorizacion", 0);
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

        public List<EntregaDomicilio> SeleccionarEntregas()
        {
            List<EntregaDomicilio> lista = new List<EntregaDomicilio>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarEntregasADomicilio";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    EntregaDomicilio ent = new EntregaDomicilio();
                    ent.IdEntrega = int.Parse(reader["idEntrega"].ToString());
                    ent.DireccionEntrega = reader["direccionEncargo"].ToString();
                    ent.IdCliente = int.Parse(reader["idCliente"].ToString());
                    if ((bool)reader["autorizacion"])
                    {
                        ent.Autorizacion = true;
                    }
                    else
                    {
                        ent.Autorizacion = false;
                    }
                    lista.Add(ent);
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


        public void InsertarProductos(int codigo, int idEncargo, int cantidad)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                //Paso 1.1: Abrir la conexion
                conexion.Open();
                //Paso 2: Definir la instruccion sql que se va a utilizar (nombre del SP)
                string sql = "PA_InsertarEntregaDomicilio_Producto";
                //Paso 3: Definiar un comando que ejecute la instruccion en la conexion
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4: Enviarle los paramentros al comando
                comando.Parameters.AddWithValue("@idProducto", codigo);
                comando.Parameters.AddWithValue("@idEncargo", idEncargo);
                comando.Parameters.AddWithValue("@cantidadProducto", cantidad);
                //Paso 4.1: decirle al comando que es un procedimiento almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                //Paso 5: Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void EliminarMaterial(int codigo, int idEncargo)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                //Paso 1.1: Abrir la conexion
                conexion.Open();
                //Paso 2: Definir la instruccion sql que se va a utilizar (nombre del SP)
                string sql = "PA_EliminarEntregaProducto";
                //Paso 3: Definiar un comando que ejecute la instruccion en la conexion
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4: Enviarle los paramentros al comando
                comando.Parameters.AddWithValue("@idEncargo", idEncargo);
                comando.Parameters.AddWithValue("@idProducto", codigo);

                //Paso 4.1: decirle al comando que es un procedimiento almacenado
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                //Paso 5: Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int CantidadProductoMaterial(int codigo, int idEntrega)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                int cantidad = 0;
                conn.Open();
                string sql = "PA_CantidadProductosPedido";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEntrega", idEntrega);
                comando.Parameters.AddWithValue("@idProducto", codigo);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader["cantidadProducto"].ToString());
                    return cantidad;
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
            return 0;
        }
    }
}
