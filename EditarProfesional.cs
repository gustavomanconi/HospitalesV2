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
    public partial class EditarProfesional : Form
    {
        Profesional prof1;
        public EditarProfesional(Profesional profesional)
        {
            InitializeComponent();
            prof1=profesional;
            txtApellido.Text = profesional.Apellido;
            txtNombre.Text = profesional.Nombre;
            cbEspecialidad.Text = profesional.Especialidad;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            prof1.Apellido = txtApellido.Text;
            prof1.Nombre = txtNombre.Text;
            prof1.Especialidad = cbEspecialidad.Text;
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
