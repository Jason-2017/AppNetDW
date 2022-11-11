using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Diagnostics;

namespace WebServiceHospital
{
    /// <summary>
    /// Descripción breve de WSHospital
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSHospital : System.Web.Services.WebService
    {
        CapaNegocioBLL.PROVEEDOR gestor = new CapaNegocioBLL.PROVEEDOR();
        CapaNegocioBLL.WS_CONSULTAPROVEEDOR gestor_ws = new CapaNegocioBLL.WS_CONSULTAPROVEEDOR();
        CapaNegocioBLL.WS_CONSULTAAFILIADO gestor_ws_afiliado = new CapaNegocioBLL.WS_CONSULTAAFILIADO();

       [WebMethod(Description = "verificar si el paciente (afiliado al seguro médico) se encuentra activo")]
        public CapaEntidadBE.WS_CONSULTAPROVEEDOR servicioweb_consultaproveedor(string nitProveedor,
                                    string codigoPaciente,
                                    DateTime fechaNacimiento,
                                    DateTime fechaInicioCobertura)
        {
            CapaEntidadBE.WS_CONSULTAPROVEEDOR ws = new CapaEntidadBE.WS_CONSULTAPROVEEDOR();
            var respuesta = gestor.ExisteProveedor(nitProveedor);
            if (respuesta >= 1)
            {
                var responseDB = gestor_ws.consultar(nitProveedor, codigoPaciente, fechaNacimiento, fechaInicioCobertura);
                ws.nitProveedor = responseDB.nitProveedor;
                ws.codigoPacienteConsultado = responseDB.codigoPacienteConsultado;
                ws.fechaCoberturaConsultada = responseDB.fechaCoberturaConsultada;
                ws.respuestaServicioWeb = responseDB.respuestaServicioWeb;
                ws.fechaConsulta = responseDB.fechaConsulta;
                ws.NitValido = 1;
                ws.descNitConsultado = "El nit consultado es valido";
                gestor_ws.registrarTransaccion(ws);
            }
            else
            {
                ws.nitProveedor = nitProveedor;
                ws.codigoPacienteConsultado = codigoPaciente;
                ws.fechaCoberturaConsultada = fechaInicioCobertura;
                ws.fechaConsulta = DateTime.Now;
                ws.NitValido = -1;
                ws.respuestaServicioWeb = String.Empty;
                ws.descNitConsultado = "**** ERROR **** El nit consultado no es valido";
                gestor_ws.registrarTransaccion(ws);
            }
            return ws;
        }

        [WebMethod(Description = "Consulta afiliado")]
        public string servicioweb_consultaafiliado(int codigoPaciente, DateTime fechaNacimiento)
        {
            var response = gestor_ws_afiliado.consultar(codigoPaciente, fechaNacimiento);
            return response;
        }
    }
}
