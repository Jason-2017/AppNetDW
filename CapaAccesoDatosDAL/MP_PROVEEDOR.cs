using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatosDAL
{
    public class MP_PROVEEDOR
    {
        private Acceso acceso = new Acceso();

        public List<CapaEntidadBE.PROVEEDOR> listar() {
            DataTable tabla = acceso.leer("LISTAR_PROVEEDORES", null);
            List<CapaEntidadBE.PROVEEDOR> proveedores = new List<CapaEntidadBE.PROVEEDOR>();

            foreach (DataRow item in tabla.Rows)
            {
                CapaEntidadBE.PROVEEDOR proveedor = new CapaEntidadBE.PROVEEDOR();

                proveedor.idProveedor = int.Parse(item["cod_proveedor"].ToString());
                proveedor.nit = item["nit"].ToString();
                proveedor.nombreRazonSocial = item["nombre"].ToString();
                proveedor.estado = item["estado"].ToString();
                proveedores.Add(proveedor);
            }
            return proveedores;
        }

        public int insertar(CapaEntidadBE.PROVEEDOR proveedor)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pnit", proveedor.nit));
            parameters.Add(acceso.crearParamentro("@pnombre", proveedor.nombreRazonSocial));
            parameters.Add(acceso.crearParamentro("@pestado", "Activo"));

            return acceso.ecribir("INSERTAR_PROVEEDOR", parameters);
        }

        public int ExisteProveedor(CapaEntidadBE.PROVEEDOR proveedor)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pnit", proveedor.nit));
            parameters.Add(acceso.crearParamentro("@pnombre", proveedor.nombreRazonSocial));

            return acceso.ExistePaciente_Proveedor("VERIFICAR_PROVEEDOR", parameters);
        }

        public int actualizar(CapaEntidadBE.PROVEEDOR proveedor) 
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pidproveedor", proveedor.idProveedor));
            parameters.Add(acceso.crearParamentro("@pnit", proveedor.nit));
            parameters.Add(acceso.crearParamentro("@pnombre", proveedor.nombreRazonSocial));
            parameters.Add(acceso.crearParamentro("@pestado", proveedor.estado));

            return acceso.ecribir("ACTUALIZAR_PROVEEDOR", parameters);
        }

        public int eliminar(int idProveedor)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@pidproveedor", idProveedor));

            return acceso.ecribir("ELIMINAR_PROVEEDOR", parameters);
        }
    }
}
