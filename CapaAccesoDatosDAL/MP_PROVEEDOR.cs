using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatosDAL
{
    public class MP_PROVEEDOR
    {
        private Acceso acceso = new Acceso();

        public List<CapaEntidadBE.PROVEEDOR> listar() {
            DataTable tabla = acceso.leer("proveedor", null);
            List<CapaEntidadBE.PROVEEDOR> proveedores = new List<CapaEntidadBE.PROVEEDOR>();

            foreach (DataRow item in tabla.Rows)
            {
                CapaEntidadBE.PROVEEDOR proveedor = new CapaEntidadBE.PROVEEDOR();

                proveedor.idProveedor = int.Parse(item["cod_proveedor"].ToString());
                proveedor.nit = item["nit"].ToString();
                proveedor.nombreRazonSocial = item["nombre"].ToString();
                proveedores.Add(proveedor);
            }
            return proveedores;
        }
    }
}
