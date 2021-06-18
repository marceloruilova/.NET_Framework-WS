using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarDatos
{
    public class DTO_Manager_Descarga
    {
        public int id_manager { get; set; }
        public string nombre { get; set; }
        
        public Nullable<int> id_artista { get; set; }

        // Descarga

        public int id_descarga { get; set; }
        public Nullable<int> id_cancion { get; set; }
        
        public string navegador { get; set; }
        public string formato { get; set; }

    }
}
