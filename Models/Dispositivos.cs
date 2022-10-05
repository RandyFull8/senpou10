using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace back_salidaActivos.Models
{
    public class dispositivos
    {

        //solicitud
       public int idDispositivo { get; set; }
        public string nombre { get; set; }

        public string maquina { get; set; }

        

        public dispositivos() { }


        public dispositivos(int IdMaquina,
string Nombre, string Maquina
            )
        {           
            idDispositivo = IdMaquina;
            nombre = Nombre;
            maquina = Maquina;
        }

        public dispositivos(
string Nombre, string Maquina
            )
        {
           
            nombre = Nombre;
            maquina = Maquina;
        }




    }
}



