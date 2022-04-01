using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class CategoriaProductoDatos 
    {
        public void Guardar(CategoriaProducto pro)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarCategoriaProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombre", pro.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", pro.Descripcion);
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public CategoriaProducto SeleccionarPorId(int idCategoria)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarCategoriaProductoPorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    CategoriaProducto categoria = new CategoriaProducto();
                    categoria.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    categoria.Nombre = reader["nombre"].ToString();
                    categoria.Descripcion = reader["descripcion"].ToString();

                    return categoria;
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


        public void Actualizar(CategoriaProducto cat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarCategoriaProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idCategoria", cat.IdCategoria);
                    comando.Parameters.AddWithValue("@nombre", cat.Nombre);
                    comando.Parameters.AddWithValue("@descripcion", cat.Descripcion);
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<CategoriaProducto> SeleccionarTodo()
        {
            List<CategoriaProducto> lista = new List<CategoriaProducto>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarCategoriasProducto";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    CategoriaProducto cat = new CategoriaProducto();
                    cat.IdCategoria = int.Parse(reader["idCategoria"].ToString());
                    cat.Nombre = reader["nombre"].ToString();
                    cat.Descripcion = reader["descripcion"].ToString();
                    lista.Add(cat);
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


        public void Eliminar(int id)
        {
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);
            try
            {
                conexion.Open();
                string sql = "PA_EliminarCategoriaProducto";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCategoria", id);
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
    }
}
