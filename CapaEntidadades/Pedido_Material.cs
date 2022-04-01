using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Pedido_Material
    {
        public int IdPedido { get; set; }
        public int IdProveedor { get; set; }
        public int idMaterial { get; set; }
        public int Cantidad { get; set; }

    }
}
