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
    public class DescargasController : ApiController
    {

        LogicaDescargas logica = new LogicaDescargas();
        // GET: api/Descargas
        public List<Descarga> Get()
        {
            return logica.seleccionarDescargas();
        }

        // GET: api/Descargas/5
        public Descarga Get(short id)
        {
            return logica.seleccionarDescargaid(id);
        }

        // POST: api/Descargas
        public Descarga Post([FromBody] Descarga value)
        {
            return logica.InsertarDescarga(value);
        }

        // PUT: api/Descargas/5
        public Descarga Put([FromBody] Descarga value)
        {
            return logica.actualizarDescarga(value);
        }

        // DELETE: api/Descargas/5
        public Descarga Delete(short id)
        {
            Descarga artista = logica.seleccionarDescargaid(id);
            return logica.eliminarDescarga(artista);
        }
    }
}
