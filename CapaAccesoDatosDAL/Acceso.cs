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
            var res = Convert.ToInt32(command.ExecuteScalar());
            cerrar();
            return res ;
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                //filasAfectadas = -1;
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

        public SqlParameter crearParamentro(string nombre, DateTime valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Value = valor;
            parametro.DbType = DbType.Date;
            return parametro;
        }
        public CapaEntidadBE.WS_CONSULTAPROVEEDOR consultarWS1(string nombre, List<SqlParameter> parametros = null) {

            CapaEntidadBE.WS_CONSULTAPROVEEDOR obj = new CapaEntidadBE.WS_CONSULTAPROVEEDOR();
            abrir();
            var command = CrearComando(nombre, parametros);
            SqlDataReader reader = command.ExecuteReader();
            //Debug.WriteLine(reader);
            int count = reader.FieldCount;
            //while (reader.Read())
            //{
            //    for (int i = 0; i < count; i++)
            //    {
            //        Debug.WriteLine(reader.GetValue(i));
            //    }
            //}

            reader.Read();
            obj.nitProveedor = reader.GetValue(0).ToString();
            obj.codigoPacienteConsultado = reader.GetValue(1).ToString();
            obj.fechaCoberturaConsultada = Convert.ToDateTime(reader.GetValue(2));
            obj.respuestaServicioWeb = reader.GetValue(3).ToString();
            obj.fechaConsulta =  Convert.ToDateTime(reader.GetValue(4));
            cerrar();
            return obj;
        }

        public string consultarWS2(string nombre, List<SqlParameter> parametros = null) {
            abrir();
            var command = CrearComando(nombre, parametros);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            string response = reader.GetString(0);
            cerrar();

            return response;
        }

    }
}
