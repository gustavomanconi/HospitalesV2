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
    public partial class GestionarPaciente : Form
    {
        private Servicio servicioPaciente = new Servicio();
        private List<Paciente> pacientes;

        public GestionarPaciente()
        {
            InitializeComponent();
            CargarPacientes();
        }

        public void CargarPacientes()
        {
            dgPaciente.Rows.Clear() ;
            pacientes = servicioPaciente.ObtenerPacientes();
            pacientes=pacientes.OrderBy(p=>p.Apellido).ToList();

            dgPaciente.DataSource = pacientes;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarPaciente agregar = new AgregarPaciente(servicioPaciente);
            agregar.ShowDialog();
            CargarPacientes();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            var pacientesFiltrados = pacientes.Where(p => p.Apellido.ToLower().StartsWith(txtBuscar.Text)).ToList();
            dgPaciente.Rows.Clear();

            dgPaciente.DataSource = pacientesFiltrados;
        }

        private void dgPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var pe = dgPaciente.CurrentRow.DataBoundItem as Paciente;
                var idpaciente = pe.IdPaciente;
                var prof = pacientes.FirstOrDefault(p => p.IdPaciente == idpaciente);

                if (prof != null)
                {
                    if (dgPaciente.Columns[e.ColumnIndex].Name == "Editar")
                    {
                        EditarPaciente modificar = new EditarPaciente(prof);
                        modificar.ShowDialog();
                        CargarPacientes();
                    }
                    if (dgPaciente.Columns[e.ColumnIndex].Name == "Borrar")
                    {
                        var resul = MessageBox.Show("Esta seguro de borrar el Paciente?", "Mensaje para el usuario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (resul == DialogResult.OK)
                        {
                            servicioPaciente.BorrarPaciente(prof);
                            CargarPacientes();
                        }
                    }
                }
            }
        }

        private void GestionarPaciente_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgPaciente.Columns) { column.DisplayIndex = column.Index; }
            SetColumnOrder();
        }

        private void SetColumnOrder() 
        { 
            dgPaciente.Columns["Apellido"].DisplayIndex = 0; 
            dgPaciente.Columns["Nombre"].DisplayIndex = 1; 
            dgPaciente.Columns["FechaNac"].DisplayIndex = 2; 
            dgPaciente.Columns["Tipo"].DisplayIndex = 3; 
            dgPaciente.Columns["Editar"].DisplayIndex = 4; 
            dgPaciente.Columns["Borrar"].DisplayIndex = 5; 
        }
    }   
}
