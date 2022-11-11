using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatosDAL
{
    public class MP_WS_CONSULTAPROVEEDOR
    {
        private Acceso acceso = new Acceso();
        public CapaEntidadBE.WS_CONSULTAPROVEEDOR consultar(string nitProveedor,
                                    string codigoPaciente,
                                    DateTime fechaNacimiento,
                                    DateTime fechaInicioCobertura)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pnitproveedor", nitProveedor));
            parameters.Add(acceso.crearParamentro("@pcodpaciente", codigoPaciente));
            parameters.Add(acceso.crearParamentro("@pfechanacimiento", fechaNacimiento));
            parameters.Add(acceso.crearParamentro("@pfechainiciocobertura", fechaInicioCobertura));

            return acceso.consultarWS1("WS_CONSULTAPROVEEDOR", parameters);
        }
    }
}
