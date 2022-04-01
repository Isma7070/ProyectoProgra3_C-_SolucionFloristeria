using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class MaterialDatos
    {
        public void GuardarMaterial(Material mat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_InsertarMaterial";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idMaterial", mat.IdMaterial);
                    comando.Parameters.AddWithValue("@descripcion", mat.Descripcion);
                    comando.Parameters.AddWithValue("@precio", mat.Precio);
                    comando.Parameters.AddWithValue("@stock", mat.Stock);
                    comando.Parameters.AddWithValue("@idProveedor", mat.IdProveedor);
                    comando.Parameters.AddWithValue("@minimoStockPermitido", mat.MinimoEnStock);
                    if (mat.Activo)
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

        public Material SeleccionarPorId(int idMaterial)
        {
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                string sql = "PA_SeleccionarMaterialPorId";
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idMaterial", idMaterial);

                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Material mat = new Material();
                    mat.IdMaterial = int.Parse(reader["idMaterial"].ToString());
                    mat.Descripcion = reader["descripcion"].ToString();
                    mat.Precio = double.Parse(reader["precio"].ToString());
                    mat.Stock = int.Parse(reader["stock"].ToString());
                    mat.IdProveedor = int.Parse(reader["idProveedor"].ToString());
                    mat.MinimoEnStock = int.Parse(reader["minimoStockPermitido"].ToString());
                    if ((bool)reader["activo"])
                    {
                        mat.Activo = true;
                    }
                    else
                    {
                        mat.Activo = false;
                    }

                    return mat;
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


        public void Actualizar(Material mat)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    string sql = "PA_ActualizarMaterial";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idMaterial", mat.IdMaterial);
                    comando.Parameters.AddWithValue("@descripcion", mat.Descripcion);
                    comando.Parameters.AddWithValue("@precio", mat.Precio);
                    comando.Parameters.AddWithValue("@stock", mat.Stock);
                    comando.Parameters.AddWithValue("@idProveedor", mat.IdProveedor);
                    comando.Parameters.AddWithValue("@minimoStockPermitido", mat.MinimoEnStock);
                    if (mat.Activo)
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

        public List<Material> SeleccionarActivos()
        {
            List<Material> lista = new List<Material>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarMaterialesActivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Material mat = new Material();
                    mat.IdMaterial = int.Parse(reader["idMaterial"].ToString());
                    mat.Descripcion = reader["descripcion"].ToString();
                    mat.Precio = double.Parse(reader["precio"].ToString());
                    mat.Stock = int.Parse(reader["stock"].ToString());
                    mat.IdProveedor = int.Parse(reader["idProveedor"].ToString());
                    mat.MinimoEnStock = int.Parse(reader["minimoStockPermitido"].ToString());
                    if ((bool)reader["activo"])
                    {
                        mat.Activo = true;
                    }
                    else
                    {
                        mat.Activo = false;
                    }
                    lista.Add(mat);
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



        public List<Material> SeleccionarInactivos()
        {
            List<Material> lista = new List<Material>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarMaterialesInactivos";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Material mat = new Material();
                    mat.IdMaterial = int.Parse(reader["idMaterial"].ToString());
                    mat.Descripcion = reader["descripcion"].ToString();
                    mat.Precio = double.Parse(reader["precio"].ToString());
                    mat.Stock = int.Parse(reader["stock"].ToString());
                    mat.IdProveedor = int.Parse(reader["idProveedor"].ToString());
                    mat.MinimoEnStock = int.Parse(reader["minimoStockPermitido"].ToString());
                    if ((bool)reader["activo"])
                    {
                        mat.Activo = true;
                    }
                    else
                    {
                        mat.Activo = false;
                    }
                    lista.Add(mat);
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

        public List<Material> SeleccionarPorProducto(int codigo)
        {
            List<Material> lista = new List<Material>();
            SqlConnection conn = new SqlConnection(Conexion.Cadena);
            try
            {
                conn.Open();
                // Paso 2: crear la instruccion sql 
                string sql = "PA_SeleccionarPorProducto";
                // Paso 3: crear un objeto para ejecutar el sql
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codigo", codigo);
                // Ejecutar comando con Consulta
                SqlDataReader reader = comando.ExecuteReader();
                // El reader retorna un conjunto de tuplas
                while (reader.Read())
                {
                    Material mat = new Material();
                    mat.IdMaterial = int.Parse(reader["idMaterial"].ToString());
                    mat.Descripcion = reader["descripcion"].ToString();
                    mat.Precio = double.Parse(reader["precio"].ToString());
                    mat.Stock = int.Parse(reader["stock"].ToString());
                    mat.IdProveedor = int.Parse(reader["idProveedor"].ToString());
                    mat.MinimoEnStock = int.Parse(reader["minimoStockPermitido"].ToString());
                    if ((bool)reader["activo"])
                    {
                        mat.Activo = true;
                    }
                    else
                    {
                        mat.Activo = false;
                    }
                    lista.Add(mat);
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
