using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grua
    {
        public int idGrua { get; set; }
        public int idChofer { get; set; }
        public string ubicacion { get; set; }
        public string estadoGrua { get; set; }
        public int cantidadServiciosAtendidos { get; set; }
        public Grua()
        {
            
        }
    }
}
