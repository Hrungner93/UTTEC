using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTTEC.Models
{
    public class AlumnoMateria
    {     
        
        public virtual ICollection<Alumnos> Alumno { get; set; }
        public virtual ICollection<Materia> Materia { get; set; }
    }
}
