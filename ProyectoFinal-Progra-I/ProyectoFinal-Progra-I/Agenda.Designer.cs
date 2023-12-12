
namespace ProyectoFinal_Progra_I
{
    partial class Agenda
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboTratamientosDetallesConsulta = new System.Windows.Forms.ListBox();
            this.lblTratamientosDetallesConsulta = new System.Windows.Forms.Label();
            this.lboExamenesDetallesConsulta = new System.Windows.Forms.ListBox();
            this.lblExamenesDetallesConsulta = new System.Windows.Forms.Label();
            this.txtDiagnosticoDetallesConsulta = new System.Windows.Forms.TextBox();
            this.lblDiagnosticoDetallesConsulta = new System.Windows.Forms.Label();
            this.txtAnamnesisDetallesConsulta = new System.Windows.Forms.TextBox();
            this.lblAnamnesisDetallesConsulta = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lblHoraDetallesConsulta = new System.Windows.Forms.Label();
            this.lblHoraDeDetallesConsulta = new System.Windows.Forms.Label();
            this.lblADetallesConsulta = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDetallesConsulta = new System.Windows.Forms.Label();
            this.lblVeterinarioDetallesConsulta = new System.Windows.Forms.Label();
            this.cboVeterinarioDetallesConsulta = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.lblPacienteDetallesConsulta = new System.Windows.Forms.Label();
            this.cboPacienteDetallesConsulta = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter();
            this.usuariosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.usuariosTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboTratamientosDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblTratamientosDetallesConsulta);
            this.groupBox1.Controls.Add(this.lboExamenesDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblExamenesDetallesConsulta);
            this.groupBox1.Controls.Add(this.txtDiagnosticoDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblDiagnosticoDetallesConsulta);
            this.groupBox1.Controls.Add(this.txtAnamnesisDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblAnamnesisDetallesConsulta);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lblHoraDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblHoraDeDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblADetallesConsulta);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblFechaDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblVeterinarioDetallesConsulta);
            this.groupBox1.Controls.Add(this.cboVeterinarioDetallesConsulta);
            this.groupBox1.Controls.Add(this.lblPacienteDetallesConsulta);
            this.groupBox1.Controls.Add(this.cboPacienteDetallesConsulta);
            this.groupBox1.Location = new System.Drawing.Point(529, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de Consulta";
            // 
            // lboTratamientosDetallesConsulta
            // 
            this.lboTratamientosDetallesConsulta.FormattingEnabled = true;
            this.lboTratamientosDetallesConsulta.Location = new System.Drawing.Point(265, 367);
            this.lboTratamientosDetallesConsulta.Name = "lboTratamientosDetallesConsulta";
            this.lboTratamientosDetallesConsulta.Size = new System.Drawing.Size(250, 56);
            this.lboTratamientosDetallesConsulta.TabIndex = 38;
            // 
            // lblTratamientosDetallesConsulta
            // 
            this.lblTratamientosDetallesConsulta.AutoSize = true;
            this.lblTratamientosDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamientosDetallesConsulta.Location = new System.Drawing.Point(144, 367);
            this.lblTratamientosDetallesConsulta.Name = "lblTratamientosDetallesConsulta";
            this.lblTratamientosDetallesConsulta.Size = new System.Drawing.Size(114, 20);
            this.lblTratamientosDetallesConsulta.TabIndex = 37;
            this.lblTratamientosDetallesConsulta.Text = "Tratamientos";
            // 
            // lboExamenesDetallesConsulta
            // 
            this.lboExamenesDetallesConsulta.FormattingEnabled = true;
            this.lboExamenesDetallesConsulta.Location = new System.Drawing.Point(265, 252);
            this.lboExamenesDetallesConsulta.Name = "lboExamenesDetallesConsulta";
            this.lboExamenesDetallesConsulta.Size = new System.Drawing.Size(250, 56);
            this.lboExamenesDetallesConsulta.TabIndex = 36;
            // 
            // lblExamenesDetallesConsulta
            // 
            this.lblExamenesDetallesConsulta.AutoSize = true;
            this.lblExamenesDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamenesDetallesConsulta.Location = new System.Drawing.Point(144, 252);
            this.lblExamenesDetallesConsulta.Name = "lblExamenesDetallesConsulta";
            this.lblExamenesDetallesConsulta.Size = new System.Drawing.Size(92, 20);
            this.lblExamenesDetallesConsulta.TabIndex = 35;
            this.lblExamenesDetallesConsulta.Text = "Exámenes";
            // 
            // txtDiagnosticoDetallesConsulta
            // 
            this.txtDiagnosticoDetallesConsulta.Location = new System.Drawing.Point(265, 326);
            this.txtDiagnosticoDetallesConsulta.Name = "txtDiagnosticoDetallesConsulta";
            this.txtDiagnosticoDetallesConsulta.Size = new System.Drawing.Size(250, 20);
            this.txtDiagnosticoDetallesConsulta.TabIndex = 34;
            // 
            // lblDiagnosticoDetallesConsulta
            // 
            this.lblDiagnosticoDetallesConsulta.AutoSize = true;
            this.lblDiagnosticoDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosticoDetallesConsulta.Location = new System.Drawing.Point(144, 326);
            this.lblDiagnosticoDetallesConsulta.Name = "lblDiagnosticoDetallesConsulta";
            this.lblDiagnosticoDetallesConsulta.Size = new System.Drawing.Size(104, 20);
            this.lblDiagnosticoDetallesConsulta.TabIndex = 33;
            this.lblDiagnosticoDetallesConsulta.Text = "Diagnóstico";
            // 
            // txtAnamnesisDetallesConsulta
            // 
            this.txtAnamnesisDetallesConsulta.Location = new System.Drawing.Point(265, 211);
            this.txtAnamnesisDetallesConsulta.Name = "txtAnamnesisDetallesConsulta";
            this.txtAnamnesisDetallesConsulta.Size = new System.Drawing.Size(250, 20);
            this.txtAnamnesisDetallesConsulta.TabIndex = 32;
            // 
            // lblAnamnesisDetallesConsulta
            // 
            this.lblAnamnesisDetallesConsulta.AutoSize = true;
            this.lblAnamnesisDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnamnesisDetallesConsulta.Location = new System.Drawing.Point(144, 211);
            this.lblAnamnesisDetallesConsulta.Name = "lblAnamnesisDetallesConsulta";
            this.lblAnamnesisDetallesConsulta.Size = new System.Drawing.Size(97, 20);
            this.lblAnamnesisDetallesConsulta.TabIndex = 31;
            this.lblAnamnesisDetallesConsulta.Text = "Anamnesis";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(414, 170);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(60, 20);
            this.dateTimePicker3.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(296, 169);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(60, 20);
            this.dateTimePicker2.TabIndex = 29;
            // 
            // lblHoraDetallesConsulta
            // 
            this.lblHoraDetallesConsulta.AutoSize = true;
            this.lblHoraDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDetallesConsulta.Location = new System.Drawing.Point(144, 170);
            this.lblHoraDetallesConsulta.Name = "lblHoraDetallesConsulta";
            this.lblHoraDetallesConsulta.Size = new System.Drawing.Size(53, 20);
            this.lblHoraDetallesConsulta.TabIndex = 28;
            this.lblHoraDetallesConsulta.Text = "Hora:";
            // 
            // lblHoraDeDetallesConsulta
            // 
            this.lblHoraDeDetallesConsulta.AutoSize = true;
            this.lblHoraDeDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraDeDetallesConsulta.Location = new System.Drawing.Point(261, 170);
            this.lblHoraDeDetallesConsulta.Name = "lblHoraDeDetallesConsulta";
            this.lblHoraDeDetallesConsulta.Size = new System.Drawing.Size(29, 20);
            this.lblHoraDeDetallesConsulta.TabIndex = 27;
            this.lblHoraDeDetallesConsulta.Text = "de";
            // 
            // lblADetallesConsulta
            // 
            this.lblADetallesConsulta.AutoSize = true;
            this.lblADetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADetallesConsulta.Location = new System.Drawing.Point(379, 169);
            this.lblADetallesConsulta.Name = "lblADetallesConsulta";
            this.lblADetallesConsulta.Size = new System.Drawing.Size(19, 20);
            this.lblADetallesConsulta.TabIndex = 26;
            this.lblADetallesConsulta.Text = "a";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // lblFechaDetallesConsulta
            // 
            this.lblFechaDetallesConsulta.AutoSize = true;
            this.lblFechaDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDetallesConsulta.Location = new System.Drawing.Point(144, 128);
            this.lblFechaDetallesConsulta.Name = "lblFechaDetallesConsulta";
            this.lblFechaDetallesConsulta.Size = new System.Drawing.Size(59, 20);
            this.lblFechaDetallesConsulta.TabIndex = 24;
            this.lblFechaDetallesConsulta.Text = "Fecha";
            // 
            // lblVeterinarioDetallesConsulta
            // 
            this.lblVeterinarioDetallesConsulta.AutoSize = true;
            this.lblVeterinarioDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinarioDetallesConsulta.Location = new System.Drawing.Point(144, 84);
            this.lblVeterinarioDetallesConsulta.Name = "lblVeterinarioDetallesConsulta";
            this.lblVeterinarioDetallesConsulta.Size = new System.Drawing.Size(97, 20);
            this.lblVeterinarioDetallesConsulta.TabIndex = 23;
            this.lblVeterinarioDetallesConsulta.Text = "Veterinario";
            // 
            // cboVeterinarioDetallesConsulta
            // 
            this.cboVeterinarioDetallesConsulta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usuariosBindingSource, "idUsuario", true));
            this.cboVeterinarioDetallesConsulta.DataSource = this.usuariosBindingSource;
            this.cboVeterinarioDetallesConsulta.DisplayMember = "nombre";
            this.cboVeterinarioDetallesConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeterinarioDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeterinarioDetallesConsulta.FormattingEnabled = true;
            this.cboVeterinarioDetallesConsulta.Location = new System.Drawing.Point(265, 81);
            this.cboVeterinarioDetallesConsulta.Name = "cboVeterinarioDetallesConsulta";
            this.cboVeterinarioDetallesConsulta.Size = new System.Drawing.Size(250, 28);
            this.cboVeterinarioDetallesConsulta.TabIndex = 22;
            this.cboVeterinarioDetallesConsulta.ValueMember = "idUsuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblPacienteDetallesConsulta
            // 
            this.lblPacienteDetallesConsulta.AutoSize = true;
            this.lblPacienteDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteDetallesConsulta.Location = new System.Drawing.Point(144, 36);
            this.lblPacienteDetallesConsulta.Name = "lblPacienteDetallesConsulta";
            this.lblPacienteDetallesConsulta.Size = new System.Drawing.Size(79, 20);
            this.lblPacienteDetallesConsulta.TabIndex = 21;
            this.lblPacienteDetallesConsulta.Text = "Paciente";
            // 
            // cboPacienteDetallesConsulta
            // 
            this.cboPacienteDetallesConsulta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.pacientesBindingSource, "idPaciente", true));
            this.cboPacienteDetallesConsulta.DataSource = this.pacientesBindingSource;
            this.cboPacienteDetallesConsulta.DisplayMember = "nombre";
            this.cboPacienteDetallesConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacienteDetallesConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacienteDetallesConsulta.FormattingEnabled = true;
            this.cboPacienteDetallesConsulta.Location = new System.Drawing.Point(265, 33);
            this.cboPacienteDetallesConsulta.Name = "cboPacienteDetallesConsulta";
            this.cboPacienteDetallesConsulta.Size = new System.Drawing.Size(250, 28);
            this.cboPacienteDetallesConsulta.TabIndex = 20;
            this.cboPacienteDetallesConsulta.ValueMember = "idPaciente";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agenda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboTratamientosDetallesConsulta;
        private System.Windows.Forms.Label lblTratamientosDetallesConsulta;
        private System.Windows.Forms.ListBox lboExamenesDetallesConsulta;
        private System.Windows.Forms.Label lblExamenesDetallesConsulta;
        private System.Windows.Forms.TextBox txtDiagnosticoDetallesConsulta;
        private System.Windows.Forms.Label lblDiagnosticoDetallesConsulta;
        private System.Windows.Forms.TextBox txtAnamnesisDetallesConsulta;
        private System.Windows.Forms.Label lblAnamnesisDetallesConsulta;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lblHoraDetallesConsulta;
        private System.Windows.Forms.Label lblHoraDeDetallesConsulta;
        private System.Windows.Forms.Label lblADetallesConsulta;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFechaDetallesConsulta;
        private System.Windows.Forms.Label lblVeterinarioDetallesConsulta;
        private System.Windows.Forms.ComboBox cboVeterinarioDetallesConsulta;
        private System.Windows.Forms.Label lblPacienteDetallesConsulta;
        private System.Windows.Forms.ComboBox cboPacienteDetallesConsulta;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}