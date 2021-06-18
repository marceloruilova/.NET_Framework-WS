using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AgregarDatos;

namespace Logica
{
    public class LogicaManagers
    {
        DatosManagers managers = new DatosManagers();

        //mostrar los managers
        public List<Manager> seleccionarManagers()
        {
            return managers.seleccionarManagers();
        }
        //mostrar manager por id
        public Manager seleccionarManagerid(short id)
        {
            return managers.seleccionarManagerID(id);
        }
        //mostrar manager por nombre 

        public Manager seleccionarManagerNombre(string nombre)
        {
            return managers.seleccionarManagerNombre(nombre);
        }
        //agregar nuevo manager
        public Manager InsertarManager(Manager nuevoDep)
        {
            return managers.insertarManager(nuevoDep);
        }
        //eliminar
        public Manager eliminarManager(Manager manager)
        {
            return managers.eliminarManager(manager);
        }
        //actualizarC
        public Manager actualizarManager(Manager manager)
        {
            return managers.actualizarManager(manager);
        }
    }
}
