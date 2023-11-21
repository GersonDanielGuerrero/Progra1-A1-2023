
namespace ProyectoFinal_Progra_I
{
    partial class Tratamientos
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadTratamiento = new System.Windows.Forms.TextBox();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDosisTratamiento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDeNacimientoUsuario = new System.Windows.Forms.Label();
            this.dateFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tratamientosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.tratamientosTableAdapter();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.productosTableAdapter();
            this.grbDetallesTratamiento = new System.Windows.Forms.GroupBox();
            this.cboProductoTratamiento = new System.Windows.Forms.ComboBox();
            this.cboPacienteTratamiento = new System.Windows.Forms.ComboBox();
            this.grbNavegacionTratamiento = new System.Windows.Forms.GroupBox();
            this.btnPrimeroTratamiento = new System.Windows.Forms.Button();
            this.btnAnteriorTratamiento = new System.Windows.Forms.Button();
            this.btnUltimoTratamiento = new System.Windows.Forms.Button();
            this.btnSiguienteTratamiento = new System.Windows.Forms.Button();
            this.lblPosicionTratamiento = new System.Windows.Forms.Label();
            this.grbEdicionTratamiento = new System.Windows.Forms.GroupBox();
            this.btnNuevoTratamiento = new System.Windows.Forms.Button();
            this.btnModificarTratamiento = new System.Windows.Forms.Button();
            this.btnEliminarTratamiento = new System.Windows.Forms.Button();
            this.detalleTratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleTratamientosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.detalleTratamientosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager();
            this.detalleTratamientosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboOpcionBuscarTratamiento = new System.Windows.Forms.ComboBox();
            this.txtBuscarTratamiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.grbDetallesTratamiento.SuspendLayout();
            this.grbNavegacionTratamiento.SuspendLayout();
            this.grbEdicionTratamiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTratamientosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Producto";
            // 
            // txtCantidadTratamiento
            // 
            this.txtCantidadTratamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "cantidad", true));
            this.txtCantidadTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadTratamiento.Location = new System.Drawing.Point(196, 170);
            this.txtCantidadTratamiento.Name = "txtCantidadTratamiento";
            this.txtCantidadTratamiento.Size = new System.Drawing.Size(53, 26);
            this.txtCantidadTratamiento.TabIndex = 38;
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "tratamientos";
            this.tratamientosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cantidad";
            // 
            // txtDosisTratamiento
            // 
            this.txtDosisTratamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "dosis", true));
            this.txtDosisTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDosisTratamiento.Location = new System.Drawing.Point(190, 239);
            this.txtDosisTratamiento.Name = "txtDosisTratamiento";
            this.txtDosisTratamiento.Size = new System.Drawing.Size(430, 26);
            this.txtDosisTratamiento.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dosis";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "fechaInicio", true));
            this.dtpFechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamientosBindingSource, "fechaInicio", true));
            this.dtpFechaInicio.Enabled = false;
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(196, 308);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(336, 26);
            this.dtpFechaInicio.TabIndex = 44;
            // 
            // lblFechaDeNacimientoUsuario
            // 
            this.lblFechaDeNacimientoUsuario.AutoSize = true;
            this.lblFechaDeNacimientoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDeNacimientoUsuario.Location = new System.Drawing.Point(12, 313);
            this.lblFechaDeNacimientoUsuario.Name = "lblFechaDeNacimientoUsuario";
            this.lblFechaDeNacimientoUsuario.Size = new System.Drawing.Size(178, 20);
            this.lblFechaDeNacimientoUsuario.TabIndex = 43;
            this.lblFechaDeNacimientoUsuario.Text = "Inicio del tratamiento";
            // 
            // dateFechaFin
            // 
            this.dateFechaFin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "fechaFin", true));
            this.dateFechaFin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamientosBindingSource, "fechaFin", true));
            this.dateFechaFin.Enabled = false;
            this.dateFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaFin.Location = new System.Drawing.Point(196, 380);
            this.dateFechaFin.Name = "dateFechaFin";
            this.dateFechaFin.Size = new System.Drawing.Size(336, 26);
            this.dateFechaFin.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Fin del tratamiento";
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
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
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // grbDetallesTratamiento
            // 
            this.grbDetallesTratamiento.Controls.Add(this.cboProductoTratamiento);
            this.grbDetallesTratamiento.Controls.Add(this.cboPacienteTratamiento);
            this.grbDetallesTratamiento.Controls.Add(this.txtDosisTratamiento);
            this.grbDetallesTratamiento.Controls.Add(this.dtpFechaInicio);
            this.grbDetallesTratamiento.Controls.Add(this.dateFechaFin);
            this.grbDetallesTratamiento.Controls.Add(this.label4);
            this.grbDetallesTratamiento.Controls.Add(this.label1);
            this.grbDetallesTratamiento.Controls.Add(this.label2);
            this.grbDetallesTratamiento.Controls.Add(this.label5);
            this.grbDetallesTratamiento.Controls.Add(this.label3);
            this.grbDetallesTratamiento.Controls.Add(this.txtCantidadTratamiento);
            this.grbDetallesTratamiento.Controls.Add(this.lblFechaDeNacimientoUsuario);
            this.grbDetallesTratamiento.Location = new System.Drawing.Point(529, 56);
            this.grbDetallesTratamiento.Name = "grbDetallesTratamiento";
            this.grbDetallesTratamiento.Size = new System.Drawing.Size(657, 593);
            this.grbDetallesTratamiento.TabIndex = 49;
            this.grbDetallesTratamiento.TabStop = false;
            this.grbDetallesTratamiento.Text = "Detalles del tratamiento";
            // 
            // cboProductoTratamiento
            // 
            this.cboProductoTratamiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamientosBindingSource, "idProducto", true));
            this.cboProductoTratamiento.DataSource = this.productosBindingSource;
            this.cboProductoTratamiento.DisplayMember = "nombre";
            this.cboProductoTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboProductoTratamiento.FormattingEnabled = true;
            this.cboProductoTratamiento.Location = new System.Drawing.Point(196, 106);
            this.cboProductoTratamiento.Name = "cboProductoTratamiento";
            this.cboProductoTratamiento.Size = new System.Drawing.Size(430, 28);
            this.cboProductoTratamiento.TabIndex = 50;
            this.cboProductoTratamiento.ValueMember = "idProducto";
            // 
            // cboPacienteTratamiento
            // 
            this.cboPacienteTratamiento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamientosBindingSource, "idPaciente", true));
            this.cboPacienteTratamiento.DataSource = this.pacientesBindingSource;
            this.cboPacienteTratamiento.DisplayMember = "nombre";
            this.cboPacienteTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPacienteTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboPacienteTratamiento.FormattingEnabled = true;
            this.cboPacienteTratamiento.Location = new System.Drawing.Point(196, 45);
            this.cboPacienteTratamiento.Name = "cboPacienteTratamiento";
            this.cboPacienteTratamiento.Size = new System.Drawing.Size(430, 28);
            this.cboPacienteTratamiento.TabIndex = 49;
            this.cboPacienteTratamiento.ValueMember = "idPaciente";
            // 
            // grbNavegacionTratamiento
            // 
            this.grbNavegacionTratamiento.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionTratamiento.Controls.Add(this.btnPrimeroTratamiento);
            this.grbNavegacionTratamiento.Controls.Add(this.btnAnteriorTratamiento);
            this.grbNavegacionTratamiento.Controls.Add(this.btnUltimoTratamiento);
            this.grbNavegacionTratamiento.Controls.Add(this.btnSiguienteTratamiento);
            this.grbNavegacionTratamiento.Controls.Add(this.lblPosicionTratamiento);
            this.grbNavegacionTratamiento.Location = new System.Drawing.Point(27, 480);
            this.grbNavegacionTratamiento.Name = "grbNavegacionTratamiento";
            this.grbNavegacionTratamiento.Size = new System.Drawing.Size(496, 82);
            this.grbNavegacionTratamiento.TabIndex = 51;
            this.grbNavegacionTratamiento.TabStop = false;
            this.grbNavegacionTratamiento.Text = "Navegación";
            // 
            // btnPrimeroTratamiento
            // 
            this.btnPrimeroTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroTratamiento.Location = new System.Drawing.Point(105, 29);
            this.btnPrimeroTratamiento.Name = "btnPrimeroTratamiento";
            this.btnPrimeroTratamiento.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroTratamiento.TabIndex = 19;
            this.btnPrimeroTratamiento.Text = "|<";
            this.btnPrimeroTratamiento.UseVisualStyleBackColor = false;
            this.btnPrimeroTratamiento.Click += new System.EventHandler(this.btnPrimeroTratamiento_Click);
            // 
            // btnAnteriorTratamiento
            // 
            this.btnAnteriorTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorTratamiento.Location = new System.Drawing.Point(148, 29);
            this.btnAnteriorTratamiento.Name = "btnAnteriorTratamiento";
            this.btnAnteriorTratamiento.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorTratamiento.TabIndex = 22;
            this.btnAnteriorTratamiento.Text = "<";
            this.btnAnteriorTratamiento.UseVisualStyleBackColor = false;
            this.btnAnteriorTratamiento.Click += new System.EventHandler(this.btnAnteriorTratamiento_Click);
            // 
            // btnUltimoTratamiento
            // 
            this.btnUltimoTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoTratamiento.Location = new System.Drawing.Point(322, 29);
            this.btnUltimoTratamiento.Name = "btnUltimoTratamiento";
            this.btnUltimoTratamiento.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoTratamiento.TabIndex = 20;
            this.btnUltimoTratamiento.Text = ">|";
            this.btnUltimoTratamiento.UseVisualStyleBackColor = false;
            this.btnUltimoTratamiento.Click += new System.EventHandler(this.btnUltimoTratamiento_Click);
            // 
            // btnSiguienteTratamiento
            // 
            this.btnSiguienteTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteTratamiento.Location = new System.Drawing.Point(279, 29);
            this.btnSiguienteTratamiento.Name = "btnSiguienteTratamiento";
            this.btnSiguienteTratamiento.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteTratamiento.TabIndex = 21;
            this.btnSiguienteTratamiento.Text = ">";
            this.btnSiguienteTratamiento.UseVisualStyleBackColor = false;
            this.btnSiguienteTratamiento.Click += new System.EventHandler(this.btnSiguienteTratamiento_Click);
            // 
            // lblPosicionTratamiento
            // 
            this.lblPosicionTratamiento.AutoSize = true;
            this.lblPosicionTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionTratamiento.Location = new System.Drawing.Point(200, 34);
            this.lblPosicionTratamiento.Name = "lblPosicionTratamiento";
            this.lblPosicionTratamiento.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionTratamiento.TabIndex = 23;
            this.lblPosicionTratamiento.Text = "x de n";
            // 
            // grbEdicionTratamiento
            // 
            this.grbEdicionTratamiento.Controls.Add(this.btnNuevoTratamiento);
            this.grbEdicionTratamiento.Controls.Add(this.btnModificarTratamiento);
            this.grbEdicionTratamiento.Controls.Add(this.btnEliminarTratamiento);
            this.grbEdicionTratamiento.Location = new System.Drawing.Point(23, 568);
            this.grbEdicionTratamiento.Name = "grbEdicionTratamiento";
            this.grbEdicionTratamiento.Size = new System.Drawing.Size(500, 82);
            this.grbEdicionTratamiento.TabIndex = 50;
            this.grbEdicionTratamiento.TabStop = false;
            this.grbEdicionTratamiento.Text = "Edición";
            // 
            // btnNuevoTratamiento
            // 
            this.btnNuevoTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTratamiento.Location = new System.Drawing.Point(43, 19);
            this.btnNuevoTratamiento.Name = "btnNuevoTratamiento";
            this.btnNuevoTratamiento.Size = new System.Drawing.Size(117, 55);
            this.btnNuevoTratamiento.TabIndex = 18;
            this.btnNuevoTratamiento.Text = "Nuevo tratamiento";
            this.btnNuevoTratamiento.UseVisualStyleBackColor = false;
            this.btnNuevoTratamiento.Click += new System.EventHandler(this.btnNuevoTratamiento_Click);
            // 
            // btnModificarTratamiento
            // 
            this.btnModificarTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTratamiento.Location = new System.Drawing.Point(194, 19);
            this.btnModificarTratamiento.Name = "btnModificarTratamiento";
            this.btnModificarTratamiento.Size = new System.Drawing.Size(90, 55);
            this.btnModificarTratamiento.TabIndex = 16;
            this.btnModificarTratamiento.Text = "Modificar datos";
            this.btnModificarTratamiento.UseVisualStyleBackColor = false;
            this.btnModificarTratamiento.Click += new System.EventHandler(this.btnModificarTratamiento_Click);
            // 
            // btnEliminarTratamiento
            // 
            this.btnEliminarTratamiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTratamiento.Location = new System.Drawing.Point(317, 19);
            this.btnEliminarTratamiento.Name = "btnEliminarTratamiento";
            this.btnEliminarTratamiento.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarTratamiento.TabIndex = 17;
            this.btnEliminarTratamiento.Text = "Eliminar paciente";
            this.btnEliminarTratamiento.UseVisualStyleBackColor = false;
            // 
            // detalleTratamientosBindingSource
            // 
            this.detalleTratamientosBindingSource.DataMember = "detalleTratamientos";
            this.detalleTratamientosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // detalleTratamientosTableAdapter
            // 
            this.detalleTratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.coloresTableAdapter = null;
            this.tableAdapterManager.especiesTableAdapter = null;
            this.tableAdapterManager.fallecimientosTableAdapter = null;
            this.tableAdapterManager.marcasTableAdapter = null;
            this.tableAdapterManager.pacientes_coloresTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.principiosActivosTableAdapter = null;
            this.tableAdapterManager.productos_principiosActivosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.razasTableAdapter = null;
            this.tableAdapterManager.tipoProductoTableAdapter = null;
            this.tableAdapterManager.tipoServiciosTableAdapter = null;
            this.tableAdapterManager.tratamientosTableAdapter = this.tratamientosTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // detalleTratamientosDataGridView
            // 
            this.detalleTratamientosDataGridView.AutoGenerateColumns = false;
            this.detalleTratamientosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleTratamientosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.detalleTratamientosDataGridView.DataSource = this.detalleTratamientosBindingSource;
            this.detalleTratamientosDataGridView.Location = new System.Drawing.Point(7, 90);
            this.detalleTratamientosDataGridView.Name = "detalleTratamientosDataGridView";
            this.detalleTratamientosDataGridView.Size = new System.Drawing.Size(516, 384);
            this.detalleTratamientosDataGridView.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTratamiento";
            this.dataGridViewTextBoxColumn1.HeaderText = "idTratamiento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "paciente";
            this.dataGridViewTextBoxColumn8.HeaderText = "paciente";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "producto";
            this.dataGridViewTextBoxColumn9.HeaderText = "producto";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idPaciente";
            this.dataGridViewTextBoxColumn2.HeaderText = "idPaciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn3.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "cantidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dosis";
            this.dataGridViewTextBoxColumn5.HeaderText = "dosis";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "fechaInicio";
            this.dataGridViewTextBoxColumn6.HeaderText = "fechaInicio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fechaFin";
            this.dataGridViewTextBoxColumn7.HeaderText = "fechaFin";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // cboOpcionBuscarTratamiento
            // 
            this.cboOpcionBuscarTratamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarTratamiento.FormattingEnabled = true;
            this.cboOpcionBuscarTratamiento.Items.AddRange(new object[] {
            "Nombre",
            "Especie",
            "Raza",
            "Color",
            "Estatura",
            "Peso",
            "Descripcion"});
            this.cboOpcionBuscarTratamiento.Location = new System.Drawing.Point(87, 56);
            this.cboOpcionBuscarTratamiento.Name = "cboOpcionBuscarTratamiento";
            this.cboOpcionBuscarTratamiento.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarTratamiento.TabIndex = 54;
            // 
            // txtBuscarTratamiento
            // 
            this.txtBuscarTratamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarTratamiento.Location = new System.Drawing.Point(256, 56);
            this.txtBuscarTratamiento.Name = "txtBuscarTratamiento";
            this.txtBuscarTratamiento.Size = new System.Drawing.Size(249, 26);
            this.txtBuscarTratamiento.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Buscar";
            // 
            // Tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.cboOpcionBuscarTratamiento);
            this.Controls.Add(this.txtBuscarTratamiento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.detalleTratamientosDataGridView);
            this.Controls.Add(this.grbNavegacionTratamiento);
            this.Controls.Add(this.grbEdicionTratamiento);
            this.Controls.Add(this.grbDetallesTratamiento);
            this.Name = "Tratamientos";
            this.Text = "Tratamientos";
            this.Load += new System.EventHandler(this.Tratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.grbDetallesTratamiento.ResumeLayout(false);
            this.grbDetallesTratamiento.PerformLayout();
            this.grbNavegacionTratamiento.ResumeLayout(false);
            this.grbNavegacionTratamiento.PerformLayout();
            this.grbEdicionTratamiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalleTratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleTratamientosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadTratamiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDosisTratamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaDeNacimientoUsuario;
        private System.Windows.Forms.DateTimePicker dateFechaFin;
        private System.Windows.Forms.Label label5;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.tratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.GroupBox grbDetallesTratamiento;
        private System.Windows.Forms.ComboBox cboProductoTratamiento;
        private System.Windows.Forms.ComboBox cboPacienteTratamiento;
        private System.Windows.Forms.GroupBox grbNavegacionTratamiento;
        private System.Windows.Forms.Button btnPrimeroTratamiento;
        private System.Windows.Forms.Button btnAnteriorTratamiento;
        private System.Windows.Forms.Button btnUltimoTratamiento;
        private System.Windows.Forms.Button btnSiguienteTratamiento;
        private System.Windows.Forms.Label lblPosicionTratamiento;
        private System.Windows.Forms.GroupBox grbEdicionTratamiento;
        private System.Windows.Forms.Button btnNuevoTratamiento;
        private System.Windows.Forms.Button btnModificarTratamiento;
        private System.Windows.Forms.Button btnEliminarTratamiento;
        private System.Windows.Forms.BindingSource detalleTratamientosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.detalleTratamientosTableAdapter detalleTratamientosTableAdapter;
        private bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView detalleTratamientosDataGridView;
        private System.Windows.Forms.ComboBox cboOpcionBuscarTratamiento;
        private System.Windows.Forms.TextBox txtBuscarTratamiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}