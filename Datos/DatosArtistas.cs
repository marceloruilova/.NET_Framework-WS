using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;

namespace Datos
{
    public class DatosArtistas
    {
        MusicaEntities contexto;
        public DatosArtistas()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //mostrat todos los artistas
        public List<Artista> seleccionarArtistas()
        {
            return contexto.Artista.ToList();
        }
        //mostrar artista por id
        public Artista seleccionarArtistaID(short id_artista)
        {
            return contexto.Artista.Where(c => c.id_artista == id_artista).SingleOrDefault();
        }
        //Insertar artista
        public Artista insertarArtista(Artista nuevo)
        {
            contexto.Artista.Add(nuevo);
            contexto.SaveChanges();
            return nuevo;

        }
        //Eliminar Artista
        public Artista eliminarArtista(Artista artista)
        {
            contexto.Artista.Remove(artista);
            contexto.SaveChanges();
            return artista;
        }

        //Actualizar Artista
        public Artista actualizarArtista(Artista artista)
        {
            Artista actualizado = seleccionarArtistaID(Convert.ToInt16(artista.id_artista));
            actualizado.id_artista = artista.id_artista;
            actualizado.nombre = artista.nombre;
            actualizado.edad = artista.edad;
            actualizado.altura = artista.altura;
            actualizado.peso = artista.peso;
            contexto.SaveChanges();
            return actualizado;
        }
        //mostrar Artista-Manager
        public Artista mostrarArtistaManager(short id_manager)
        {
            return contexto.Artista.Where(t=>t.id_artista==id_manager).SingleOrDefault();
        }

    }
}
