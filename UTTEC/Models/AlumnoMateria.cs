using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UTTEC.Models
{
    public class AlumnoMateria
    {
        public ICollection<Alumnos> Alumno { get; set; }
        public ICollection<Materia> Materia { get; set; }
    }
}
