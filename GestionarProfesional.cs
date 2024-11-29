using GestionHosptial;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Hospitales
{
    public partial class GestionarProfesional : Form
    {
        private Servicio servicio=new Servicio();

        private Profesional profesionalSeleccionado;
        private List<Profesional> profesionales;
        private List<Paciente> pacientes;

        private int idProfesional;
        private int idPaciente;

        public GestionarProfesional()
        {
            InitializeComponent();
            CargarProfesional();
            CargarPacientes();
        }

        private void CargarProfesional()
        {
            dgProfesional.Rows.Clear();
            profesionales = servicio.ObtenerProfesional();
            profesionales = profesionales.OrderBy(x => x.Apellido).ToList();
            foreach (var item in profesionales)
            {
                dgProfesional.Rows.Add(item.Apellido, item.Nombre, item.Especialidad, item.Tipo,"","","",item.IdProfesional);
            }
        }

        private void CargarPacientes()
        {
            dgPaciente.Rows.Clear();
            pacientes = servicio.ObtenerPacientes();
            pacientes=pacientes.OrderBy(x=>x.Apellido).ToList();
            foreach (var item in pacientes)
            {
                dgPaciente.Rows.Add(item.Apellido, item.Nombre, item.FechaNac, "", item.IdPaciente);
            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            AgregarProfesional agregar = new AgregarProfesional(servicio);
            agregar.ShowDialog();
            CargarProfesional();
        }

        private void dgProfesional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idProfesional = int.Parse(dgProfesional.Rows[e.RowIndex].Cells[7].Value.ToString());
            var prof = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);

            if (prof != null)
            {
                if (dgProfesional.Columns[e.ColumnIndex].Name == "Editar")
                {
                    EditarProfesional modificar = new EditarProfesional(prof);
                    modificar.ShowDialog();
                    CargarProfesional();
                }
                if (dgProfesional.Columns[e.ColumnIndex].Name == "Borrar")
                {
                    var result= MessageBox.Show("Esta seguro de borrar el Profesional?","Mensaje para el usuario",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        servicio.BorrarProfesional(prof);
                        dgPacienteAsignado.Rows.Clear();
                        CargarProfesional();
                    }
                }
            }
        }

        private void dgProfesional_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbNombreProfesional.Text =dgProfesional.CurrentRow.Cells["Apellido"].Value.ToString() + ", " + dgProfesional.CurrentRow.Cells["Nombre"].Value.ToString();
            
            idProfesional = int.Parse(dgProfesional.CurrentRow.Cells["IdProf"].Value.ToString());
            var prof = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
            dgPacienteAsignado.Rows.Clear();
            foreach (var item in prof.Pacientes)
            {
                dgPacienteAsignado.Rows.Add(item.Apellido, item.Nombre, item.FechaNac,"", item.IdPaciente);
            }
        }

        private void dgPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idProfesional = int.Parse(dgProfesional.CurrentRow.Cells["IdProf"].Value.ToString());

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgPaciente.Columns[e.ColumnIndex].Name == "Agregar")
                {
                    idPaciente = int.Parse(dgPaciente.CurrentRow.Cells["IdPacienteGeneral"].Value.ToString());

                    bool v = servicio.BuscarPacienteAsignado(idProfesional, idPaciente);
                    if (v)
                    {
                        MessageBox.Show("El paciente ya existen en el profesional", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        servicio.AgregarPacienteAProfesional(idProfesional, idPaciente);
                        var prof = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);
                        dgPacienteAsignado.Rows.Clear();

                        prof.Pacientes=prof.Pacientes.OrderBy(p=>p.Apellido).ToList();
                        foreach (var item in prof.Pacientes)
                        {
                            dgPacienteAsignado.Rows.Add(item.Apellido, item.Nombre, item.FechaNac, "", item.IdPaciente);
                        }
                    }
                }
            }
        }

        private void dgPacienteAsignado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dgPacienteAsignado.Columns[e.ColumnIndex].Name == "BorrarPaciente")
                {
                    idPaciente = int.Parse(dgPacienteAsignado.CurrentRow.Cells["IdPaciente"].Value.ToString());
                    servicio.BorrarPacienteProfesional(idProfesional, idPaciente);

                    var prof = profesionales.FirstOrDefault(p => p.IdProfesional == idProfesional);

                    dgPacienteAsignado.Rows.Clear();
                    foreach (var item in prof.Pacientes)
                    {
                        dgPacienteAsignado.Rows.Add(item.Apellido, item.Nombre, item.FechaNac, "", item.IdPaciente);
                    }
                }
            }
        }

        private void txtBuscarPaciente_KeyUp(object sender, KeyEventArgs e)
        {
            var pacientesFiltrados = pacientes.Where(p => p.Apellido.ToLower().StartsWith(txtBuscarPaciente.Text)).ToList();
            dgPaciente.Rows.Clear();

            foreach (var item in pacientesFiltrados)
            {
                dgPaciente.Rows.Add(item.Apellido, item.Nombre, item.FechaNac, "", item.IdPaciente);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            var profesionalFiltrados = profesionales.Where(p => p.Apellido.ToLower().StartsWith(txtBuscar.Text)).ToList();
            dgProfesional.Rows.Clear();

            foreach (var item in profesionalFiltrados)
            {
                dgProfesional.Rows.Add(item.Apellido, item.Nombre, item.Especialidad, item.Tipo, "", "", "", item.IdProfesional);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
