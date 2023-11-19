
namespace ProyectoFinal_Progra_I
{
    partial class Pacientes
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
            this.cboOpcionBuscarPaciente = new System.Windows.Forms.ComboBox();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDatosPaciente = new System.Windows.Forms.GroupBox();
            this.rdoMachoPaciente = new System.Windows.Forms.RadioButton();
            this.rdoHembraPaciente = new System.Windows.Forms.RadioButton();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.cboTutorPaciente = new System.Windows.Forms.ComboBox();
            this.lblTutorPaciente = new System.Windows.Forms.Label();
            this.cboEspeciePaciente = new System.Windows.Forms.ComboBox();
            this.cboColorPaciente = new System.Windows.Forms.ComboBox();
            this.cboRazaPaciente = new System.Windows.Forms.ComboBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionPaciente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpNacimietoPaciente = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpRegistroPaciente = new System.Windows.Forms.DateTimePicker();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnSiguientePaciente = new System.Windows.Forms.Button();
            this.lblPosicionPaciente = new System.Windows.Forms.Label();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.erpPacientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.grdDatosPacientes = new System.Windows.Forms.DataGridView();
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            this.grbEdicionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cboOpcionBuscarPaciente
            // 
            this.cboOpcionBuscarPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarPaciente.FormattingEnabled = true;
            this.cboOpcionBuscarPaciente.Items.AddRange(new object[] {
            "Nombre",
            "Especie",
            "Raza",
            "Color",
            "Estatura",
            "Peso",
            "Descripcion"});
            this.cboOpcionBuscarPaciente.Location = new System.Drawing.Point(94, 56);
            this.cboOpcionBuscarPaciente.Name = "cboOpcionBuscarPaciente";
            this.cboOpcionBuscarPaciente.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarPaciente.TabIndex = 19;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.Location = new System.Drawing.Point(263, 56);
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarPaciente.TabIndex = 18;
            this.txtBuscarPaciente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPaciente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar";
            // 
            // grbDatosPaciente
            // 
            this.grbDatosPaciente.Controls.Add(this.rdoMachoPaciente);
            this.grbDatosPaciente.Controls.Add(this.rdoHembraPaciente);
            this.grbDatosPaciente.Controls.Add(this.lblSexoPaciente);
            this.grbDatosPaciente.Controls.Add(this.cboTutorPaciente);
            this.grbDatosPaciente.Controls.Add(this.lblTutorPaciente);
            this.grbDatosPaciente.Controls.Add(this.cboEspeciePaciente);
            this.grbDatosPaciente.Controls.Add(this.cboColorPaciente);
            this.grbDatosPaciente.Controls.Add(this.cboRazaPaciente);
            this.grbDatosPaciente.Controls.Add(this.txtNombrePaciente);
            this.grbDatosPaciente.Controls.Add(this.label5);
            this.grbDatosPaciente.Controls.Add(this.label2);
            this.grbDatosPaciente.Controls.Add(this.label4);
            this.grbDatosPaciente.Controls.Add(this.label3);
            this.grbDatosPaciente.Controls.Add(this.txtDescripcionPaciente);
            this.grbDatosPaciente.Controls.Add(this.label10);
            this.grbDatosPaciente.Controls.Add(this.dtpNacimietoPaciente);
            this.grbDatosPaciente.Controls.Add(this.label7);
            this.grbDatosPaciente.Controls.Add(this.label6);
            this.grbDatosPaciente.Controls.Add(this.dtpRegistroPaciente);
            this.grbDatosPaciente.Location = new System.Drawing.Point(529, 56);
            this.grbDatosPaciente.Name = "grbDatosPaciente";
            this.grbDatosPaciente.Size = new System.Drawing.Size(657, 472);
            this.grbDatosPaciente.TabIndex = 27;
            this.grbDatosPaciente.TabStop = false;
            this.grbDatosPaciente.Text = "Datos del paciente";
            // 
            // rdoMachoPaciente
            // 
            this.rdoMachoPaciente.AutoSize = true;
            this.rdoMachoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMachoPaciente.Location = new System.Drawing.Point(297, 305);
            this.rdoMachoPaciente.Name = "rdoMachoPaciente";
            this.rdoMachoPaciente.Size = new System.Drawing.Size(80, 24);
            this.rdoMachoPaciente.TabIndex = 40;
            this.rdoMachoPaciente.TabStop = true;
            this.rdoMachoPaciente.Text = "Macho";
            this.rdoMachoPaciente.UseVisualStyleBackColor = true;
            // 
            // rdoHembraPaciente
            // 
            this.rdoHembraPaciente.AutoSize = true;
            this.rdoHembraPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHembraPaciente.Location = new System.Drawing.Point(197, 303);
            this.rdoHembraPaciente.Name = "rdoHembraPaciente";
            this.rdoHembraPaciente.Size = new System.Drawing.Size(90, 24);
            this.rdoHembraPaciente.TabIndex = 39;
            this.rdoHembraPaciente.TabStop = true;
            this.rdoHembraPaciente.Text = "Hembra";
            this.rdoHembraPaciente.UseVisualStyleBackColor = true;
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoPaciente.Location = new System.Drawing.Point(131, 305);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(49, 20);
            this.lblSexoPaciente.TabIndex = 38;
            this.lblSexoPaciente.Text = "Sexo";
            // 
            // cboTutorPaciente
            // 
            this.cboTutorPaciente.Enabled = false;
            this.cboTutorPaciente.FormattingEnabled = true;
            this.cboTutorPaciente.Location = new System.Drawing.Point(197, 139);
            this.cboTutorPaciente.Name = "cboTutorPaciente";
            this.cboTutorPaciente.Size = new System.Drawing.Size(430, 21);
            this.cboTutorPaciente.TabIndex = 37;
            // 
            // lblTutorPaciente
            // 
            this.lblTutorPaciente.AutoSize = true;
            this.lblTutorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorPaciente.Location = new System.Drawing.Point(131, 140);
            this.lblTutorPaciente.Name = "lblTutorPaciente";
            this.lblTutorPaciente.Size = new System.Drawing.Size(51, 20);
            this.lblTutorPaciente.TabIndex = 36;
            this.lblTutorPaciente.Text = "Tutor";
            // 
            // cboEspeciePaciente
            // 
            this.cboEspeciePaciente.Enabled = false;
            this.cboEspeciePaciente.FormattingEnabled = true;
            this.cboEspeciePaciente.Location = new System.Drawing.Point(195, 175);
            this.cboEspeciePaciente.Name = "cboEspeciePaciente";
            this.cboEspeciePaciente.Size = new System.Drawing.Size(430, 21);
            this.cboEspeciePaciente.TabIndex = 35;
            // 
            // cboColorPaciente
            // 
            this.cboColorPaciente.Enabled = false;
            this.cboColorPaciente.FormattingEnabled = true;
            this.cboColorPaciente.Location = new System.Drawing.Point(195, 266);
            this.cboColorPaciente.Name = "cboColorPaciente";
            this.cboColorPaciente.Size = new System.Drawing.Size(430, 21);
            this.cboColorPaciente.TabIndex = 34;
            // 
            // cboRazaPaciente
            // 
            this.cboRazaPaciente.Enabled = false;
            this.cboRazaPaciente.FormattingEnabled = true;
            this.cboRazaPaciente.Location = new System.Drawing.Point(195, 219);
            this.cboRazaPaciente.Name = "cboRazaPaciente";
            this.cboRazaPaciente.Size = new System.Drawing.Size(430, 21);
            this.cboRazaPaciente.TabIndex = 33;
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.Location = new System.Drawing.Point(195, 86);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.ReadOnly = true;
            this.txtNombrePaciente.Size = new System.Drawing.Size(430, 26);
            this.txtNombrePaciente.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Especie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Raza";
            // 
            // txtDescripcionPaciente
            // 
            this.txtDescripcionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPaciente.Location = new System.Drawing.Point(195, 440);
            this.txtDescripcionPaciente.Name = "txtDescripcionPaciente";
            this.txtDescripcionPaciente.ReadOnly = true;
            this.txtDescripcionPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtDescripcionPaciente.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descripción adicional";
            // 
            // dtpNacimietoPaciente
            // 
            this.dtpNacimietoPaciente.Enabled = false;
            this.dtpNacimietoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimietoPaciente.Location = new System.Drawing.Point(195, 351);
            this.dtpNacimietoPaciente.Name = "dtpNacimietoPaciente";
            this.dtpNacimietoPaciente.Size = new System.Drawing.Size(336, 26);
            this.dtpNacimietoPaciente.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // dtpRegistroPaciente
            // 
            this.dtpRegistroPaciente.Enabled = false;
            this.dtpRegistroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistroPaciente.Location = new System.Drawing.Point(195, 394);
            this.dtpRegistroPaciente.Name = "dtpRegistroPaciente";
            this.dtpRegistroPaciente.Size = new System.Drawing.Size(336, 26);
            this.dtpRegistroPaciente.TabIndex = 13;
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnSiguientePaciente);
            this.grbNavegacionPaciente.Controls.Add(this.lblPosicionPaciente);
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(906, 554);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(280, 82);
            this.grbNavegacionPaciente.TabIndex = 29;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegación";
            // 
            // btnPrimeroPaciente
            // 
            this.btnPrimeroPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroPaciente.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroPaciente.Name = "btnPrimeroPaciente";
            this.btnPrimeroPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroPaciente.TabIndex = 19;
            this.btnPrimeroPaciente.Text = "|<";
            this.btnPrimeroPaciente.UseVisualStyleBackColor = false;
            this.btnPrimeroPaciente.Click += new System.EventHandler(this.btnPrimeroPaciente_Click);
            // 
            // btnAnteriorPaciente
            // 
            this.btnAnteriorPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPaciente.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorPaciente.Name = "btnAnteriorPaciente";
            this.btnAnteriorPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorPaciente.TabIndex = 22;
            this.btnAnteriorPaciente.Text = "<";
            this.btnAnteriorPaciente.UseVisualStyleBackColor = false;
            this.btnAnteriorPaciente.Click += new System.EventHandler(this.btnAnteriorPaciente_Click);
            // 
            // btnUltimoPaciente
            // 
            this.btnUltimoPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoPaciente.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoPaciente.Name = "btnUltimoPaciente";
            this.btnUltimoPaciente.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoPaciente.TabIndex = 20;
            this.btnUltimoPaciente.Text = ">|";
            this.btnUltimoPaciente.UseVisualStyleBackColor = false;
            this.btnUltimoPaciente.Click += new System.EventHandler(this.btnUltimoPaciente_Click);
            // 
            // btnSiguientePaciente
            // 
            this.btnSiguientePaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguientePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePaciente.Location = new System.Drawing.Point(188, 31);
            this.btnSiguientePaciente.Name = "btnSiguientePaciente";
            this.btnSiguientePaciente.Size = new System.Drawing.Size(37, 30);
            this.btnSiguientePaciente.TabIndex = 21;
            this.btnSiguientePaciente.Text = ">";
            this.btnSiguientePaciente.UseVisualStyleBackColor = false;
            this.btnSiguientePaciente.Click += new System.EventHandler(this.btnSiguientePaciente_Click);
            // 
            // lblPosicionPaciente
            // 
            this.lblPosicionPaciente.AutoSize = true;
            this.lblPosicionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionPaciente.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionPaciente.Name = "lblPosicionPaciente";
            this.lblPosicionPaciente.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionPaciente.TabIndex = 23;
            this.lblPosicionPaciente.Text = "x de n";
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(529, 554);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionPaciente.TabIndex = 28;
            this.grbEdicionPaciente.TabStop = false;
            this.grbEdicionPaciente.Text = "Edición";
            // 
            // btnNuevoPaciente
            // 
            this.btnNuevoPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPaciente.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoPaciente.Name = "btnNuevoPaciente";
            this.btnNuevoPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoPaciente.TabIndex = 18;
            this.btnNuevoPaciente.Text = "Nuevo paciente";
            this.btnNuevoPaciente.UseVisualStyleBackColor = false;
            this.btnNuevoPaciente.Click += new System.EventHandler(this.btnNuevoPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPaciente.Location = new System.Drawing.Point(112, 19);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnModificarPaciente.TabIndex = 16;
            this.btnModificarPaciente.Text = "Modificar datos";
            this.btnModificarPaciente.UseVisualStyleBackColor = false;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarPaciente.TabIndex = 17;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = false;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // erpPacientes
            // 
            this.erpPacientes.ContainerControl = this;
            // 
            // grdDatosPacientes
            // 
            this.grdDatosPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.nombre,
            this.tutor,
            this.especie,
            this.raza,
            this.color,
            this.sexo,
            this.fechaRegistro,
            this.fechaNacimiento,
            this.descripcion});
            this.grdDatosPacientes.Location = new System.Drawing.Point(27, 106);
            this.grdDatosPacientes.Name = "grdDatosPacientes";
            this.grdDatosPacientes.Size = new System.Drawing.Size(490, 522);
            this.grdDatosPacientes.TabIndex = 30;
            // 
            // idPaciente
            // 
            this.idPaciente.DataPropertyName = "idPaciente";
            this.idPaciente.HeaderText = "ID";
            this.idPaciente.Name = "idPaciente";
            this.idPaciente.ReadOnly = true;
            this.idPaciente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // tutor
            // 
            this.tutor.DataPropertyName = "tutor";
            this.tutor.HeaderText = "Tutor";
            this.tutor.Name = "tutor";
            this.tutor.ReadOnly = true;
            this.tutor.Width = 50;
            // 
            // especie
            // 
            this.especie.DataPropertyName = "especie";
            this.especie.HeaderText = "Especie";
            this.especie.Name = "especie";
            this.especie.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.DataPropertyName = "raza";
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 50;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "Fecha de registro";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción adicional";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 500;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grdDatosPacientes);
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbDatosPaciente);
            this.Controls.Add(this.cboOpcionBuscarPaciente);
            this.Controls.Add(this.txtBuscarPaciente);
            this.Controls.Add(this.label1);
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.grbDatosPaciente.ResumeLayout(false);
            this.grbDatosPaciente.PerformLayout();
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            this.grbEdicionPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboOpcionBuscarPaciente;
        private System.Windows.Forms.TextBox txtBuscarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDatosPaciente;
        private System.Windows.Forms.DateTimePicker dtpNacimietoPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpRegistroPaciente;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnSiguientePaciente;
        private System.Windows.Forms.Label lblPosicionPaciente;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.TextBox txtDescripcionPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider erpPacientes;
        private System.Windows.Forms.RadioButton rdoMachoPaciente;
        private System.Windows.Forms.RadioButton rdoHembraPaciente;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.ComboBox cboTutorPaciente;
        private System.Windows.Forms.Label lblTutorPaciente;
        private System.Windows.Forms.ComboBox cboEspeciePaciente;
        private System.Windows.Forms.ComboBox cboColorPaciente;
        private System.Windows.Forms.ComboBox cboRazaPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdDatosPacientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}