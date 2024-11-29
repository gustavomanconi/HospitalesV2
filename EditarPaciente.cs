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
    public partial class EditarPaciente : Form
    {
        Paciente prof1;
        
        public EditarPaciente(Paciente paciente)
        {
            InitializeComponent();

            prof1 = paciente;

            txtApellido.Text=prof1.Apellido;
            txtNombre.Text=prof1.Nombre;
            dtFechaNac.Text=prof1.FechaNac.ToString();
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            prof1.Apellido = txtApellido.Text;
            prof1.Nombre = txtNombre.Text;
            prof1.FechaNac = DateTime.Parse(dtFechaNac.Text);
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
