using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadBE
{
    public class WS_CONSULTAPROVEEDOR
    {
        public string nitProveedor { get; set; }
        public string codigoPacienteConsultado { get; set; }
        public DateTime fechaCoberturaConsultada { get; set; }
        public string respuestaServicioWeb { get; set; }
        public DateTime fechaConsulta { get; set; }
        public int NitValido { get; set; }
        public string descNitConsultado { get; set; }
    }
}
