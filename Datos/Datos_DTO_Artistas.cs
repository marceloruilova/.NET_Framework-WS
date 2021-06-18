using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;

namespace Datos
{
    public class Datos_DTO_Artistas
    {
        MusicaEntities contexto;
        public Datos_DTO_Artistas()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;//para que no se genere automaticos enlaces virutales
        }
        public List<DTO_Artistas> selecionarTodoArtista() {
            
            DatosCanciones datos_canciones = new DatosCanciones();
            List<Cancion> lst_canciones = datos_canciones.seleccionarCanciones();
            
            DatosManagers datos_managers = new DatosManagers();
            List<Manager> lst_managers=datos_managers.seleccionarManagers();
            
            DatosArtistas datos_artistas = new DatosArtistas();
            List<Artista> lst_artistas=datos_artistas.seleccionarArtistas();

            List<DTO_Artistas> lst_dto_artistas=new List<DTO_Artistas>();
                
            foreach (var item2 in lst_artistas)
            {
                DTO_Artistas artistas = new DTO_Artistas();
                
                    artistas.id_artista = item2.id_artista;
                    artistas.nombre_artista = item2.nombre;
                    artistas.edad_artista = item2.edad;
                        
                //llenar canciones
                foreach (var item in lst_canciones)
                {

                        artistas.id_cancion = item.id_cancion;
                        artistas.nombre_cancion = item.nombre;
                        artistas.colaboradores = item.colaboradores;
                        artistas.dj = item.dj;
                }
                //llenar managers
                foreach (var item in lst_managers)
                {
                        artistas.id_manager = item.id_manager;
                        artistas.nombre_manager = item.nombre;
                        artistas.sueldo = item.sueldo;
                }
                lst_dto_artistas.Add(artistas);
            }

            return lst_dto_artistas;

        }
    }
}
