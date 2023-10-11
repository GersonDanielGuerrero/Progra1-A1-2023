
namespace ProyectoFinal
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
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btNuevoPaciente = new System.Windows.Forms.Button();
            this.grbNavegacionPaciente = new System.Windows.Forms.GroupBox();
            this.btnUltimoPaciente = new System.Windows.Forms.Button();
            this.btnPrimeroPaciente = new System.Windows.Forms.Button();
            this.btnSiguientePaciente = new System.Windows.Forms.Button();
            this.btnAnteriorPaciente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grbInformacionPaciente = new System.Windows.Forms.GroupBox();
            this.txtRazaPaciente = new System.Windows.Forms.TextBox();
            this.txtEspeciePaciente = new System.Windows.Forms.TextBox();
            this.dtpNacimientoPaciente = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcionAdicionalPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColorPaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesoPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstaturaPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbListaPacientes = new System.Windows.Forms.GroupBox();
            this.cboOpcionBuscarPacientes = new System.Windows.Forms.ComboBox();
            this.txtBuscarPacientes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdListaPacientes = new System.Windows.Forms.DataGridView();
            this.erpPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.idPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionAdicional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbEdicionPaciente.SuspendLayout();
            this.grbNavegacionPaciente.SuspendLayout();
            this.grbInformacionPaciente.SuspendLayout();
            this.grbListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btNuevoPaciente);
            this.grbEdicionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionPaciente.Location = new System.Drawing.Point(710, 342);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(313, 100);
            this.grbEdicionPaciente.TabIndex = 16;
            this.grbEdicionPaciente.TabStop = false;
            this.grbEdicionPaciente.Text = "Edición";
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(211, 36);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(99, 57);
            this.btnEliminarPaciente.TabIndex = 5;
            this.btnEliminarPaciente.Text = "Eliminar paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click);
            // 
            // btnModificarPaciente
            // 
            this.btnModificarPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarPaciente.Location = new System.Drawing.Point(118, 36);
            this.btnModificarPaciente.Name = "btnModificarPaciente";
            this.btnModificarPaciente.Size = new System.Drawing.Size(87, 57);
            this.btnModificarPaciente.TabIndex = 4;
            this.btnModificarPaciente.Text = "Modificar datos";
            this.btnModificarPaciente.UseVisualStyleBackColor = true;
            this.btnModificarPaciente.Click += new System.EventHandler(this.btnModificarPaciente_Click);
            // 
            // btNuevoPaciente
            // 
            this.btNuevoPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btNuevoPaciente.Location = new System.Drawing.Point(9, 36);
            this.btNuevoPaciente.Name = "btNuevoPaciente";
            this.btNuevoPaciente.Size = new System.Drawing.Size(103, 57);
            this.btNuevoPaciente.TabIndex = 3;
            this.btNuevoPaciente.Text = "Nuevo paciente";
            this.btNuevoPaciente.UseVisualStyleBackColor = true;
            this.btNuevoPaciente.Click += new System.EventHandler(this.btNuevoPaciente_Click);
            // 
            // grbNavegacionPaciente
            // 
            this.grbNavegacionPaciente.Controls.Add(this.btnUltimoPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnPrimeroPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnSiguientePaciente);
            this.grbNavegacionPaciente.Controls.Add(this.btnAnteriorPaciente);
            this.grbNavegacionPaciente.Controls.Add(this.label5);
            this.grbNavegacionPaciente.Controls.Add(this.btnRegresar);
            this.grbNavegacionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionPaciente.Location = new System.Drawing.Point(502, 342);
            this.grbNavegacionPaciente.Name = "grbNavegacionPaciente";
            this.grbNavegacionPaciente.Size = new System.Drawing.Size(202, 100);
            this.grbNavegacionPaciente.TabIndex = 15;
            this.grbNavegacionPaciente.TabStop = false;
            this.grbNavegacionPaciente.Text = "Navegación";
            // 
            // btnUltimoPaciente
            // 
            this.btnUltimoPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUltimoPaciente.Location = new System.Drawing.Point(167, 25);
            this.btnUltimoPaciente.Name = "btnUltimoPaciente";
            this.btnUltimoPaciente.Size = new System.Drawing.Size(31, 33);
            this.btnUltimoPaciente.TabIndex = 5;
            this.btnUltimoPaciente.Text = ">|";
            this.btnUltimoPaciente.UseVisualStyleBackColor = true;
            this.btnUltimoPaciente.Click += new System.EventHandler(this.btnUltimoPaciente_Click);
            // 
            // btnPrimeroPaciente
            // 
            this.btnPrimeroPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimeroPaciente.Location = new System.Drawing.Point(6, 25);
            this.btnPrimeroPaciente.Name = "btnPrimeroPaciente";
            this.btnPrimeroPaciente.Size = new System.Drawing.Size(33, 33);
            this.btnPrimeroPaciente.TabIndex = 4;
            this.btnPrimeroPaciente.Text = "|<";
            this.btnPrimeroPaciente.UseVisualStyleBackColor = true;
            this.btnPrimeroPaciente.Click += new System.EventHandler(this.btnPrimeroPaciente_Click);
            // 
            // btnSiguientePaciente
            // 
            this.btnSiguientePaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSiguientePaciente.Location = new System.Drawing.Point(133, 25);
            this.btnSiguientePaciente.Name = "btnSiguientePaciente";
            this.btnSiguientePaciente.Size = new System.Drawing.Size(28, 33);
            this.btnSiguientePaciente.TabIndex = 3;
            this.btnSiguientePaciente.Text = ">";
            this.btnSiguientePaciente.UseVisualStyleBackColor = true;
            this.btnSiguientePaciente.Click += new System.EventHandler(this.btnSiguientePaciente_Click);
            // 
            // btnAnteriorPaciente
            // 
            this.btnAnteriorPaciente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnteriorPaciente.Location = new System.Drawing.Point(45, 25);
            this.btnAnteriorPaciente.Name = "btnAnteriorPaciente";
            this.btnAnteriorPaciente.Size = new System.Drawing.Size(28, 33);
            this.btnAnteriorPaciente.TabIndex = 2;
            this.btnAnteriorPaciente.Text = "<";
            this.btnAnteriorPaciente.UseVisualStyleBackColor = true;
            this.btnAnteriorPaciente.Click += new System.EventHandler(this.btnAnteriorPaciente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "x de n";
            // 
            // btnRegresar
            // 
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.Location = new System.Drawing.Point(62, 64);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(90, 29);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grbInformacionPaciente
            // 
            this.grbInformacionPaciente.Controls.Add(this.txtRazaPaciente);
            this.grbInformacionPaciente.Controls.Add(this.txtEspeciePaciente);
            this.grbInformacionPaciente.Controls.Add(this.dtpNacimientoPaciente);
            this.grbInformacionPaciente.Controls.Add(this.label9);
            this.grbInformacionPaciente.Controls.Add(this.label8);
            this.grbInformacionPaciente.Controls.Add(this.txtDescripcionAdicionalPaciente);
            this.grbInformacionPaciente.Controls.Add(this.label7);
            this.grbInformacionPaciente.Controls.Add(this.txtColorPaciente);
            this.grbInformacionPaciente.Controls.Add(this.label4);
            this.grbInformacionPaciente.Controls.Add(this.txtPesoPaciente);
            this.grbInformacionPaciente.Controls.Add(this.label3);
            this.grbInformacionPaciente.Controls.Add(this.txtEstaturaPaciente);
            this.grbInformacionPaciente.Controls.Add(this.label2);
            this.grbInformacionPaciente.Controls.Add(this.lblNombreCliente);
            this.grbInformacionPaciente.Controls.Add(this.txtNombrePaciente);
            this.grbInformacionPaciente.Controls.Add(this.label1);
            this.grbInformacionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacionPaciente.Location = new System.Drawing.Point(502, 13);
            this.grbInformacionPaciente.Name = "grbInformacionPaciente";
            this.grbInformacionPaciente.Size = new System.Drawing.Size(521, 323);
            this.grbInformacionPaciente.TabIndex = 14;
            this.grbInformacionPaciente.TabStop = false;
            this.grbInformacionPaciente.Text = "Información del paciente";
            // 
            // txtRazaPaciente
            // 
            this.txtRazaPaciente.Location = new System.Drawing.Point(93, 153);
            this.txtRazaPaciente.Name = "txtRazaPaciente";
            this.txtRazaPaciente.Size = new System.Drawing.Size(334, 26);
            this.txtRazaPaciente.TabIndex = 28;
            // 
            // txtEspeciePaciente
            // 
            this.txtEspeciePaciente.Location = new System.Drawing.Point(93, 124);
            this.txtEspeciePaciente.Name = "txtEspeciePaciente";
            this.txtEspeciePaciente.Size = new System.Drawing.Size(334, 26);
            this.txtEspeciePaciente.TabIndex = 27;
            // 
            // dtpNacimientoPaciente
            // 
            this.dtpNacimientoPaciente.Location = new System.Drawing.Point(181, 89);
            this.dtpNacimientoPaciente.Name = "dtpNacimientoPaciente";
            this.dtpNacimientoPaciente.Size = new System.Drawing.Size(284, 26);
            this.dtpNacimientoPaciente.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Especie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Raza";
            // 
            // txtDescripcionAdicionalPaciente
            // 
            this.txtDescripcionAdicionalPaciente.Location = new System.Drawing.Point(181, 285);
            this.txtDescripcionAdicionalPaciente.Name = "txtDescripcionAdicionalPaciente";
            this.txtDescripcionAdicionalPaciente.Size = new System.Drawing.Size(334, 26);
            this.txtDescripcionAdicionalPaciente.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Descripcion Adicional";
            // 
            // txtColorPaciente
            // 
            this.txtColorPaciente.Location = new System.Drawing.Point(101, 185);
            this.txtColorPaciente.Name = "txtColorPaciente";
            this.txtColorPaciente.Size = new System.Drawing.Size(219, 26);
            this.txtColorPaciente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Color";
            // 
            // txtPesoPaciente
            // 
            this.txtPesoPaciente.Location = new System.Drawing.Point(101, 249);
            this.txtPesoPaciente.Name = "txtPesoPaciente";
            this.txtPesoPaciente.Size = new System.Drawing.Size(77, 26);
            this.txtPesoPaciente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Peso";
            // 
            // txtEstaturaPaciente
            // 
            this.txtEstaturaPaciente.Location = new System.Drawing.Point(102, 217);
            this.txtEstaturaPaciente.Name = "txtEstaturaPaciente";
            this.txtEstaturaPaciente.Size = new System.Drawing.Size(76, 26);
            this.txtEstaturaPaciente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estatura";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(18, 60);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(65, 20);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(93, 57);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(372, 26);
            this.txtNombrePaciente.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // grbListaPacientes
            // 
            this.grbListaPacientes.Controls.Add(this.cboOpcionBuscarPacientes);
            this.grbListaPacientes.Controls.Add(this.txtBuscarPacientes);
            this.grbListaPacientes.Controls.Add(this.label6);
            this.grbListaPacientes.Controls.Add(this.grdListaPacientes);
            this.grbListaPacientes.Location = new System.Drawing.Point(12, 12);
            this.grbListaPacientes.Name = "grbListaPacientes";
            this.grbListaPacientes.Size = new System.Drawing.Size(484, 498);
            this.grbListaPacientes.TabIndex = 13;
            this.grbListaPacientes.TabStop = false;
            this.grbListaPacientes.Text = "Lista de Pacientes";
            // 
            // cboOpcionBuscarPacientes
            // 
            this.cboOpcionBuscarPacientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarPacientes.FormattingEnabled = true;
            this.cboOpcionBuscarPacientes.Items.AddRange(new object[] {
            "Nombre",
            "Estatura",
            "Peso",
            "Color",
            "Especie",
            "Raza",
            "Descripcion adicional"});
            this.cboOpcionBuscarPacientes.Location = new System.Drawing.Point(49, 47);
            this.cboOpcionBuscarPacientes.Name = "cboOpcionBuscarPacientes";
            this.cboOpcionBuscarPacientes.Size = new System.Drawing.Size(101, 21);
            this.cboOpcionBuscarPacientes.TabIndex = 19;
            // 
            // txtBuscarPacientes
            // 
            this.txtBuscarPacientes.Location = new System.Drawing.Point(156, 47);
            this.txtBuscarPacientes.Name = "txtBuscarPacientes";
            this.txtBuscarPacientes.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarPacientes.TabIndex = 18;
            this.txtBuscarPacientes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPacientes_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar:";
            // 
            // grdListaPacientes
            // 
            this.grdListaPacientes.AllowUserToAddRows = false;
            this.grdListaPacientes.AllowUserToDeleteRows = false;
            this.grdListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPaciente,
            this.nombre,
            this.fechaNacimiento,
            this.estatura,
            this.peso,
            this.color,
            this.especie,
            this.raza,
            this.descripcionAdicional});
            this.grdListaPacientes.Location = new System.Drawing.Point(-43, 73);
            this.grdListaPacientes.Name = "grdListaPacientes";
            this.grdListaPacientes.ReadOnly = true;
            this.grdListaPacientes.Size = new System.Drawing.Size(527, 425);
            this.grdListaPacientes.TabIndex = 1;
            this.grdListaPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaPacientes_CellClick);
            // 
            // erpPaciente
            // 
            this.erpPaciente.ContainerControl = this;
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
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "FECHA DE NACIMIENTO";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Visible = false;
            // 
            // estatura
            // 
            this.estatura.DataPropertyName = "estatura";
            this.estatura.HeaderText = "ESTATURA";
            this.estatura.Name = "estatura";
            this.estatura.ReadOnly = true;
            this.estatura.Width = 70;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "peso";
            this.peso.HeaderText = "PESO";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            this.peso.Width = 50;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "COLOR";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // especie
            // 
            this.especie.DataPropertyName = "especie";
            this.especie.HeaderText = "ESPECIE";
            this.especie.Name = "especie";
            this.especie.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.DataPropertyName = "raza";
            this.raza.HeaderText = "RAZA";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // descripcionAdicional
            // 
            this.descripcionAdicional.DataPropertyName = "descripcionAdicional";
            this.descripcionAdicional.HeaderText = "DESCRIPCION ADICIONAL";
            this.descripcionAdicional.Name = "descripcionAdicional";
            this.descripcionAdicional.ReadOnly = true;
            this.descripcionAdicional.Width = 500;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRegresar;
            this.ClientSize = new System.Drawing.Size(1046, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbNavegacionPaciente);
            this.Controls.Add(this.grbInformacionPaciente);
            this.Controls.Add(this.grbListaPacientes);
            this.Name = "Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.grbEdicionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.ResumeLayout(false);
            this.grbNavegacionPaciente.PerformLayout();
            this.grbInformacionPaciente.ResumeLayout(false);
            this.grbInformacionPaciente.PerformLayout();
            this.grbListaPacientes.ResumeLayout(false);
            this.grbListaPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btNuevoPaciente;
        private System.Windows.Forms.GroupBox grbNavegacionPaciente;
        private System.Windows.Forms.Button btnUltimoPaciente;
        private System.Windows.Forms.Button btnPrimeroPaciente;
        private System.Windows.Forms.Button btnSiguientePaciente;
        private System.Windows.Forms.Button btnAnteriorPaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grbInformacionPaciente;
        private System.Windows.Forms.TextBox txtColorPaciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesoPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstaturaPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbListaPacientes;
        private System.Windows.Forms.DataGridView grdListaPacientes;
        private System.Windows.Forms.ComboBox cboOpcionBuscarPacientes;
        private System.Windows.Forms.TextBox txtBuscarPacientes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescripcionAdicionalPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpNacimientoPaciente;
        private System.Windows.Forms.TextBox txtRazaPaciente;
        private System.Windows.Forms.TextBox txtEspeciePaciente;
        private System.Windows.Forms.ErrorProvider erpPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionAdicional;
    }
}