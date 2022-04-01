using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ImagenProductoDatos
    {
        public void Guardar(ImagenProducto image)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarImagenProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idProducto", image.IdProducto);
                    comando.Parameters.AddWithValue("@idImagen", image.IdImagen);
                    comando.Parameters.AddWithValue("@logo", image.Foto);
                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Eliminar(int idProducto, int idImagen)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_EliminarImagenProducto";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idProducto", idProducto);
                    comando.Parameters.AddWithValue("@idImagen", idImagen);

                    // Ejecutar comando Sin Consulta
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ImagenProducto> SeleccionarPorProducto(int idProducto)
        {
            List<ImagenProducto> lista = new List<ImagenProducto>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarImagenesPorProducto";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", idProducto);
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    ImagenProducto image = new ImagenProducto();
                    image.IdProducto = int.Parse(reader["idProducto"].ToString());
                    image.IdImagen = int.Parse(reader["idImagen"].ToString());
                    image.Foto = (byte[])reader["logo"];


                    lista.Add(image);
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
