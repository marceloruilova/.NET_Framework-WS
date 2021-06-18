using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using AgregarDatos;

namespace Logica
{
    public class Logica_DTO_Artistas
    {
        Datos_DTO_Artistas logicadto = new Datos_DTO_Artistas();
        public List<DTO_Artistas> seleccionarTodoArtistas()
        {
            return logicadto.selecionarTodoArtista();
        }
    }
}
