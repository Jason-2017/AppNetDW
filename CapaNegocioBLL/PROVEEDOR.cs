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

        public int ExisteProveedor(CapaEntidadBE.PROVEEDOR proveedor) 
        {
            return mp.ExisteProveedor(proveedor);
        }

        public int grabar(CapaEntidadBE.PROVEEDOR proveedor)
        {
            int res;
            res = mp.insertar(proveedor);
            return res;
        }
        
    }
}
