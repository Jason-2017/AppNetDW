using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatosDAL
{
    public class MP_PACIENTE
    {
        private Acceso acceso = new Acceso();


        public List<CapaEntidadBE.PACIENTE> listar()
        {
            DataTable tabla = acceso.leer("paciente_listar", null);
            List<CapaEntidadBE.PACIENTE> pacientes = new List<CapaEntidadBE.PACIENTE>();

            foreach (DataRow registro in tabla.Rows)
            {
                CapaEntidadBE.PACIENTE paciente = new CapaEntidadBE.PACIENTE();

                paciente.Cod = int.Parse(registro["cod_paciente"].ToString());
                paciente.Primer_nombre = registro["primer_nombre"].ToString();
                paciente.Segundo_nombre = registro["segundo_nombre"].ToString();
                paciente.Primer_apellido = registro["primer_apellido"].ToString();
                paciente.Segundo_apellido = registro["segundo_apellido"].ToString();
                paciente.Fecha_de_nacimiento = registro["fecha_de_nacimiento"].ToString();
                paciente.Telefono = registro["telefono"].ToString();
                paciente.Fecha_inicio_cobertura = registro["fecha_inicio_cobertura"].ToString();
                paciente.Monto_de_cobertura = registro["monto_de_cobertura"].ToString();
                paciente.Estado = registro["estado"].ToString();
                pacientes.Add(paciente);
            }

            return pacientes;
        }

        public CapaEntidadBE.PACIENTE listar(int ID)
        {
            DataTable tabla = acceso.leer("paciente_listar", null);
            CapaEntidadBE.PACIENTE paciente = new CapaEntidadBE.PACIENTE();
            DataRow registro = tabla.Rows[0];

            paciente.Cod = int.Parse(registro["cod_paciente"].ToString());
            paciente.Primer_nombre = registro["primer_nombre"].ToString();
            paciente.Segundo_nombre = registro["segundo_nombre"].ToString();
            paciente.Primer_apellido = registro["primer_apellido"].ToString();
            paciente.Segundo_apellido = registro["segundo_apellido"].ToString();
            paciente.Fecha_de_nacimiento = registro["fecha_de_nacimiento"].ToString();
            paciente.Telefono = registro["telefono"].ToString();
            paciente.Fecha_inicio_cobertura = registro["fecha_inicio_cobertura"].ToString();
            paciente.Monto_de_cobertura = registro["monto_de_cobertura"].ToString();
            paciente.Estado = registro["estado"].ToString();
            return paciente;
        }


        public int insertar(CapaEntidadBE.PACIENTE paciente)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();


            parameters.Add(acceso.crearParamentro("@pnom", paciente.Primer_nombre));
            parameters.Add(acceso.crearParamentro("@snom", paciente.Segundo_nombre));
            parameters.Add(acceso.crearParamentro("@pape", paciente.Primer_apellido));
            parameters.Add(acceso.crearParamentro("@sape", paciente.Segundo_apellido));
            parameters.Add(acceso.crearParamentro("@fe_n", paciente.Fecha_de_nacimiento));
            parameters.Add(acceso.crearParamentro("@tel", paciente.Telefono));
            parameters.Add(acceso.crearParamentro("@fe_i_c", paciente.Fecha_inicio_cobertura));
            parameters.Add(acceso.crearParamentro("@mon", paciente.Monto_de_cobertura));
            parameters.Add(acceso.crearParamentro("@est", paciente.Estado));
            return acceso.ecribir("paciente_insertar", parameters);

        }

        public int editar(CapaEntidadBE.PACIENTE paciente)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@cod", paciente.Cod));
            parameters.Add(acceso.crearParamentro("@snom", paciente.Segundo_nombre));
            parameters.Add(acceso.crearParamentro("@pape", paciente.Primer_apellido));
            parameters.Add(acceso.crearParamentro("@sape", paciente.Segundo_apellido));
            parameters.Add(acceso.crearParamentro("@fe_n", paciente.Fecha_de_nacimiento));
            parameters.Add(acceso.crearParamentro("@tel", paciente.Telefono));
            parameters.Add(acceso.crearParamentro("@fe_i_c", paciente.Fecha_inicio_cobertura));
            parameters.Add(acceso.crearParamentro("@mon", paciente.Monto_de_cobertura));
            parameters.Add(acceso.crearParamentro("@est", paciente.Estado));
            return acceso.ecribir("paciente_editar", parameters);
        }

        public int borrar(CapaEntidadBE.PACIENTE paciente)
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(acceso.crearParamentro("@cod", paciente.Cod));

            return acceso.ecribir("paciente_eliminar", parameters);
        }
    }
}
