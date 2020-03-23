using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Chofer
    {
        public int idChofer { get; set; }
        public string nombreChofer { get; set; }
        public int ingresoObtenido { get; set; }
        public bool estadoChofer { get; set; }

        public Chofer()
        {
        }
    }
}
