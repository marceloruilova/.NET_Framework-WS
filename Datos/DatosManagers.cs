using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgregarDatos;
namespace Datos
{
    public class DatosManagers
    {
        MusicaEntities contexto;
        public DatosManagers()
        {
            contexto = new MusicaEntities();
            contexto.Configuration.ProxyCreationEnabled = false;
        }
        //mostrat todos los managers
        public List<Manager> seleccionarManagers()
        {
            return contexto.Manager.ToList();
        }
        //Insertar Manager
        public Manager insertarManager(Manager nuevo)
        {
            contexto.Manager.Add(nuevo);
            contexto.SaveChanges();
            return nuevo;

        }

        //mostrar manager por nombre
        public Manager seleccionarManagerNombre(string nombre)
        {
            return contexto.Manager.Where(c => c.nombre == nombre).SingleOrDefault();
        }
        //mostrar manager por id
        public Manager seleccionarManagerID(short id_cancion)
        {
            return contexto.Manager.Where(c => c.id_manager== id_cancion).SingleOrDefault();
        }
        //Eliminar Manager
        public Manager eliminarManager(Manager manager)
        {
            contexto.Manager.Remove(manager);
            contexto.SaveChanges();
            return manager;
        }

        //Actualizar Cancion
        public Manager actualizarManager(Manager cancion)
        {
            Manager actualizado = seleccionarManagerID(Convert.ToInt16(cancion.id_manager));
            actualizado.id_manager = cancion.id_manager;
            actualizado.nombre = cancion.nombre;
            actualizado.edad = cancion.edad;
            contexto.SaveChanges();
            return actualizado;
        }
    }
}
