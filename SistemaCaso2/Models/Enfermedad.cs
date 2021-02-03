using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCaso2.Models
{
    public class Enfermedad
    {
       
        
        
        public int EnfermedadID { get; set; }
        public string nombreEnfermedad { get; set; }
        public string sintoma { get; set; }
        
        public virtual ICollection<Registro> Registros { get; set; }

        
    }
}
