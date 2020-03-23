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
        public string ubicacionCaso { get; set; }
        public float kilometraje { get; set; }
        public int costoPorKilometraje{ get; set; }
        public int costoCaso { get; set; }

        public Caso()
        {
        }
    }
    
}
