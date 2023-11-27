
namespace ProyectoFinal_Progra_I
{
    partial class Servicios
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
            this.grbDatosServicio = new System.Windows.Forms.GroupBox();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.tipoServiciosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracionServicio = new System.Windows.Forms.TextBox();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cboOpcionBuscarUsuario = new System.Windows.Forms.ComboBox();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.grbNavegacionServicio = new System.Windows.Forms.GroupBox();
            this.btnPrimeroServicio = new System.Windows.Forms.Button();
            this.btnAnteriorServicio = new System.Windows.Forms.Button();
            this.btnUltimoServicio = new System.Windows.Forms.Button();
            this.btnSiguienteServicio = new System.Windows.Forms.Button();
            this.lblPosicionServicio = new System.Windows.Forms.Label();
            this.grbEdicionServicio = new System.Windows.Forms.GroupBox();
            this.btnNuevoServicio = new System.Windows.Forms.Button();
            this.btnModificarServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.tipoServiciosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.tipoServiciosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager();
            this.tipoServiciosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDatosServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServiciosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            this.grbNavegacionServicio.SuspendLayout();
            this.grbEdicionServicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServiciosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosServicio
            // 
            this.grbDatosServicio.Controls.Add(this.txtPrecioServicio);
            this.grbDatosServicio.Controls.Add(this.label2);
            this.grbDatosServicio.Controls.Add(this.txtDescripcionServicio);
            this.grbDatosServicio.Controls.Add(this.label1);
            this.grbDatosServicio.Controls.Add(this.txtDuracionServicio);
            this.grbDatosServicio.Controls.Add(this.txtNombreServicio);
            this.grbDatosServicio.Controls.Add(this.lblNombreUsuario);
            this.grbDatosServicio.Controls.Add(this.lblUsuario);
            this.grbDatosServicio.Location = new System.Drawing.Point(530, 21);
            this.grbDatosServicio.Name = "grbDatosServicio";
            this.grbDatosServicio.Size = new System.Drawing.Size(737, 431);
            this.grbDatosServicio.TabIndex = 36;
            this.grbDatosServicio.TabStop = false;
            this.grbDatosServicio.Text = "Datos del servicio";
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoServiciosBindingSource, "Precio", true));
            this.txtPrecioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioServicio.Location = new System.Drawing.Point(158, 320);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(86, 26);
            this.txtPrecioServicio.TabIndex = 24;
            // 
            // tipoServiciosBindingSource
            // 
            this.tipoServiciosBindingSource.DataMember = "tipoServicios";
            this.tipoServiciosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
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
            this.label2.Location = new System.Drawing.Point(66, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Precio ($)";
            // 
            // txtDescripcionServicio
            // 
            this.txtDescripcionServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoServiciosBindingSource, "descripcion", true));
            this.txtDescripcionServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionServicio.Location = new System.Drawing.Point(158, 198);
            this.txtDescripcionServicio.Multiline = true;
            this.txtDescripcionServicio.Name = "txtDescripcionServicio";
            this.txtDescripcionServicio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcionServicio.Size = new System.Drawing.Size(430, 71);
            this.txtDescripcionServicio.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Descripcion";
            // 
            // txtDuracionServicio
            // 
            this.txtDuracionServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoServiciosBindingSource, "duracionNormal", true));
            this.txtDuracionServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracionServicio.Location = new System.Drawing.Point(194, 124);
            this.txtDuracionServicio.Name = "txtDuracionServicio";
            this.txtDuracionServicio.Size = new System.Drawing.Size(65, 26);
            this.txtDuracionServicio.TabIndex = 20;
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipoServiciosBindingSource, "tipoServicio", true));
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(158, 49);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(430, 26);
            this.txtNombreServicio.TabIndex = 19;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(81, 52);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(71, 20);
            this.lblNombreUsuario.TabIndex = 18;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 127);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(185, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Duración normal (min)";
            // 
            // cboOpcionBuscarUsuario
            // 
            this.cboOpcionBuscarUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOpcionBuscarUsuario.FormattingEnabled = true;
            this.cboOpcionBuscarUsuario.Items.AddRange(new object[] {
            "Nombre",
            "Dirección",
            "Correo",
            "Teléfono",
            "Fecha de nacimiento",
            "Fecha de registro"});
            this.cboOpcionBuscarUsuario.Location = new System.Drawing.Point(105, 57);
            this.cboOpcionBuscarUsuario.Name = "cboOpcionBuscarUsuario";
            this.cboOpcionBuscarUsuario.Size = new System.Drawing.Size(154, 28);
            this.cboOpcionBuscarUsuario.TabIndex = 35;
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarUsuario.Location = new System.Drawing.Point(275, 57);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(210, 26);
            this.txtBuscarUsuario.TabIndex = 34;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(34, 60);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(65, 20);
            this.lblBuscarUsuario.TabIndex = 33;
            this.lblBuscarUsuario.Text = "Buscar";
            // 
            // grbNavegacionServicio
            // 
            this.grbNavegacionServicio.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionServicio.Controls.Add(this.btnPrimeroServicio);
            this.grbNavegacionServicio.Controls.Add(this.btnAnteriorServicio);
            this.grbNavegacionServicio.Controls.Add(this.btnUltimoServicio);
            this.grbNavegacionServicio.Controls.Add(this.btnSiguienteServicio);
            this.grbNavegacionServicio.Controls.Add(this.lblPosicionServicio);
            this.grbNavegacionServicio.Location = new System.Drawing.Point(126, 282);
            this.grbNavegacionServicio.Name = "grbNavegacionServicio";
            this.grbNavegacionServicio.Size = new System.Drawing.Size(280, 82);
            this.grbNavegacionServicio.TabIndex = 38;
            this.grbNavegacionServicio.TabStop = false;
            this.grbNavegacionServicio.Text = "Navegación";
            // 
            // btnPrimeroServicio
            // 
            this.btnPrimeroServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroServicio.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroServicio.Name = "btnPrimeroServicio";
            this.btnPrimeroServicio.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroServicio.TabIndex = 19;
            this.btnPrimeroServicio.Text = "|<";
            this.btnPrimeroServicio.UseVisualStyleBackColor = false;
            this.btnPrimeroServicio.Click += new System.EventHandler(this.btnPrimeroPaciente_Click);
            // 
            // btnAnteriorServicio
            // 
            this.btnAnteriorServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorServicio.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorServicio.Name = "btnAnteriorServicio";
            this.btnAnteriorServicio.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorServicio.TabIndex = 22;
            this.btnAnteriorServicio.Text = "<";
            this.btnAnteriorServicio.UseVisualStyleBackColor = false;
            this.btnAnteriorServicio.Click += new System.EventHandler(this.btnAnteriorServicio_Click);
            // 
            // btnUltimoServicio
            // 
            this.btnUltimoServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoServicio.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoServicio.Name = "btnUltimoServicio";
            this.btnUltimoServicio.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoServicio.TabIndex = 20;
            this.btnUltimoServicio.Text = ">|";
            this.btnUltimoServicio.UseVisualStyleBackColor = false;
            this.btnUltimoServicio.Click += new System.EventHandler(this.btnUltimoServicio_Click);
            // 
            // btnSiguienteServicio
            // 
            this.btnSiguienteServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteServicio.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteServicio.Name = "btnSiguienteServicio";
            this.btnSiguienteServicio.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteServicio.TabIndex = 21;
            this.btnSiguienteServicio.Text = ">";
            this.btnSiguienteServicio.UseVisualStyleBackColor = false;
            this.btnSiguienteServicio.Click += new System.EventHandler(this.btnSiguienteServicio_Click);
            // 
            // lblPosicionServicio
            // 
            this.lblPosicionServicio.AutoSize = true;
            this.lblPosicionServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionServicio.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionServicio.Name = "lblPosicionServicio";
            this.lblPosicionServicio.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionServicio.TabIndex = 23;
            this.lblPosicionServicio.Text = "x de n";
            // 
            // grbEdicionServicio
            // 
            this.grbEdicionServicio.Controls.Add(this.btnNuevoServicio);
            this.grbEdicionServicio.Controls.Add(this.btnModificarServicio);
            this.grbEdicionServicio.Controls.Add(this.btnEliminarServicio);
            this.grbEdicionServicio.Location = new System.Drawing.Point(104, 370);
            this.grbEdicionServicio.Name = "grbEdicionServicio";
            this.grbEdicionServicio.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionServicio.TabIndex = 37;
            this.grbEdicionServicio.TabStop = false;
            this.grbEdicionServicio.Text = "Edición";
            // 
            // btnNuevoServicio
            // 
            this.btnNuevoServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoServicio.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoServicio.Name = "btnNuevoServicio";
            this.btnNuevoServicio.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoServicio.TabIndex = 18;
            this.btnNuevoServicio.Text = "Nuevo servicio";
            this.btnNuevoServicio.UseVisualStyleBackColor = false;
            this.btnNuevoServicio.Click += new System.EventHandler(this.btnNuevoServicio_Click);
            // 
            // btnModificarServicio
            // 
            this.btnModificarServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarServicio.Location = new System.Drawing.Point(112, 18);
            this.btnModificarServicio.Name = "btnModificarServicio";
            this.btnModificarServicio.Size = new System.Drawing.Size(90, 55);
            this.btnModificarServicio.TabIndex = 16;
            this.btnModificarServicio.Text = "Modificar datos";
            this.btnModificarServicio.UseVisualStyleBackColor = false;
            this.btnModificarServicio.Click += new System.EventHandler(this.btnModificarServicio_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarServicio.TabIndex = 17;
            this.btnEliminarServicio.Text = "Eliminar servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = false;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // tipoServiciosTableAdapter
            // 
            this.tipoServiciosTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.pacientesTableAdapter = null;
            this.tableAdapterManager.principiosActivosTableAdapter = null;
            this.tableAdapterManager.productos_principiosActivosTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.razasTableAdapter = null;
            this.tableAdapterManager.tipoProductoTableAdapter = null;
            this.tableAdapterManager.tipoServiciosTableAdapter = this.tipoServiciosTableAdapter;
            this.tableAdapterManager.tratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuariosTableAdapter = null;
            // 
            // tipoServiciosDataGridView
            // 
            this.tipoServiciosDataGridView.AutoGenerateColumns = false;
            this.tipoServiciosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoServiciosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tipoServiciosDataGridView.DataSource = this.tipoServiciosBindingSource;
            this.tipoServiciosDataGridView.Location = new System.Drawing.Point(38, 21);
            this.tipoServiciosDataGridView.Name = "tipoServiciosDataGridView";
            this.tipoServiciosDataGridView.Size = new System.Drawing.Size(458, 255);
            this.tipoServiciosDataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idTipoServicio";
            this.dataGridViewTextBoxColumn1.HeaderText = "idTipoServicio";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tipoServicio";
            this.dataGridViewTextBoxColumn2.HeaderText = "tipoServicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "duracionNormal";
            this.dataGridViewTextBoxColumn5.HeaderText = "duracionNormal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tipoServiciosDataGridView);
            this.Controls.Add(this.grbNavegacionServicio);
            this.Controls.Add(this.grbEdicionServicio);
            this.Controls.Add(this.grbDatosServicio);
            this.Controls.Add(this.cboOpcionBuscarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Name = "Servicios";
            this.Text = "Servicios";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.grbDatosServicio.ResumeLayout(false);
            this.grbDatosServicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServiciosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            this.grbNavegacionServicio.ResumeLayout(false);
            this.grbNavegacionServicio.PerformLayout();
            this.grbEdicionServicio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoServiciosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cboOpcionBuscarUsuario;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.GroupBox grbNavegacionServicio;
        private System.Windows.Forms.Button btnPrimeroServicio;
        private System.Windows.Forms.Button btnAnteriorServicio;
        private System.Windows.Forms.Button btnUltimoServicio;
        private System.Windows.Forms.Button btnSiguienteServicio;
        private System.Windows.Forms.Label lblPosicionServicio;
        private System.Windows.Forms.GroupBox grbEdicionServicio;
        private System.Windows.Forms.Button btnNuevoServicio;
        private System.Windows.Forms.Button btnModificarServicio;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuracionServicio;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource tipoServiciosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.tipoServiciosTableAdapter tipoServiciosTableAdapter;
        private bd_veterinaria_huellitasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tipoServiciosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}