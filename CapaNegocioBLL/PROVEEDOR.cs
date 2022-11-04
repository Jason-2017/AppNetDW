using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioBLL
{
    public class PROVEEDOR
    {
        CapaAccesoDatosDAL.MP_PROVEEDOR mp = new CapaAccesoDatosDAL.MP_PROVEEDOR();
        public List<CapaEntidadBE.PROVEEDOR> listar() {
            return mp.listar();
        }
    }
}
