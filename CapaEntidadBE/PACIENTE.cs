using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadBE
{
    public class PACIENTE
    {
        public int Cod { get; set; }

        public string Primer_nombre { get; set; }

        public string Segundo_nombre { get; set; }

        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        public string Fecha_de_nacimiento { get; set; }

        public string Telefono { get; set; }

        public string Fecha_inicio_cobertura { get; set; }

        public string Monto_de_cobertura { get; set; }

        public string Estado { get; set; }
    }
}
