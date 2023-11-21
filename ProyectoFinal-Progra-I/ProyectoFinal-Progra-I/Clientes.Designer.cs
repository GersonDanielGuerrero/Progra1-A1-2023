
namespace ProyectoFinal_Progra_I
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.dtpNacimietoCliente = new System.Windows.Forms.DateTimePicker();
            this.dtpRegistroCliente = new System.Windows.Forms.DateTimePicker();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.cboOpcionBuscarCliente = new System.Windows.Forms.ComboBox();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnPrimeroCliente = new System.Windows.Forms.Button();
            this.btnUltimoCliente = new System.Windows.Forms.Button();
            this.btnSiguienteCliente = new System.Windows.Forms.Button();
            this.btnAnteriorCliente = new System.Windows.Forms.Button();
            this.lblPosicionCliente = new System.Windows.Forms.Label();
            this.grbEdicionCliente = new System.Windows.Forms.GroupBox();
            this.grbNavegacionCliente = new System.Windows.Forms.GroupBox();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.erpClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.clientesTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.clientesTableAdapter();
            this.pacientesTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            this.grbEdicionCliente.SuspendLayout();
            this.grbNavegacionCliente.SuspendLayout();
            this.grbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo electrónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de registro";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "nombre", true));
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(195, 49);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(430, 26);
            this.txtNombreCliente.TabIndex = 8;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "correo", true));
            this.txtCorreoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCliente.Location = new System.Drawing.Point(195, 213);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(430, 26);
            this.txtCorreoCliente.TabIndex = 9;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "direccion", true));
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(195, 155);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(430, 26);
            this.txtDireccionCliente.TabIndex = 10;
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "telefono", true));
            this.txtTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCliente.Location = new System.Drawing.Point(195, 99);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(430, 26);
            this.txtTelefonoCliente.TabIndex = 11;
            // 
            // dtpNacimietoCliente
            // 
            this.dtpNacimietoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fechaNacimiento", true));
            this.dtpNacimietoCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "fechaNacimiento", true));
            this.dtpNacimietoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimietoCliente.Location = new System.Drawing.Point(194, 408);
            this.dtpNacimietoCliente.Name = "dtpNacimietoCliente";
            this.dtpNacimietoCliente.Size = new System.Drawing.Size(336, 26);
            this.dtpNacimietoCliente.TabIndex = 12;
            // 
            // dtpRegistroCliente
            // 
            this.dtpRegistroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "fechaRegistro", true));
            this.dtpRegistroCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "fechaRegistro", true));
            this.dtpRegistroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRegistroCliente.Location = new System.Drawing.Point(195, 457);
            this.dtpRegistroCliente.Name = "dtpRegistroCliente";
            this.dtpRegistroCliente.Size = new System.Drawing.Size(336, 26);
            this.dtpRegistroCliente.TabIndex = 13;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(267, 84);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarCliente.TabIndex = 14;
            // 
            // cboOpcionBuscarCliente
            // 
            this.cboOpcionBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarCliente.FormattingEnabled = true;
            this.cboOpcionBuscarCliente.Items.AddRange(new object[] {
            "Nombre",
            "Dirección",
            "Correo",
            "Teléfono",
            "Fecha de nacimiento",
            "Fecha de registro"});
            this.cboOpcionBuscarCliente.Location = new System.Drawing.Point(98, 84);
            this.cboOpcionBuscarCliente.Name = "cboOpcionBuscarCliente";
            this.cboOpcionBuscarCliente.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarCliente.TabIndex = 15;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCliente.Location = new System.Drawing.Point(112, 19);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(90, 55);
            this.btnModificarCliente.TabIndex = 16;
            this.btnModificarCliente.Text = "Modificar datos";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarCliente.TabIndex = 17;
            this.btnEliminarCliente.Text = "Eliminar Cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = false;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCliente.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoCliente.TabIndex = 18;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnPrimeroCliente
            // 
            this.btnPrimeroCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroCliente.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroCliente.Name = "btnPrimeroCliente";
            this.btnPrimeroCliente.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroCliente.TabIndex = 19;
            this.btnPrimeroCliente.Text = "|<";
            this.btnPrimeroCliente.UseVisualStyleBackColor = false;
            this.btnPrimeroCliente.Click += new System.EventHandler(this.btnPrimeroCliente_Click);
            // 
            // btnUltimoCliente
            // 
            this.btnUltimoCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCliente.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoCliente.Name = "btnUltimoCliente";
            this.btnUltimoCliente.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoCliente.TabIndex = 20;
            this.btnUltimoCliente.Text = ">|";
            this.btnUltimoCliente.UseVisualStyleBackColor = false;
            this.btnUltimoCliente.Click += new System.EventHandler(this.btnUltimoCliente_Click);
            // 
            // btnSiguienteCliente
            // 
            this.btnSiguienteCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteCliente.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteCliente.Name = "btnSiguienteCliente";
            this.btnSiguienteCliente.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteCliente.TabIndex = 21;
            this.btnSiguienteCliente.Text = ">";
            this.btnSiguienteCliente.UseVisualStyleBackColor = false;
            this.btnSiguienteCliente.Click += new System.EventHandler(this.btnSiguienteCliente_Click);
            // 
            // btnAnteriorCliente
            // 
            this.btnAnteriorCliente.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCliente.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorCliente.Name = "btnAnteriorCliente";
            this.btnAnteriorCliente.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorCliente.TabIndex = 22;
            this.btnAnteriorCliente.Text = "<";
            this.btnAnteriorCliente.UseVisualStyleBackColor = false;
            this.btnAnteriorCliente.Click += new System.EventHandler(this.btnAnteriorCliente_Click);
            // 
            // lblPosicionCliente
            // 
            this.lblPosicionCliente.AutoSize = true;
            this.lblPosicionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionCliente.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionCliente.Name = "lblPosicionCliente";
            this.lblPosicionCliente.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionCliente.TabIndex = 23;
            this.lblPosicionCliente.Text = "x de n";
            // 
            // grbEdicionCliente
            // 
            this.grbEdicionCliente.Controls.Add(this.btnNuevoCliente);
            this.grbEdicionCliente.Controls.Add(this.btnModificarCliente);
            this.grbEdicionCliente.Controls.Add(this.btnEliminarCliente);
            this.grbEdicionCliente.Location = new System.Drawing.Point(116, 523);
            this.grbEdicionCliente.Name = "grbEdicionCliente";
            this.grbEdicionCliente.Size = new System.Drawing.Size(331, 82);
            this.grbEdicionCliente.TabIndex = 24;
            this.grbEdicionCliente.TabStop = false;
            this.grbEdicionCliente.Text = "Edición";
            // 
            // grbNavegacionCliente
            // 
            this.grbNavegacionCliente.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionCliente.Controls.Add(this.btnPrimeroCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnAnteriorCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnUltimoCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnSiguienteCliente);
            this.grbNavegacionCliente.Controls.Add(this.lblPosicionCliente);
            this.grbNavegacionCliente.Location = new System.Drawing.Point(131, 439);
            this.grbNavegacionCliente.Name = "grbNavegacionCliente";
            this.grbNavegacionCliente.Size = new System.Drawing.Size(278, 82);
            this.grbNavegacionCliente.TabIndex = 25;
            this.grbNavegacionCliente.TabStop = false;
            this.grbNavegacionCliente.Text = "Navegación";
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Controls.Add(this.listBox1);
            this.grbDatosCliente.Controls.Add(this.label9);
            this.grbDatosCliente.Controls.Add(this.txtTelefonoCliente);
            this.grbDatosCliente.Controls.Add(this.txtDireccionCliente);
            this.grbDatosCliente.Controls.Add(this.txtCorreoCliente);
            this.grbDatosCliente.Controls.Add(this.txtNombreCliente);
            this.grbDatosCliente.Controls.Add(this.dtpNacimietoCliente);
            this.grbDatosCliente.Controls.Add(this.label7);
            this.grbDatosCliente.Controls.Add(this.label6);
            this.grbDatosCliente.Controls.Add(this.dtpRegistroCliente);
            this.grbDatosCliente.Controls.Add(this.label5);
            this.grbDatosCliente.Controls.Add(this.label2);
            this.grbDatosCliente.Controls.Add(this.label4);
            this.grbDatosCliente.Controls.Add(this.label3);
            this.grbDatosCliente.Location = new System.Drawing.Point(536, 66);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(657, 539);
            this.grbDatosCliente.TabIndex = 26;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.pacientesBindingSource;
            this.listBox1.DisplayMember = "nombre";
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(195, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 104);
            this.listBox1.TabIndex = 20;
            this.listBox1.ValueMember = "nombre";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Pacientes registrados";
            // 
            // erpClientes
            // 
            this.erpClientes.ContainerControl = this;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.coloresTableAdapter = null;
            this.tableAdapterManager.especiesTableAdapter = null;
            this.tableAdapterManager.fallecimientosTableAdapter = null;
            this.tableAdapterManager.marcasTableAdapter = null;
            this.tableAdapterManager.pacientes_coloresTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.principiosActivosTableAdapter = null;
            this.tableAdapterManager.productos_principiosActivosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.razasTableAdapter = null;
            this.tableAdapterManager.tipoProductoTableAdapter = null;
            this.tableAdapterManager.tipoServiciosTableAdapter = null;
            this.tableAdapterManager.tratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(12, 66);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(504, 367);
            this.clientesDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "idCliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn4.HeaderText = "correo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechaNacimiento";
            this.dataGridViewTextBoxColumn6.HeaderText = "fechaNacimiento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fechaRegistro";
            this.dataGridViewTextBoxColumn7.HeaderText = "fechaRegistro";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "foto";
            this.dataGridViewImageColumn1.HeaderText = "foto";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Visible = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.ControlBox = false;
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.grbNavegacionCliente);
            this.Controls.Add(this.grbEdicionCliente);
            this.Controls.Add(this.cboOpcionBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            this.grbEdicionCliente.ResumeLayout(false);
            this.grbNavegacionCliente.ResumeLayout(false);
            this.grbNavegacionCliente.PerformLayout();
            this.grbDatosCliente.ResumeLayout(false);
            this.grbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.DateTimePicker dtpNacimietoCliente;
        private System.Windows.Forms.DateTimePicker dtpRegistroCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ComboBox cboOpcionBuscarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnPrimeroCliente;
        private System.Windows.Forms.Button btnUltimoCliente;
        private System.Windows.Forms.Button btnSiguienteCliente;
        private System.Windows.Forms.Button btnAnteriorCliente;
        private System.Windows.Forms.Label lblPosicionCliente;
        private System.Windows.Forms.GroupBox grbEdicionCliente;
        private System.Windows.Forms.GroupBox grbNavegacionCliente;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.ErrorProvider erpClientes;
        private System.Windows.Forms.Label label9;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}