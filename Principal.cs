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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void gestionarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarPaciente pac=new GestionarPaciente();
            pac.Show();
        }
        private void gestionarProfesionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionarProfesional pac = new GestionarProfesional();
            pac.Show();
        }
    }
}
