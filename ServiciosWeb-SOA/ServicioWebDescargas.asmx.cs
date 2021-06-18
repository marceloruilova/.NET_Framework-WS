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
    /// Descripción breve de ServicioWebDescargas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebDescargas : System.Web.Services.WebService
    {
        LogicaDescargas logica = new LogicaDescargas();

        [WebMethod]
        public List<Descarga> seleccionarDescargas()
        {
            return logica.seleccionarDescargas();
        }
        [WebMethod]
        public Descarga seleccionarDescargaId(short id)
        {
            return logica.seleccionarDescargaid(id);
        }
        [WebMethod]
        public List<Descarga> seleccionarDescargaNavegador(string navegador)
        {
            return logica.seleccionarDescargaNavegador(navegador);
        }
        [WebMethod]
        public Descarga insertarDescarga(Descarga nueva)
        {
            return logica.InsertarDescarga(nueva);
        }
        [WebMethod]
        public Descarga actualizarDescarga(Descarga nueva)
        {
            return logica.actualizarDescarga(nueva);
        }
        [WebMethod]
        public Descarga eliminarDescarga(short id)
        {
            Descarga eliminado = seleccionarDescargaId(id);
            return logica.eliminarDescarga(eliminado);
        }

        [WebMethod]
        public List<seleccionarDescargas_SP_Result> seleccionarDescargasSP()
        {
            return logica.seleccionarDescargasSP();
        }
        [WebMethod]
        public List<Descarga> seleccionarDescargaCancion()
        {
            return logica.seleccionarDescargaCancion();
        }
        [WebMethod]
        public List<Descarga> seleccionarArtistaDescargaCancion()
        {
            return logica.seleccionarDescargaCancionArtista();
        }
    }
}
