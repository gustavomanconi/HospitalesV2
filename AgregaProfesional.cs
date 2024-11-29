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
    public partial class AgregarProfesional : Form
    {
        private Servicio servicio = new Servicio();

        public AgregarProfesional(Servicio servicioProfesional)
        {
            InitializeComponent();
            servicio = servicioProfesional;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            Profesional nuevoProfesional = new Profesional
            {
                IdProfesional = servicio.ObtenerUltimoIdProfesional() + 1,
                Apellido = txtApellido.Text,
                Nombre = txtNombre.Text,
                Especialidad = cbEspecialidad.Text,
                Tipo = Persona.TipoPersona.Profesional
            };
            servicio.AgregarProfesional(nuevoProfesional);
            this.Close();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
