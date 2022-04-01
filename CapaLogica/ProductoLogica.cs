using CapaEntidadades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ProductoLogica
    {
        public static void Guardar(Producto prod)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                if (datos.SeleccionarPorId(prod.Codigo) == null)
                    datos.Guardar(prod);
                else
                    datos.Actualizar(prod);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Producto> SeleccionarActivos()
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                return datos.SeleccionarActivos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Producto> SeleccionarNoActivos()
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                return datos.SeleccionarInactivos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Producto SeleccionarPorId(int codigo)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                return datos.SeleccionarPorId(codigo);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void AgregarMaterial(Producto prod, Material mat, int cantidad)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                datos.InsertarMaterial(prod.Codigo, mat.IdMaterial, cantidad);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public static void EliminarProveedor(Producto prod, Material mat)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                datos.EliminarMaterial(prod.Codigo, mat.IdMaterial);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public static double CalcularCostoProducto(Producto pro)
        {
            try
            {
                double costo = 0;
                
                ProductoDatos datosPro = new ProductoDatos();
                List<Material> materiales = new List<Material>();
                materiales = MaterialLogica.SeleccionarPorProducto(pro.Codigo);
                foreach (var item in materiales)
                {
                    costo += (item.Precio * datosPro.CantidadProductoMaterial(pro.Codigo, item.IdMaterial));
                }
                return costo;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static List<Producto> SeleccionarDisponibles(int idEncargo)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                var todos = datos.SeleccionarActivos();
                var seleccionados = datos.SeleccionarPorEntrega(idEncargo);
                var disponibles = new List<Producto>();

                foreach (var pro in todos)
                {
                    var p = seleccionados.FirstOrDefault(x => x.Codigo == pro.Codigo);
                    if (p == null)
                    {
                        disponibles.Add(pro);
                    }
                }

                return disponibles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Producto> SeleccionarPorProducto(int idEntrega)
        {
            try
            {
                ProductoDatos datos = new ProductoDatos();
                return datos.SeleccionarPorEntrega(idEntrega);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
