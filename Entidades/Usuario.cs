using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        //public int idPerfil { get; set; }
        public string nombreUsuario { get; set; }
        public int Intento { get; set; }
        public string pass { get; set; }
        public bool estadoUsuario { get; set; }
        public Usuario()
        {
            this.idUsuario = 0;
            this.pass = string.Empty;
            this.estadoUsuario = false;
        }
    }

}
