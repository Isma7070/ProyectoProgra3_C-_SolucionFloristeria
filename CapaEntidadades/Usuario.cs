using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPuesto { get; set; }
        public int IdEmpleado { get; set; }
        public byte[] Clave { get; set; }
        public byte[] Salt { get; set; }
    }
}
