using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CapaAccesoDatosDAL
{
    public class Acceso
    {
        private SqlConnection conexion;
        private void abrir()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.DataSource = "sqlumgdw.database.windows.net";
            builder.UserID = "sqlumgdw";
            builder.Password = "D3sarr0llo2022";
            builder.InitialCatalog = "DB_MIBUENSEGURO";

            //conexion = new SqlConnection("Data Source=sqlumgdw.database.windows.net; Initial Catalog=DB_MIBUENSEGURO; Integrated Security=SSPI;");
            conexion = new SqlConnection(builder.ConnectionString);
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

        public int ExistePaciente_Proveedor(string nombre, List<SqlParameter> parametros = null)
        {
            abrir();
            var command = CrearComando(nombre, parametros);
            return Convert.ToInt32(command.ExecuteScalar());
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
