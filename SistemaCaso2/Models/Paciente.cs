using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaCaso2.Models
{
    public class Paciente 
    {
 
        public int ID { get; set; }
        public string idPaciente { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public double peso { get; set; }
        public double estatura { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }


    }

}