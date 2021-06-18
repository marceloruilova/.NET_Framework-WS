using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;
using Datos;

namespace Logica
{
    public class LogicaArtistas
    {
        DatosArtistas artistas = new DatosArtistas();
        //mostrar los departamentos
        public List<Artista> seleccionarArtistas()
        {
            return artistas.seleccionarArtistas();
        }
        //mostrar artista por id
        public Artista seleccionarArtistaid(short id)
        {
            return artistas.seleccionarArtistas().Where(est => est.id_artista == id).SingleOrDefault();
        }
        //agregar nuevo artista
        public Artista InsertarArtista(Artista nuevoDep)
        {
            return artistas.insertarArtista(nuevoDep);
        }
        //eliminar
        public Artista eliminarArtista(Artista artista)
        {
            return artistas.eliminarArtista(artista);
        } 
        //actualizar
        public Artista actualizarArtista(Artista artista)
        {
            return artistas.actualizarArtista(artista);
        }
        //actualizar
        public Artista mostrarArtistaManager(short artista)
        {
            return artistas.mostrarArtistaManager(artista);
        }
    }
}
