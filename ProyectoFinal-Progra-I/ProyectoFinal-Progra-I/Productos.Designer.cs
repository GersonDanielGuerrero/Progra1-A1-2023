
namespace ProyectoFinal_Progra_I
{
    partial class Productos
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
            this.grbNavegacionProducto = new System.Windows.Forms.GroupBox();
            this.btnPrimeroProducto = new System.Windows.Forms.Button();
            this.btnAnteriorProducto = new System.Windows.Forms.Button();
            this.btnUltimoProducto = new System.Windows.Forms.Button();
            this.btnSiguienteProducto = new System.Windows.Forms.Button();
            this.lblPosicionProducto = new System.Windows.Forms.Label();
            this.grbDatosProducto = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.cboMarcaProducto = new System.Windows.Forms.ComboBox();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTutorPaciente = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grbEdicionProducto = new System.Windows.Forms.GroupBox();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.marcasTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.marcasTableAdapter();
            this.tipoProductoTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.tipoProductoTableAdapter();
            this.productosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.productosTableAdapter();
            this.datosProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosProductosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.datosProductosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager();
            this.datosProductosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNavegacionProducto.SuspendLayout();
            this.grbDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            this.grbEdicionProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datosProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosProductosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNavegacionProducto
            // 
            this.grbNavegacionProducto.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionProducto.Controls.Add(this.btnPrimeroProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnAnteriorProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnUltimoProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnSiguienteProducto);
            this.grbNavegacionProducto.Controls.Add(this.lblPosicionProducto);
            this.grbNavegacionProducto.Location = new System.Drawing.Point(96, 317);
            this.grbNavegacionProducto.Name = "grbNavegacionProducto";
            this.grbNavegacionProducto.Size = new System.Drawing.Size(282, 82);
            this.grbNavegacionProducto.TabIndex = 28;
            this.grbNavegacionProducto.TabStop = false;
            this.grbNavegacionProducto.Text = "Navegación";
            // 
            // btnPrimeroProducto
            // 
            this.btnPrimeroProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroProducto.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroProducto.Name = "btnPrimeroProducto";
            this.btnPrimeroProducto.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroProducto.TabIndex = 19;
            this.btnPrimeroProducto.Text = "|<";
            this.btnPrimeroProducto.UseVisualStyleBackColor = false;
            this.btnPrimeroProducto.Click += new System.EventHandler(this.btnPrimeroProducto_Click);
            // 
            // btnAnteriorProducto
            // 
            this.btnAnteriorProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorProducto.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorProducto.Name = "btnAnteriorProducto";
            this.btnAnteriorProducto.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorProducto.TabIndex = 22;
            this.btnAnteriorProducto.Text = "<";
            this.btnAnteriorProducto.UseVisualStyleBackColor = false;
            this.btnAnteriorProducto.Click += new System.EventHandler(this.btnAnteriorProducto_Click);
            // 
            // btnUltimoProducto
            // 
            this.btnUltimoProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoProducto.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoProducto.Name = "btnUltimoProducto";
            this.btnUltimoProducto.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoProducto.TabIndex = 20;
            this.btnUltimoProducto.Text = ">|";
            this.btnUltimoProducto.UseVisualStyleBackColor = false;
            this.btnUltimoProducto.Click += new System.EventHandler(this.btnUltimoProducto_Click);
            // 
            // btnSiguienteProducto
            // 
            this.btnSiguienteProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteProducto.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteProducto.Name = "btnSiguienteProducto";
            this.btnSiguienteProducto.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteProducto.TabIndex = 21;
            this.btnSiguienteProducto.Text = ">";
            this.btnSiguienteProducto.UseVisualStyleBackColor = false;
            this.btnSiguienteProducto.Click += new System.EventHandler(this.btnSiguienteProducto_Click);
            // 
            // lblPosicionProducto
            // 
            this.lblPosicionProducto.AutoSize = true;
            this.lblPosicionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionProducto.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionProducto.Name = "lblPosicionProducto";
            this.lblPosicionProducto.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionProducto.TabIndex = 23;
            this.lblPosicionProducto.Text = "x de n";
            // 
            // grbDatosProducto
            // 
            this.grbDatosProducto.Controls.Add(this.listBox1);
            this.grbDatosProducto.Controls.Add(this.txtPrecioProducto);
            this.grbDatosProducto.Controls.Add(this.lblSexoPaciente);
            this.grbDatosProducto.Controls.Add(this.cboMarcaProducto);
            this.grbDatosProducto.Controls.Add(this.lblTutorPaciente);
            this.grbDatosProducto.Controls.Add(this.cboTipoProducto);
            this.grbDatosProducto.Controls.Add(this.txtNombreProducto);
            this.grbDatosProducto.Controls.Add(this.label5);
            this.grbDatosProducto.Controls.Add(this.label2);
            this.grbDatosProducto.Controls.Add(this.label4);
            this.grbDatosProducto.Controls.Add(this.txtDescripcionProducto);
            this.grbDatosProducto.Controls.Add(this.label10);
            this.grbDatosProducto.Location = new System.Drawing.Point(510, 32);
            this.grbDatosProducto.Name = "grbDatosProducto";
            this.grbDatosProducto.Size = new System.Drawing.Size(657, 472);
            this.grbDatosProducto.TabIndex = 29;
            this.grbDatosProducto.TabStop = false;
            this.grbDatosProducto.Text = "Datos del paciente";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(195, 259);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 124);
            this.listBox1.TabIndex = 40;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "precio", true));
            this.txtPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProducto.Location = new System.Drawing.Point(195, 429);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(71, 26);
            this.txtPrecioProducto.TabIndex = 39;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "productos";
            this.productosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSexoPaciente
            // 
            this.lblSexoPaciente.AutoSize = true;
            this.lblSexoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoPaciente.Location = new System.Drawing.Point(146, 180);
            this.lblSexoPaciente.Name = "lblSexoPaciente";
            this.lblSexoPaciente.Size = new System.Drawing.Size(43, 20);
            this.lblSexoPaciente.TabIndex = 38;
            this.lblSexoPaciente.Text = "Tipo";
            // 
            // cboMarcaProducto
            // 
            this.cboMarcaProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "idMarca", true));
            this.cboMarcaProducto.DataSource = this.marcasBindingSource;
            this.cboMarcaProducto.DisplayMember = "marca";
            this.cboMarcaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboMarcaProducto.FormattingEnabled = true;
            this.cboMarcaProducto.Location = new System.Drawing.Point(195, 132);
            this.cboMarcaProducto.Name = "cboMarcaProducto";
            this.cboMarcaProducto.Size = new System.Drawing.Size(430, 28);
            this.cboMarcaProducto.TabIndex = 37;
            this.cboMarcaProducto.ValueMember = "idMarca";
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // lblTutorPaciente
            // 
            this.lblTutorPaciente.AutoSize = true;
            this.lblTutorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorPaciente.Location = new System.Drawing.Point(131, 140);
            this.lblTutorPaciente.Name = "lblTutorPaciente";
            this.lblTutorPaciente.Size = new System.Drawing.Size(58, 20);
            this.lblTutorPaciente.TabIndex = 36;
            this.lblTutorPaciente.Text = "Marca";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productosBindingSource, "idTipoProducto", true));
            this.cboTipoProducto.DataSource = this.tipoProductoBindingSource;
            this.cboTipoProducto.DisplayMember = "tipoProducto";
            this.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(195, 177);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(430, 28);
            this.cboTipoProducto.TabIndex = 35;
            this.cboTipoProducto.ValueMember = "idTipoProducto";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "tipoProducto";
            this.tipoProductoBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "nombre", true));
            this.txtNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtNombreProducto.Location = new System.Drawing.Point(195, 86);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(430, 26);
            this.txtNombreProducto.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(131, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Principios activos";
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
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "descripcion", true));
            this.txtDescripcionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProducto.Location = new System.Drawing.Point(195, 211);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(430, 26);
            this.txtDescripcionProducto.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Descripción";
            // 
            // grbEdicionProducto
            // 
            this.grbEdicionProducto.Controls.Add(this.btnNuevoProducto);
            this.grbEdicionProducto.Controls.Add(this.btnModificarProducto);
            this.grbEdicionProducto.Controls.Add(this.btnEliminarProducto);
            this.grbEdicionProducto.Location = new System.Drawing.Point(69, 405);
            this.grbEdicionProducto.Name = "grbEdicionProducto";
            this.grbEdicionProducto.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionProducto.TabIndex = 30;
            this.grbEdicionProducto.TabStop = false;
            this.grbEdicionProducto.Text = "Edición";
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoProducto.TabIndex = 18;
            this.btnNuevoProducto.Text = "Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Location = new System.Drawing.Point(112, 19);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(90, 55);
            this.btnModificarProducto.TabIndex = 16;
            this.btnModificarProducto.Text = "Modificar datos";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarProducto.TabIndex = 17;
            this.btnEliminarProducto.Text = "Eliminar paciente";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // datosProductosBindingSource
            // 
            this.datosProductosBindingSource.DataMember = "datosProductos";
            this.datosProductosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // datosProductosTableAdapter
            // 
            this.datosProductosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = null;
            this.tableAdapterManager.coloresTableAdapter = null;
            this.tableAdapterManager.especiesTableAdapter = null;
            this.tableAdapterManager.fallecimientosTableAdapter = null;
            this.tableAdapterManager.marcasTableAdapter = this.marcasTableAdapter;
            this.tableAdapterManager.pacientes_coloresTableAdapter = null;
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.principiosActivosTableAdapter = null;
            this.tableAdapterManager.productos_principiosActivosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.razasTableAdapter = null;
            this.tableAdapterManager.tipoProductoTableAdapter = this.tipoProductoTableAdapter;
            this.tableAdapterManager.tipoServiciosTableAdapter = null;
            this.tableAdapterManager.tratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // datosProductosDataGridView
            // 
            this.datosProductosDataGridView.AutoGenerateColumns = false;
            this.datosProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosProductosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.datosProductosDataGridView.DataSource = this.datosProductosBindingSource;
            this.datosProductosDataGridView.Location = new System.Drawing.Point(12, 17);
            this.datosProductosDataGridView.Name = "datosProductosDataGridView";
            this.datosProductosDataGridView.Size = new System.Drawing.Size(471, 294);
            this.datosProductosDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idProducto";
            this.dataGridViewTextBoxColumn2.HeaderText = "idProducto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idMarca";
            this.dataGridViewTextBoxColumn3.HeaderText = "idMarca";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idTipoProducto";
            this.dataGridViewTextBoxColumn5.HeaderText = "idTipoProducto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "marca";
            this.dataGridViewTextBoxColumn6.HeaderText = "marca";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipoProducto";
            this.dataGridViewTextBoxColumn7.HeaderText = "tipoProducto";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.datosProductosDataGridView);
            this.Controls.Add(this.grbEdicionProducto);
            this.Controls.Add(this.grbDatosProducto);
            this.Controls.Add(this.grbNavegacionProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbNavegacionProducto.ResumeLayout(false);
            this.grbNavegacionProducto.PerformLayout();
            this.grbDatosProducto.ResumeLayout(false);
            this.grbDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            this.grbEdicionProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datosProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosProductosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacionProducto;
        private System.Windows.Forms.Button btnPrimeroProducto;
        private System.Windows.Forms.Button btnAnteriorProducto;
        private System.Windows.Forms.Button btnUltimoProducto;
        private System.Windows.Forms.Button btnSiguienteProducto;
        private System.Windows.Forms.Label lblPosicionProducto;
        private System.Windows.Forms.GroupBox grbDatosProducto;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.ComboBox cboMarcaProducto;
        private System.Windows.Forms.Label lblTutorPaciente;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.GroupBox grbEdicionProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.tipoProductoTableAdapter tipoProductoTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.productosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource datosProductosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.datosProductosTableAdapter datosProductosTableAdapter;
        private bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView datosProductosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}