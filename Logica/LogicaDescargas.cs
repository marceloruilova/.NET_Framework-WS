using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;
using Datos;
namespace Logica
{
    public class LogicaDescargas
    {
        DatosDescargas descargas = new DatosDescargas();

        //mostrar las descargas
        public List<Descarga> seleccionarDescargas()
        {
            return descargas.seleccionarDescarga();
        }
        //mostrar descarga por id
        public Descarga seleccionarDescargaid(short id)
        {
            return descargas.seleccionarDescargaid(id);
        }
        //mostrar descarga por navegador

        public List<Descarga> seleccionarDescargaNavegador(string navegador)
        {
            return descargas.seleccionarDescargaNombre(navegador);
        }
        //agregar nueva descarga
        public Descarga InsertarDescarga(Descarga nuevoDep)
        {
            return descargas.insertarDescarga(nuevoDep);
        }
        //eliminar
        public Descarga eliminarDescarga(Descarga descarga)
        {
            return descargas.eliminarDescarga(descarga);
        }
        //actualizarC
        public Descarga actualizarDescarga(Descarga descarga)
        {
            return descargas.actualizarDescarga(descarga);
        }
        //mostrar descarga SP
        public List<seleccionarDescargas_SP_Result> seleccionarDescargasSP()
        {
            return descargas.verDescargaSP();
        }
        //mostrar cancion descarga artista
        public List<Descarga> seleccionarDescargaCancionArtista()
        {
            return descargas.seleccionarArtistas_Canciones_Descargas();
        }
        //mostrar cancion descarga 
        public List<Descarga> seleccionarDescargaCancion()
        {
            return descargas.seleccionarCanciones_Descargas();
        }
    }
}
