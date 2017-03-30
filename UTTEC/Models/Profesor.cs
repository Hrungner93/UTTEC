using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTTEC.Models
{
    public class Profesor
    {
        [Key]
        public String Matricula { get; set; }
        public String Nombre { get; set; }
        public String AppPaterno { get; set; }
        public String AppMaterno { get; set; }
        [ForeignKey("Grado")]
        public ICollection<Grado> Grado { get; set; }
        
    }
}
