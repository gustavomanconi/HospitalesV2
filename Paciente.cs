using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHosptial
{
    public class Paciente : Persona
    {
        public int IdPaciente { get; set; }
        public DateTime FechaNac { get; set; }

        public Paciente()
        {

        }

            public Paciente(int idPaciente,string apellido, string nombre, DateTime fechaNac)
            {
                IdPaciente = idPaciente;
                Apellido = apellido; 
                Nombre = nombre; 
                FechaNac = fechaNac; 
                Tipo = Persona.TipoPersona.Paciente;
            }

            public Paciente(int idPaciente, string apellido, string nombre, DateTime fechaNac, Persona.TipoPersona tipo)
            {
                IdPaciente = idPaciente;
                Apellido = apellido; 
                Nombre = nombre; 
                FechaNac = fechaNac; 
                Tipo = Persona.TipoPersona.Paciente;
            }
    }
}