using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UTTEC.Models
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdMateria { get; set; }
        public String Nombre { get; set; }
        public String Salon { get; set; }
        public virtual ICollection<Profesor> Profesor { get; set; }
    }
}
