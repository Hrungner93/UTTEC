using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTTEC.Models
{
    public class Alumnos
    {
        public String MatriculaID { get; set; }
        public String Nombre { get; set; }
        public String AppPaterno { get; set; }
        public String AppMaterno { get; set; }
        public ICollection<Grado> Grado{get;set;}
    }
}
