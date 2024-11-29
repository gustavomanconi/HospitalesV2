using GestionHosptial;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospitales
{
    public class Servicio
    {
        public List<Profesional> profesionales = new List<Profesional>();
        public List<Paciente> pacientes = new List<Paciente>();
        public Servicio()
        {
            CargarPaciente();
        }

        public void CargarPaciente()
        {
            Profesional profesional1 = new Profesional(1, "Rojas", "Marta", "Cardiologia");
            Profesional profesional2 = new Profesional(2, "Martinez", "Ana", "Pediatría");
            Profesional profesional3 = new Profesional(3, "Alcorta", "Sonia", "Cardiologia");
            Profesional profesional4 = new Profesional(4, "Cortez", "Rogelio", "Pediatría");

            Paciente paciente1 = new Paciente(1,"Rosales","Carmen",DateTime.Now,Persona.TipoPersona.Paciente);
            Paciente paciente2 = new Paciente(2, "Arreyes", "Adriana", DateTime.Now, Persona.TipoPersona.Paciente);
            Paciente paciente3 = new Paciente(3, "Carrizo", "Pedro", DateTime.Now, Persona.TipoPersona.Paciente);
            Paciente paciente4 = new Paciente(4, "Erasmus Buckner", "Quail Alvarado", DateTime.Parse("09-02-25"));
            Paciente paciente5=new Paciente(5, "Darius Hale", "Bethany Bush", DateTime.Parse("03-06-24"));
            Paciente paciente6 = new Paciente(6, "Clio Mccoy", "Hiroko Battle", DateTime.Parse("02.01.24"));
            Paciente paciente7 = new Paciente(7, "Harper Schroeder", "Tobias Holt", DateTime.Parse("30.08.24"));
            Paciente paciente8 = new Paciente(8, "Wayne Case", "Jeremy Compton", DateTime.Parse("04.05.25"));
            Paciente paciente9 = new Paciente(9, "Rylee Lee", "Duncan Rowe", DateTime.Parse("01.08.25"));
            Paciente paciente10 = new Paciente(10, "Xaviera Hardy", "Louis Mckinney", DateTime.Parse("22.04.24"));
            Paciente paciente11 = new Paciente(11, "Warren Pacheco", "Cruz Martinez", DateTime.Parse("06.08.24"));
            Paciente paciente12 = new Paciente(12, "Tasha Soto", "Timon Cash", DateTime.Parse("07.07.25"));

            profesionales.Add(profesional1);
            profesionales.Add(profesional2);
            profesionales.Add(profesional3);
            profesionales.Add(profesional4);

            pacientes.Add(paciente1);
            pacientes.Add(paciente2);
            pacientes.Add(paciente3);
            pacientes.Add(paciente4);
            pacientes.Add(paciente5);
            pacientes.Add(paciente6);
            pacientes.Add(paciente7);
            pacientes.Add(paciente8);
            pacientes.Add(paciente9);
            pacientes.Add(paciente10);
            pacientes.Add(paciente11);
            pacientes.Add(paciente12);

            profesional1.Pacientes.Add(paciente1);
            profesional1.Pacientes.Add(paciente2);
            profesional2.Pacientes.Add(paciente3);

            profesional1.Pacientes=profesional1.Pacientes.OrderBy(p => p.Apellido).ToList();
        }
        public List<Profesional> ObtenerProfesionales()
        {
            return profesionales;
        }

        public void AgregarProfesional(Profesional profesional)
        {
            profesionales.Add(profesional);
        }

        public List<Profesional> ObtenerProfesional()
        {
            return profesionales;
        }

        public void AgregarPacienteAProfesional(int idProfesional, int idPaciente)
        {
            var pac = pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
            var prof = profesionales.FirstOrDefault(p => p.IdProfesional== idProfesional);
            if (prof != null)
            {
                prof.Pacientes.Add(pac);
            }
        }

        public void ModificarProfesional(Profesional profesional)
        {
            var prof = profesionales.FirstOrDefault(p => p.IdProfesional == profesional.IdProfesional);
            
            if (prof != null)
            {
                prof.Especialidad = profesional.Especialidad;
                prof.Apellido = profesional.Apellido;
                prof.Nombre = profesional.Nombre;
                prof.Especialidad= profesional.Especialidad;
            }
        }

        public void BorrarProfesional(Profesional profesional)
        {
            if (profesional != null)
            { 
               profesionales.Remove(profesional); 
            }
        }

        public int ObtenerUltimoIdProfesional()
        {
            if (!profesionales.Any())
            {
                return 1;
            }
            else
            {
                return profesionales[profesionales.Count - 1].IdProfesional;
            }
        }

        public bool BuscarPacienteAsignado(int idProfesional,int idPaciente)
        {
            bool respuesta=false;
            var prof= profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
            if(prof!=null)
            {
                if(prof.Pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente)!=null)
                {
                    respuesta= true;
                }
                else
                {
                    respuesta= false;
                }
            }
            return respuesta;
        }

        public List<Paciente> ObtenerPacientes()
        {
            return pacientes;
        }

        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void ModificarPaciente(Paciente paciente)
        {
            var prof = pacientes.FirstOrDefault(p => p.IdPaciente == paciente.IdPaciente);

            if (prof != null)
            {
                prof.Apellido = paciente.Apellido;
                prof.Nombre = paciente.Nombre;
                prof.FechaNac = paciente.FechaNac;
            }
        }

        public void BorrarPaciente(Paciente paciente)
        {
            if (paciente != null)
            {
                pacientes.Remove(paciente);
            }
        }

        public int ObtenerUltimoIdPaciente()
        {
            return pacientes[pacientes.Count - 1].IdPaciente;
        }

        public void BorrarPacienteProfesional(int idProfesional,int idPaciente)
        {
            var prof = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
            if (prof != null)
            {
                var pac= prof.Pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
                if (prof != null)
                {
                    prof.Pacientes.Remove(pac);
                }
            }
        }
    }

}


