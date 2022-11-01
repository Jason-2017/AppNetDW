using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatosDAL
{
    public class Acceso
    {
        private SqlConnection conexion;
        private void abrir()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-1PIKBKT; Initial Catalog=MiBuenSeguro; Integrated Security=SSPI;");
            conexion.Open();
        }
        private void cerrar()
        {
            conexion.Close();
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string nombre, List<SqlParameter> parametros = null)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandText = nombre;
            comando.CommandType = CommandType.StoredProcedure;

            if (parametros != null && parametros.Count > 0)
            {
                comando.Parameters.AddRange(parametros.ToArray());
            }

            return comando;

        }

        public DataTable leer(string nombre, List<SqlParameter> parametros = null)
        {
            abrir();

            DataTable tabla = new DataTable();
            SqlDataAdapter adapatador = new SqlDataAdapter();

            adapatador.SelectCommand = CrearComando(nombre, parametros);

            adapatador.Fill(tabla);

            adapatador = null;
            cerrar();
            return tabla;
        }

        public int ecribir(string nombre, List<SqlParameter> paramentros)
        {
            int filasAfectadas = 0;
            abrir();
            SqlCommand comando = CrearComando(nombre, paramentros);
            try
            {
                filasAfectadas = comando.ExecuteNonQuery();
            }
            catch
            {
                filasAfectadas = -1;
            }
            cerrar();
            return filasAfectadas;
        }

        public SqlParameter crearParamentro(string nombre, string valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.String;
            return parametro;
        }



        public SqlParameter crearParamentro(string nombre, int valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Int32;
            return parametro;
        }
    }
}
