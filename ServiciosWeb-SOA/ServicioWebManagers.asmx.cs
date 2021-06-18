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
    /// Descripción breve de ServicioWebManagers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioWebManagers : System.Web.Services.WebService
    {
        LogicaManagers logica = new LogicaManagers();
        [WebMethod]
        public List<Manager> seleccionarManagers()
        {
            return logica.seleccionarManagers();
        }
        //mostrar manager por id
        [WebMethod]
        public Manager seleccionarManagerid(short id)
        {
            return logica.seleccionarManagerid(id);
        }
        //mostrar manager por nombre 
        [WebMethod]
        public Manager seleccionarManagerNombre(string nombre)
        {
            return logica.seleccionarManagerNombre(nombre);
        }
        //agregar nuevo manage
        //r
        [WebMethod]
        public Manager InsertarManager(Manager nuevo)
        {
            return logica.InsertarManager(nuevo);
        }
        //eliminar
        [WebMethod]
        public Manager eliminarManager(short id)
        {
            Manager eliminado = seleccionarManagerid(id);
            return logica.eliminarManager(eliminado);
        }
        //actualizarC
        [WebMethod]
        public Manager actualizarManager(Manager manager)
        {
            return logica.actualizarManager(manager);
        }
    }
}
