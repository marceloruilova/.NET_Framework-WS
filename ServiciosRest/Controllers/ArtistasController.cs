using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AgregarDatos;
using Logica;
namespace ServiciosRest.Controllers
{

    public class ArtistasController : ApiController
    {
        LogicaArtistas logica = new LogicaArtistas();

        // GET: api/Artistas
        public List<Artista> Get()
        {
            return logica.seleccionarArtistas();
        }

        // GET: api/Artistas/5
        public Artista Get(short id)
        {
            return logica.seleccionarArtistaid(id);
        }

        // POST: api/Artistas
        public Artista Post([FromBody]Artista value)
        {
            return logica.InsertarArtista(value);
        }

        // PUT: api/Artistas/5
        public Artista Put([FromBody]Artista value)
        {
            return logica.actualizarArtista(value);
        }
        // DELETE: api/Artistas/5
        public Artista Delete(short id)
        {
            Artista artista=logica.seleccionarArtistaid(id);
            return logica.eliminarArtista(artista);
        }
    }
}
