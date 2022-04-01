using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre + " " + Apellido1 + " " + Apellido2;
        }
    }
}
