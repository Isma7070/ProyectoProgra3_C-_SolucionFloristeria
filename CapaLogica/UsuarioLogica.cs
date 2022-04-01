using CapaAccesoDatos;
using CapaEntidadades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class UsuarioLogica
    {

        public static void GuardarUsuario(Usuario usu)
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                datos.GuardarUsuario(usu);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario ComprobarClaveValida(int numeroUsuario, string calve)
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                Usuario usu = datos.ObtenerUsuario(numeroUsuario);
                bool valido = false;

                if (usu != null)
                {
                    byte[] hashedPassword = CapaLogica.Seguridad.Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(calve), usu.Salt);

                    if (hashedPassword.SequenceEqual(usu.Clave))
                        valido = true;
                }
                if (valido)
                {
                    return usu;
                }else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static int ObtenerUltimoNumeroUsuario()
        {
            try
            {
                UsuarioDatos datos = new UsuarioDatos();
                return datos.ObtenerUltimoNumeroUsuario();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
