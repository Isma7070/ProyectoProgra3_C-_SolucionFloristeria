using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Reporte
    {
        public int IdReporte { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdUsuario { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
    }
}
