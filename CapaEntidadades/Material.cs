using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadades
{
    public class Material
    {
        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int IdProveedor { get; set; }
        public int MinimoEnStock { get; set; }
        public bool Activo { get; set; }
    }
}
