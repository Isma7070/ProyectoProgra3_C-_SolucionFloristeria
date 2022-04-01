using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Empresa
    {
        public int idCedulaJuridica { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int NumeroTelefono { get; set; }
        public string EmailAtencionCliente { get; set; }
        public byte[] Logo { get; set; }
        public string IBAN { get; set; }
    }
}
