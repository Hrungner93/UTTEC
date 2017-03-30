using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UTTEC.Models
{
    public class Alumnos
    {
        [Key]
        public String Matricula { get; set; }
        public String Nombre { get; set; }
        public String AppPaterno { get; set; }
        public String AppMaterno { get; set; }
        public virtual ICollection<Grado> Grado{get;set;}
    }
}
