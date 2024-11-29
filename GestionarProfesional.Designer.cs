namespace Hospitales
{
    partial class GestionarProfesional
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dgProfesional = new System.Windows.Forms.DataGridView();
            this.dgPacienteAsignado = new System.Windows.Forms.DataGridView();
            this.ApellidoPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrarPaciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.dgPaciente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdPacienteGeneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.AgregarPaciente = new System.Windows.Forms.DataGridViewLinkColumn();
            this.IdProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNombreProfesional = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienteAsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(924, 548);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 11;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gestionar Profesional";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(344, 67);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(254, 26);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar Profesional";
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregar.ForeColor = System.Drawing.Color.White;
            this.btAgregar.Location = new System.Drawing.Point(742, 55);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(114, 37);
            this.btAgregar.TabIndex = 7;
            this.btAgregar.Text = "Agregar Profesional";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // dgProfesional
            // 
            this.dgProfesional.AllowUserToAddRows = false;
            this.dgProfesional.AllowUserToDeleteRows = false;
            this.dgProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProfesional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProfesional.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apellido,
            this.Nombre,
            this.Tipo,
            this.TipoPersona,
            this.Editar,
            this.Borrar,
            this.AgregarPaciente,
            this.IdProf});
            this.dgProfesional.Location = new System.Drawing.Point(26, 103);
            this.dgProfesional.MultiSelect = false;
            this.dgProfesional.Name = "dgProfesional";
            this.dgProfesional.ReadOnly = true;
            this.dgProfesional.RowHeadersWidth = 51;
            this.dgProfesional.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProfesional.Size = new System.Drawing.Size(830, 197);
            this.dgProfesional.TabIndex = 6;
            this.dgProfesional.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesional_CellClick);
            this.dgProfesional.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProfesional_CellContentClick);
            // 
            // dgPacienteAsignado
            // 
            this.dgPacienteAsignado.AllowUserToAddRows = false;
            this.dgPacienteAsignado.AllowUserToDeleteRows = false;
            this.dgPacienteAsignado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPacienteAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienteAsignado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApellidoPaciente,
            this.NombrePaciente,
            this.FechaNacPaciente,
            this.BorrarPaciente,
            this.IdPaciente});
            this.dgPacienteAsignado.Location = new System.Drawing.Point(28, 383);
            this.dgPacienteAsignado.Name = "dgPacienteAsignado";
            this.dgPacienteAsignado.ReadOnly = true;
            this.dgPacienteAsignado.RowHeadersWidth = 51;
            this.dgPacienteAsignado.Size = new System.Drawing.Size(491, 150);
            this.dgPacienteAsignado.TabIndex = 12;
            this.dgPacienteAsignado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacienteAsignado_CellClick);
            // 
            // ApellidoPaciente
            // 
            this.ApellidoPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ApellidoPaciente.HeaderText = "Apellido";
            this.ApellidoPaciente.MinimumWidth = 6;
            this.ApellidoPaciente.Name = "ApellidoPaciente";
            this.ApellidoPaciente.ReadOnly = true;
            // 
            // NombrePaciente
            // 
            this.NombrePaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombrePaciente.HeaderText = "Nombre";
            this.NombrePaciente.MinimumWidth = 6;
            this.NombrePaciente.Name = "NombrePaciente";
            this.NombrePaciente.ReadOnly = true;
            // 
            // FechaNacPaciente
            // 
            this.FechaNacPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.FechaNacPaciente.DefaultCellStyle = dataGridViewCellStyle5;
            this.FechaNacPaciente.HeaderText = "Fecha Nac";
            this.FechaNacPaciente.MinimumWidth = 6;
            this.FechaNacPaciente.Name = "FechaNacPaciente";
            this.FechaNacPaciente.ReadOnly = true;
            // 
            // BorrarPaciente
            // 
            this.BorrarPaciente.HeaderText = "Borrar";
            this.BorrarPaciente.MinimumWidth = 6;
            this.BorrarPaciente.Name = "BorrarPaciente";
            this.BorrarPaciente.ReadOnly = true;
            this.BorrarPaciente.Text = "Borrar";
            this.BorrarPaciente.UseColumnTextForLinkValue = true;
            this.BorrarPaciente.Width = 125;
            // 
            // IdPaciente
            // 
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.MinimumWidth = 6;
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
            this.IdPaciente.Visible = false;
            this.IdPaciente.Width = 125;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTitulo.Location = new System.Drawing.Point(27, 353);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(152, 16);
            this.lbTitulo.TabIndex = 13;
            this.lbTitulo.Text = "Pacientes Asignados a: ";
            // 
            // dgPaciente
            // 
            this.dgPaciente.AllowUserToAddRows = false;
            this.dgPaciente.AllowUserToDeleteRows = false;
            this.dgPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaciente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Agregar,
            this.IdPacienteGeneral});
            this.dgPaciente.Location = new System.Drawing.Point(526, 383);
            this.dgPaciente.Name = "dgPaciente";
            this.dgPaciente.ReadOnly = true;
            this.dgPaciente.RowHeadersWidth = 51;
            this.dgPaciente.Size = new System.Drawing.Size(473, 150);
            this.dgPaciente.TabIndex = 15;
            this.dgPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPaciente_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Nac";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "Agregar";
            this.Agregar.MinimumWidth = 6;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseColumnTextForLinkValue = true;
            this.Agregar.Width = 60;
            // 
            // IdPacienteGeneral
            // 
            this.IdPacienteGeneral.HeaderText = "IdPaciente";
            this.IdPacienteGeneral.MinimumWidth = 6;
            this.IdPacienteGeneral.Name = "IdPacienteGeneral";
            this.IdPacienteGeneral.ReadOnly = true;
            this.IdPacienteGeneral.Visible = false;
            this.IdPacienteGeneral.Width = 125;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.Location = new System.Drawing.Point(744, 348);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(256, 26);
            this.txtBuscarPaciente.TabIndex = 17;
            this.txtBuscarPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPaciente_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Buscar Pacientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(27, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Listado de Profesionales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(523, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Pacientes Totales";
            // 
            // Apellido
            // 
            this.Apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tipo.HeaderText = "Especialidad";
            this.Tipo.MinimumWidth = 6;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 125;
            // 
            // TipoPersona
            // 
            this.TipoPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TipoPersona.HeaderText = "Tipo";
            this.TipoPersona.MinimumWidth = 6;
            this.TipoPersona.Name = "TipoPersona";
            this.TipoPersona.ReadOnly = true;
            this.TipoPersona.Width = 125;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForLinkValue = true;
            this.Editar.Width = 80;
            // 
            // Borrar
            // 
            this.Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.MinimumWidth = 6;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Text = "Borrar";
            this.Borrar.UseColumnTextForLinkValue = true;
            this.Borrar.Width = 80;
            // 
            // AgregarPaciente
            // 
            this.AgregarPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AgregarPaciente.HeaderText = "Agregar Paciente";
            this.AgregarPaciente.MinimumWidth = 6;
            this.AgregarPaciente.Name = "AgregarPaciente";
            this.AgregarPaciente.ReadOnly = true;
            this.AgregarPaciente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AgregarPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AgregarPaciente.Text = "Agregar Paciente";
            this.AgregarPaciente.UseColumnTextForLinkValue = true;
            this.AgregarPaciente.Visible = false;
            // 
            // IdProf
            // 
            this.IdProf.HeaderText = "IdProfesional";
            this.IdProf.MinimumWidth = 6;
            this.IdProf.Name = "IdProf";
            this.IdProf.ReadOnly = true;
            this.IdProf.Visible = false;
            this.IdProf.Width = 125;
            // 
            // lbNombreProfesional
            // 
            this.lbNombreProfesional.AutoSize = true;
            this.lbNombreProfesional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreProfesional.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNombreProfesional.Location = new System.Drawing.Point(185, 353);
            this.lbNombreProfesional.Name = "lbNombreProfesional";
            this.lbNombreProfesional.Size = new System.Drawing.Size(0, 16);
            this.lbNombreProfesional.TabIndex = 20;
            // 
            // GestionarProfesional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 590);
            this.Controls.Add(this.lbNombreProfesional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgPaciente);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.dgPacienteAsignado);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dgProfesional);
            this.Name = "GestionarProfesional";
            this.Text = "GestionarProfesional";
            ((System.ComponentModel.ISupportInitialize)(this.dgProfesional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienteAsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DataGridView dgProfesional;
        private System.Windows.Forms.DataGridView dgPacienteAsignado;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridView dgPaciente;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacPaciente;
        private System.Windows.Forms.DataGridViewLinkColumn BorrarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewLinkColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPacienteGeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPersona;
        private System.Windows.Forms.DataGridViewLinkColumn Editar;
        private System.Windows.Forms.DataGridViewLinkColumn Borrar;
        private System.Windows.Forms.DataGridViewLinkColumn AgregarPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProf;
        private System.Windows.Forms.Label lbNombreProfesional;
    }
}