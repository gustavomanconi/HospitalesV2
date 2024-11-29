using GestionHosptial;
using Hospitales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHosptial
{
    public class Profesional : Persona
    {
        public int IdProfesional { get; set; }
        public string Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }

        public Profesional() 
        { 
            Pacientes = new List<Paciente>(); 
        }
        public Profesional(int idProfesonal,string apellido, string nombre, string especialidad) 
        { 
            IdProfesional = idProfesonal;
            Apellido = apellido; 
            Nombre = nombre; 
            Especialidad = especialidad; 
            Tipo = Persona.TipoPersona.Profesional; 
            Pacientes = new List<Paciente>(); 
        }



    }
}
