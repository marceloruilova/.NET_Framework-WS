using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;

namespace Datos
{
    public class DatosCanciones
    {
        MusicaEntities contexto;
        public DatosCanciones()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //mostrat todas las canciones
        public List<Cancion> seleccionarCanciones()
        {
            return contexto.Cancion.ToList();
        }
        //Insertar Cancion
        public Cancion insertarCancion(Cancion nuevo)
        {
            contexto.Cancion.Add(nuevo);
            contexto.SaveChanges();
            return nuevo;

        }
        //mostrar cancion por nombre
        public Cancion seleccionarCancionNombre(string nombre)
        {
            return contexto.Cancion.Where(est => est.nombre == nombre).SingleOrDefault();
        }
        //mostrar cancion por id
        public Cancion seleccionarCancionID(short id_cancion)
        {
            return contexto.Cancion.Where(c => c.id_cancion == id_cancion).SingleOrDefault();
        }
        //Eliminar Cancion
        public Cancion eliminarCancion(Cancion cancion)
        {
            contexto.Cancion.Remove(cancion);
            contexto.SaveChanges();
            return cancion;
        }

        //Actualizar Cancion
        public Cancion actualizarArtista(Cancion cancion)
        {
            Cancion actualizado = seleccionarCancionID(Convert.ToInt16(cancion.id_cancion));
            actualizado.id_artista = cancion.id_artista;
            actualizado.nombre = cancion.nombre;
            actualizado.duracion = cancion.duracion;
            contexto.SaveChanges();
            return actualizado;
        }
        //Seleccionar Cancion y artista
        public List<Cancion> seleccionarArtistas_Canciones()
        {
            return contexto.Cancion.Include("Artista").ToList();
            //return contexto.Cancion.Include(Artista).Include(artista.desc).Include(artista.desc.manager)
        }
    }
}
