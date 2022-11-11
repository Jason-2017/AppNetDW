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

        public int actualizar(CapaEntidadBE.PROVEEDOR proveedor) 
        {
            int res;
            res = mp.actualizar(proveedor);
            return res;
        }

        public int eliminar(int idProveedor)
        {
            int res;
            res = mp.eliminar(idProveedor);
            return res;
        }

        public int ExisteProveedor(string nit) 
        {
            int res;
            res = mp.ExisteProveedor(nit);
            return res;
        }
        
    }
}
