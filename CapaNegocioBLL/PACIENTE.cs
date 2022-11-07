using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocioBLL
{
    public class PACIENTE
    {
        CapaAccesoDatosDAL.MP_PACIENTE mp = new CapaAccesoDatosDAL.MP_PACIENTE();

        public int grabar(CapaEntidadBE.PACIENTE paciente)
        {
            int res = 0;
            if (paciente.Cod == 0)
            {
                res = mp.insertar(paciente);
            }
            else
            {
                res = mp.editar(paciente);
            }
            return res;
        }

        public int insertar(CapaEntidadBE.PACIENTE paciente)
        {

            return mp.insertar(paciente);

        }

        public int editar(CapaEntidadBE.PACIENTE paciente)
        {

            return mp.editar(paciente);

        }

        public int borrar(CapaEntidadBE.PACIENTE paciente)
        {
            return mp.borrar(paciente);
        }

        public List<CapaEntidadBE.PACIENTE> listar()
        {
            return mp.listar();
        }

        public CapaEntidadBE.PACIENTE listar(int id)
        {
            return mp.listar(id);
        }
    }
}
