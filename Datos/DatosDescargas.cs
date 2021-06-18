using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;
namespace Datos
{
    public class DatosDescargas
    {
        MusicaEntities contexto;
        public DatosDescargas()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //mostrat todas las descargas
        public List<Descarga> seleccionarDescarga()
        {
            return contexto.Descarga.ToList();
        }
        //Insertar Departamento
        public Descarga insertarDescarga(Descarga nuevo)
        {
            contexto.Descarga.Add(nuevo);
            contexto.SaveChanges();
            return nuevo;

        }
        //mostrar descarga por nombre
        public List<Descarga> seleccionarDescargaNombre(string navegador)
        {
            return contexto.Descarga.Where(c => c.navegador == navegador).ToList();
        }
        //mostrar descarga por id
        public Descarga seleccionarDescargaid(short id_descarga)
        {
            return contexto.Descarga.Where(c => c.id_descarga== id_descarga).SingleOrDefault();
        }
        //Eliminar Descarga
        public Descarga eliminarDescarga(Descarga cancion)
        {
            contexto.Descarga.Remove(cancion);
            contexto.SaveChanges();
            return cancion;
        }

        //Actualizar Descarga
        public Descarga actualizarDescarga(Descarga cancion)
        {
            Descarga actualizado = seleccionarDescargaid(Convert.ToInt16(cancion.id_descarga));
            actualizado.id_descarga= cancion.id_descarga;
            actualizado.navegador = cancion.navegador;
            actualizado.proveedor = cancion.proveedor;
            contexto.SaveChanges();
            return actualizado;
        }
        //Todas las descargas desde procedimiento almacenado
        public List<seleccionarDescargas_SP_Result> verDescargaSP()
        {
            return contexto.seleccionarDescargas_SP().ToList();
        }
        //Seleccionar Cancion y artista y descarga
        public List<Descarga> seleccionarArtistas_Canciones_Descargas()
        {
            return contexto.Descarga.Include("Cancion").Include("Cancion.Artista").ToList();
            //return contexto.Cancion.Include(Artista).Include(artista.desc).Include(artista.desc.manager)
        }
        //Seleccionar Cancion y descarga
        public List<Descarga> seleccionarCanciones_Descargas()
        {
            return contexto.Descarga.Include("Cancion").ToList();
            //return contexto.Cancion.Include(Artista).Include(artista.desc).Include(artista.desc.manager)
        }
    }
}
