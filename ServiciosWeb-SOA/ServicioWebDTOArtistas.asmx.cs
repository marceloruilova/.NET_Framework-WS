using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using AgregarDatos;
namespace ServiciosWeb_SOA
{
    /// <summary>
    /// Descripción breve de ServicioWebDTOArtistas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebDTOArtistas : System.Web.Services.WebService
    {
        Logica_DTO_Artistas dtologica = new Logica_DTO_Artistas();
        [WebMethod]
        public List<DTO_Artistas> seleccionarTodoArtistas()
        {
            return dtologica.seleccionarTodoArtistas();
        }
    }
}
