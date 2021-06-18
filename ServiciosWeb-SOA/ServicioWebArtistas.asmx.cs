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
    /// Descripción breve de ServicioWebArtistas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebArtistas : System.Web.Services.WebService
    {
        LogicaArtistas logica = new LogicaArtistas();
        [WebMethod]
        public List<Artista> seleccionarArtistas()
        {
            return logica.seleccionarArtistas();
        }
        [WebMethod]
        public Artista seleccionarArtistasid(short id)
        {
            return logica.seleccionarArtistaid(id);
        }
        [WebMethod]
        public Artista eliminarArtista(short id)
        {
            Artista eliminado = seleccionarArtistasid(id);
            return logica.eliminarArtista(eliminado);
        }
        [WebMethod]
        public Artista actualizarArtista(Artista artista)
        {
           return logica.actualizarArtista(artista);
        }
        [WebMethod]
        public Artista insertarArtista(Artista artista)
        {
            return logica.InsertarArtista(artista);
        }
        [WebMethod]
        public Artista seleccionarArtistasegunManagerid(short id)
        {
            return logica.mostrarArtistaManager(id);
        }
    }
}
