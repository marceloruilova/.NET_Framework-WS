using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgregarDatos
{
    public class DTO_Artistas
    {
        //atributos artistas
        public int id_artista { get; set; }
        public string nombre_artista { get; set; }
        public Nullable<short> edad_artista { get; set; }
        /*
        
        <connectionStrings>
    <add name = "MusicaEntities" connectionString="metadata=res://*/
        //Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-KBMDSLP\SQLEXPRESS;initial catalog=Musica;user id=usuario;password=usuario123;multipleactiveresultsets=True;application name=EntityFramework&quot;" providerName="System.Data.EntityClient" />
  //</connectionStrings>
        //public virtual Cancion Cancion { get; set; }
        //public virtual Manager Manager { get; set; }
        //*/
        //atributos cancion

        public int id_cancion { get; set; }
        public string nombre_cancion { get; set; }
        public string colaboradores { get; set; }
        public string dj { get; set; }
        //atributos manager
        public int id_manager { get; set; }
        public string nombre_manager { get; set; }
        public Nullable<double> sueldo { get; set; }
    }
}
