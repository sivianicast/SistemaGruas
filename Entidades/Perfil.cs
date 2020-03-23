using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
     public class Perfil
    {

        public int idPerfil { get; set; }
        public string nombrePerfil { get; set; }

        public Perfil()
        {
            idPerfil = 0;
            nombrePerfil = string.Empty;
           
        }


    }
}
