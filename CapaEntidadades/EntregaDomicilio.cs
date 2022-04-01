using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class EntregaDomicilio
    {
        public int IdEntrega { get; set; }
        public string DireccionEntrega { get; set; }
        public int IdCliente { get; set; }
        public bool Autorizacion { get; set; }

    }
}
