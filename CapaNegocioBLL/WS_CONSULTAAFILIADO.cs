using CapaAccesoDatosDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioBLL
{
    public class WS_CONSULTAAFILIADO
    {
        private Acceso acceso = new Acceso();

        public string consultar(int codigoPaciente, DateTime fechaNacimiento)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pcpac", codigoPaciente));
            parameters.Add(acceso.crearParamentro("@pfnac", fechaNacimiento));

            return acceso.consultarWS2("WS_CONSULTAAFILIADO", parameters);
        }
    }
}
