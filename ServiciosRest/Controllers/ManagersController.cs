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
    public class ManagersController : ApiController
    {

        LogicaManagers logica = new LogicaManagers();
        // GET: api/Managers
        public List<Manager> Get()
        {
            return logica.seleccionarManagers();
        }

        // GET: api/Managers/5
        public Manager Get(short id)
        {
            return logica.seleccionarManagerid(id);
        }

        // POST: api/Managers
        public Manager Post([FromBody] Manager value)
        {
            return logica.InsertarManager(value);
        }

        // PUT: api/Managers/5
        public Manager Put([FromBody] Manager value)
        {
            return logica.actualizarManager(value);
        }

        // DELETE: api/Managers/5
        public Manager Delete(short id)
        {
            Manager artista = logica.seleccionarManagerid(id);
            return logica.eliminarManager(artista);
        }
    }
}
