using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;

namespace Datos
{
    public class Datos_DTO_Manager_Descarga
    {
        MusicaEntities contexto;
        public Datos_DTO_Manager_Descarga()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;//para que no se genere automaticos enlaces virutales
        }
        public List<DTO_Manager_Descarga> seleccionarDescargasManagers()
        {
            var consulta = from clidescargas in contexto.Descarga
                           join climanagers in contexto.Manager on clidescargas.id_descarga equals climanagers.id_manager
                           select new DTO_Manager_Descarga
                           {
                               nombre = climanagers.nombre,
                               navegador = clidescargas.navegador
                           };
            List<DTO_Manager_Descarga> resultado = consulta.ToList();
            return resultado;
        }/*public List<DTO_Manager_Descarga> seleccionarDescargasManagers()
        {
            var consulta = from clidescargas in contexto.Descarga
                           join climanagers in contexto.Manager on clidescargas.id_descarga equals climanagers.id_manager
                           where...(conssultas)
                            select new DTO_Manager_Descarga
                           {
                               nombre = climanagers.nombre,
                               navegador = clidescargas.navegador
                           };
            List<DTO_Manager_Descarga> resultado = consulta.ToList();
            return resultado;
        }*/
    }
}
