using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caso
    {
        public int idCaso { get; set; }
        public int idGrua { get; set; }
        public string nombreCaso { get; set; }
        public bool estadoCaso { get; set; }
        public double kilometraje { get; set; }
        public int costoCaso { get; set; }
        public Caso()
        {
        }
    }
    
}
