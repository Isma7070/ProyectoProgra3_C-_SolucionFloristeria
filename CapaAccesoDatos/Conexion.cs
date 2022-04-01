using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos

{
    public class Conexion
    {
        public static string Cadena
        {
            get
            {
                // Llamar a la clase encargada de obtener los
                // valores del app.config
                // Se debe agregar la referencia System.Configuration
                // Y agregrar el using System.Configuration;
                string name = "CapaUI.Properties.Settings.SqlServer";
                return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
        }
    }
}

