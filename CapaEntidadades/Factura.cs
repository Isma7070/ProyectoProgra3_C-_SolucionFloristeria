using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaHora { get; set; }
        public int IdUsuario { get; set; }
        public int IdCliente { get; set; }
        public int IdEntregaDomicilio { get; set; }
        public int TipoPago { get; set; }
        public double SubTotal { get; set; }
        public float IVA { get; set; }
        public double Total { get; set; }
        public double Vuelto { get; set; }
        public bool Anulacion { get; set; }
    }
}
