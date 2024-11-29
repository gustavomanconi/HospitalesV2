using GestionHosptial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitales
{
    public partial class AgregarPaciente : Form
    {
        private Servicio servicio = new Servicio();

        public AgregarPaciente()
        { 
        
        }

        public AgregarPaciente(Servicio servicioPaciente)
        {
            InitializeComponent();
            servicio=servicioPaciente;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            Paciente nuevoPaciente = new Paciente 
            { 
              Apellido = txtApellido.Text, 
              Nombre = txtNombre.Text, 
              FechaNac = dtFechaNac.Value, 
              Tipo = Persona.TipoPersona.Paciente 
            }; 
            servicio.AgregarPaciente(nuevoPaciente); 
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
