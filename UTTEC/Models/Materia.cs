using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTTEC.Models
{
    public class Materia
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMateria { get; set; }
        public String Nombre { get; set; }
        public String Salon { get; set; }
        public ICollection<Profesor> Profesor { get; set; }
    }
}
