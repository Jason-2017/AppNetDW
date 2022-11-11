using CapaAccesoDatosDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioBLL
{
    public class WS_CONSULTAPROVEEDOR
    {
        CapaAccesoDatosDAL.MP_WS_CONSULTAPROVEEDOR mp = new CapaAccesoDatosDAL.MP_WS_CONSULTAPROVEEDOR();
        private Acceso acceso = new Acceso();

        public CapaEntidadBE.WS_CONSULTAPROVEEDOR consultar(string nitProveedor,
                                    string codigoPaciente,
                                    DateTime fechaNacimiento,
                                    DateTime fechaInicioCobertura)
        {
            return mp.consultar(nitProveedor, codigoPaciente, fechaNacimiento, fechaInicioCobertura);
        }

        public int registrarTransaccion(CapaEntidadBE.WS_CONSULTAPROVEEDOR ws)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pnitp", ws.nitProveedor));
            parameters.Add(acceso.crearParamentro("@pcpac", ws.codigoPacienteConsultado));
            parameters.Add(acceso.crearParamentro("pfcco", ws.fechaCoberturaConsultada));
            parameters.Add(acceso.crearParamentro("@pfrws", ws.respuestaServicioWeb));
            parameters.Add(acceso.crearParamentro("@descNitConsultado", ws.descNitConsultado));

            return acceso.ecribir("REGISTRAR_LOG", parameters);
        }
    }
}
