using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AgregarDatos;

namespace Logica
{
    public class Logica_DTO_Manager_Descarga
    {
        Datos_DTO_Manager_Descarga datos = new Datos_DTO_Manager_Descarga();
        public List<DTO_Manager_Descarga> mostrarManagerDescarga()
        {

            return datos.seleccionarDescargasManagers();
        }
    }
}
