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
    /// Descripción breve de ServicioWebCanciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebCanciones : System.Web.Services.WebService
    {
        LogicaCanciones logica = new LogicaCanciones();
        [WebMethod]
        public List<Cancion> seleccionarCanciones()
        {
            return logica.seleccionarCanciones();
        }
        [WebMethod]
        public Cancion seleccionarCancionesid(short id)
        {
            return logica.seleccionarCancionid(id);
        }
        [WebMethod]
        public Cancion seleccionarCancionNombre(string nombre)
        {
            return logica.seleccionarCancionNombre(nombre);
        }
        [WebMethod]
        public Cancion insertarCancion(Cancion nueva)
        {
            return logica.InsertarCancion(nueva);
        }
        [WebMethod]
        public Cancion actualizarCancion(Cancion nueva)
        {
            return logica.actualizarCancion(nueva);
        }
        [WebMethod]
        public Cancion eliminarCancion(short id)
        {
            Cancion eliminado = seleccionarCancionesid(id);
            return logica.eliminarCancion(eliminado);
        }
        [WebMethod]
        public List<Cancion> seleccionarArtistas_canciones()
        {
            return logica.seleccionarArtistasCancion();
        }
    }
}
