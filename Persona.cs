using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionHosptial
{
    public class Persona
    {
        public enum TipoPersona
        {
            Profesional,
            Paciente,
            Otro
        }

        public Persona() 
        {
            
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoPersona Tipo { get; set; }
        //public Persona()
        //{
        //    Nombre = string.Empty;
        //    Apellido = string.Empty;
        //}
    }
}
