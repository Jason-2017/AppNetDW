using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadBE
{
    public class PACIENTE
    {
        private int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        private string primer_nombre;
        public string Primer_nombre
        {
            get { return primer_nombre; }
            set { primer_nombre = value; }
        }

        private string segundo_nombre;

        public string Segundo_nombre
        {
            get { return segundo_nombre; }
            set { segundo_nombre = value; }
        }

        private string primer_apellido;
        public string Primer_apellido
        {
            get { return primer_apellido; }
            set { primer_apellido = value; }
        }

        private string segundo_apellido;

        public string Segundo_apellido
        {
            get { return segundo_apellido; }
            set { segundo_apellido = value; }
        }

        private string fecha_de_nacimiento;

        public string Fecha_de_nacimiento
        {
            get { return fecha_de_nacimiento; }
            set { fecha_de_nacimiento = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private string fecha_inicio_cobertura;

        public string Fecha_inicio_cobertura
        {
            get { return fecha_inicio_cobertura; }
            set { fecha_inicio_cobertura = value; }
        }

        private string monto_de_cobertura;

        public string Monto_de_cobertura
        {
            get { return monto_de_cobertura; }
            set { monto_de_cobertura = value; }
        }
    }
}
