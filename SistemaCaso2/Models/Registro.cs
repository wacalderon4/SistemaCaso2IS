using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCaso2.Models
{
    public class Registro
    {
        public int RegistroID { get; set; }
        public int PacientesID { get; set; }
        public int IDEnfermedad { get; set; }
        public virtual Paciente Paciente { get; set;}
        public virtual Enfermedad Enfermedad { get; set; }

    }
}
