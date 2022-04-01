using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ProductoDatos
    {
        public void Guardar(Producto prod)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@codigo", prod.Codigo);
                    comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                    comando.Parameters.AddWithValue("@idCategoria", prod.IdCategoria);
                    if (prod.Activo)
                    {
                        comando.Parameters.AddWithValue("@activo", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@activo", 0);
                    }
                    comando.Parameters.AddWithValue("@precioVenta", prod.PrecioVenta);
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Producto SeleccionarPorId(int codigo)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarProductoPorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Codigo = int.Parse(reader["codigo"].ToString());
                    prod.Nombre = reader["nombre"].ToString();
                    prod.Descripcion = reader["descripcion"].ToString();
                    prod.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    if ((bool)reader["activo"])
                    {
                        prod.Activo = true;
                    }
                    else
                    {
                        prod.Activo = false;
                    }
                    prod.PrecioVenta = int.Parse(reader["precioVenta"].ToString());
                    return prod;
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


        public void Actualizar(Producto prod)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@codigo", prod.Codigo);
                    comando.Parameters.AddWithValue("@nombre", prod.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", prod.Descripcion);
                    comando.Parameters.AddWithValue("@idCategoria", prod.IdCategoria);
                    if (prod.Activo)
                    {
                        comando.Parameters.AddWithValue("@activo", 1);
                    }
                    else
                    {
                        comando.Parameters.AddWithValue("@activo", 0);
                    }
                    comando.Parameters.AddWithValue("@precioVenta", prod.PrecioVenta);
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Producto> SeleccionarActivos()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarProductosActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Codigo = int.Parse(reader["codigo"].ToString());
                    prod.Nombre = reader["nombre"].ToString();
                    prod.Descripcion = reader["descripcion"].ToString();
                    prod.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    if ((bool)reader["activo"])
                    {
                        prod.Activo = true;
                    }
                    else
                    {
                        prod.Activo = false;
                    }
                    prod.PrecioVenta = int.Parse(reader["precioVenta"].ToString());
                    lista.Add(prod);
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



        public List<Producto> SeleccionarInactivos()
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarProductosNoActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Codigo = int.Parse(reader["codigo"].ToString());
                    prod.Nombre = reader["nombre"].ToString();
                    prod.Descripcion = reader["descripcion"].ToString();
                    prod.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    if ((bool)reader["activo"])
                    {
                        prod.Activo = true;
                    }
                    else
                    {
                        prod.Activo = false;
                    }
                    prod.PrecioVenta = int.Parse(reader["precioVenta"].ToString());
                    lista.Add(prod);
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

        public void InsertarMaterial(int codigo, int idMaterial, int cantidad)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                //Paso 1.1: Abrir la conexion
                conexion.Open();
                //Paso 2: Definir la instruccion sql que se va a utilizar (nombre del SP)
                string sql = "PA_InsertarProductoMaterial";
                //Paso 3: Definiar un comando que ejecute la instruccion en la conexion
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4: Enviarle los paramentros al comando
                comando.Parameters.AddWithValue("@idProducto", codigo);
                comando.Parameters.AddWithValue("@idMaterial", idMaterial);
                comando.Parameters.AddWithValue("@cantidad", cantidad);
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

        public void EliminarMaterial(int codigo, int idMaterial)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                //Paso 1.1: Abrir la conexion
                conexion.Open();
                //Paso 2: Definir la instruccion sql que se va a utilizar (nombre del SP)
                string sql = "PA_EliminarProductoMaterial";
                //Paso 3: Definiar un comando que ejecute la instruccion en la conexion
                SqlCommand comando = new SqlCommand(sql, conexion);
                //Paso 4: Enviarle los paramentros al comando
                comando.Parameters.AddWithValue("@idProducto", codigo);
                comando.Parameters.AddWithValue("@idMaterial", idMaterial);

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

        public int CantidadProductoMaterial(int codigo, int idMaterial)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                int cantidad = 0;
                conn.Open();
                string sql = "PA_CantidadProductoMaterial";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@idMaterial", idMaterial);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    cantidad = int.Parse(reader["cantidad"].ToString());
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


        public List<Producto> SeleccionarPorEntrega(int idEntrega)
        {
            List<Producto> lista = new List<Producto>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarProductosPorEncargo";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idEncargo", idEntrega);
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Producto prod = new Producto();
                    prod.Codigo = int.Parse(reader["codigo"].ToString());
                    prod.Nombre = reader["nombre"].ToString();
                    prod.Descripcion = reader["descripcion"].ToString();
                    prod.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    if ((bool)reader["activo"])
                    {
                        prod.Activo = true;
                    }
                    else
                    {
                        prod.Activo = false;
                    }
                    prod.PrecioVenta = int.Parse(reader["precioVenta"].ToString());
                    lista.Add(prod);
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
