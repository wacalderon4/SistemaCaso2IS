using SistemaCaso2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaCaso2.CapaDatos
{
    public class InicializadorSistems : System.Data.Entity.DropCreateDatabaseAlways<SistemaContext>
    {
        protected override void Seed(SistemaContext context)
        {
            var pacientes = new List<Paciente>
            {
                new Paciente{idPaciente="1719098350", nombre="William Calderon", edad=22, peso=70.5, estatura= 1.79},
                new Paciente{idPaciente="1719098351", nombre="Santiago Ortega", edad=19, peso=68.1, estatura= 1.52},
                new Paciente{idPaciente="1719098352", nombre="Mateo Ramirez", edad=18, peso=58.5, estatura= 1.76},
                new Paciente{idPaciente="1719098353", nombre="Willie Valdez", edad=16, peso=67.5, estatura= 1.20},
                new Paciente{idPaciente="1719098354", nombre="Alvaro Reina", edad=26, peso=69.5, estatura= 1.80},
                new Paciente{idPaciente="1719098355", nombre="Manuel Rioja", edad=28, peso=71.3, estatura= 1.67},
                new Paciente{idPaciente="1719098356", nombre="Alexander Isch", edad=30, peso=90.5, estatura= 1.97}
            };

            pacientes.ForEach(s => context.Pacientes.Add(s));
            context.SaveChanges();

            var enfermedades = new List<Enfermedad>
            {
                new Enfermedad{EnfermedadID=200, nombreEnfermedad="diabetes", sintoma="Extrema sed"},
                new Enfermedad{EnfermedadID=101, nombreEnfermedad="infección garganta", sintoma="Ardor garganta"},
                new Enfermedad{EnfermedadID=102, nombreEnfermedad="conjuntivitis", sintoma="Ardor ojos"},
                new Enfermedad{EnfermedadID=103, nombreEnfermedad="colitis", sintoma="Dolor abdominal inferior"},
                new Enfermedad{EnfermedadID=104, nombreEnfermedad="gastritis", sintoma="Dolor abdominal superior"},
                new Enfermedad{EnfermedadID=105, nombreEnfermedad="colecistitis", sintoma="Dolor abdominal superior derecho"},
            };

            enfermedades.ForEach(s => context.Enfermedades.Add(s));
            context.SaveChanges();
            var registros = new List<Registro>
            {
                new Registro{PacientesID=11,IDEnfermedad=106 },
                new Registro{PacientesID=21,IDEnfermedad=107 },
                new Registro{PacientesID=31,IDEnfermedad=108 },
                new Registro{PacientesID=41,IDEnfermedad=109 },
                new Registro{PacientesID=51,IDEnfermedad=110 },
                new Registro{PacientesID=61,IDEnfermedad=112 },
            };
            enfermedades.ForEach(s => context.Enfermedades.Add(s));
            context.SaveChanges();
      
        }
    }
}