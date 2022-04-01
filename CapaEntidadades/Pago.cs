using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Pago
    {
        public int IdPago { get; set; }
        public char TipoPago { get; set; }
        public double Importe { get; set; }
        public int NumeroAutorizacionTarjetaCompra { get; set; }
        public int NumeroTransaccionDeposito { get; set; }
    }
}
