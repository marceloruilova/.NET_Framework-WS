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
    public class CancionesController : ApiController
    {
        LogicaCanciones logica = new LogicaCanciones();
        // GET: api/Canciones
        public List<Cancion> Get()
        {
            return logica.seleccionarCanciones();
        }

        // GET: api/Canciones/5
        public Cancion Get(short id)
        {
            return logica.seleccionarCancionid(id);
        }

        // POST: api/Canciones
        public Cancion Post([FromBody] Cancion value)
        {
            return logica.InsertarCancion(value);
        }

        // PUT: api/Canciones/5
        public Cancion Put([FromBody] Cancion value)
        {
            return logica.actualizarCancion(value);
        }

        // DELETE: api/Canciones/5
        public Cancion Delete(short id)
        {
            Cancion artista = logica.seleccionarCancionid(id);
            return logica.eliminarCancion(artista);
        }
    }
}
