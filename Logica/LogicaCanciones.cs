using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;
using Datos;
namespace Logica
{
    public class LogicaCanciones
    {
        DatosCanciones canciones = new DatosCanciones();

        //mostrar las canciones
        public List<Cancion> seleccionarCanciones()
        {
            return canciones.seleccionarCanciones();
        }
        //mostrar cancion por id
        public Cancion seleccionarCancionid(short id)
        {
            return canciones.seleccionarCancionID(id);
        }
        //mostrar cancion por nombre

        public Cancion seleccionarCancionNombre(string nombre)
        {
            return canciones.seleccionarCancionNombre(nombre);
        }
        //agregar nueva cancion
        public Cancion InsertarCancion(Cancion nuevo)
        {
            return canciones.insertarCancion(nuevo);
        }
        //eliminar
        public Cancion eliminarCancion(Cancion cancion)
        {
            return canciones.eliminarCancion(cancion);
        }
        //actualizarC
        public Cancion actualizarCancion(Cancion cancion)
        {
            return canciones.actualizarArtista(cancion);
        }
        //Mostrar artistas y canciones
        public List<Cancion> seleccionarArtistasCancion()
        {
            return canciones.seleccionarArtistas_Canciones();
        }
    }
}
