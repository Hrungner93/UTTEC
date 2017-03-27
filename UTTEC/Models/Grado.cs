using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTTEC.Models
{
    public class Grado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GradoId { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
    }
}
