
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
            this.grbDatosPaciente = new System.Windows.Forms.GroupBox();
            this.lblSexoPaciente = new System.Windows.Forms.Label();
            this.cboTutorPaciente = new System.Windows.Forms.ComboBox();
            this.lblTutorPaciente = new System.Windows.Forms.Label();
            this.cboEspeciePaciente = new System.Windows.Forms.ComboBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionPaciente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.grbEdicionPaciente = new System.Windows.Forms.GroupBox();
            this.btnNuevoPaciente = new System.Windows.Forms.Button();
            this.btnModificarPaciente = new System.Windows.Forms.Button();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.marcasTableAdapter();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoProductoTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.tipoProductoTableAdapter();
            this.grbNavegacionProducto.SuspendLayout();
            this.grbDatosPaciente.SuspendLayout();
            this.grbEdicionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
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
            this.grbNavegacionProducto.Location = new System.Drawing.Point(885, 541);
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
            // grbDatosPaciente
            // 
            this.grbDatosPaciente.Controls.Add(this.listBox1);
            this.grbDatosPaciente.Controls.Add(this.textBox1);
            this.grbDatosPaciente.Controls.Add(this.lblSexoPaciente);
            this.grbDatosPaciente.Controls.Add(this.cboTutorPaciente);
            this.grbDatosPaciente.Controls.Add(this.lblTutorPaciente);
            this.grbDatosPaciente.Controls.Add(this.cboEspeciePaciente);
            this.grbDatosPaciente.Controls.Add(this.txtNombrePaciente);
            this.grbDatosPaciente.Controls.Add(this.label5);
            this.grbDatosPaciente.Controls.Add(this.label2);
            this.grbDatosPaciente.Controls.Add(this.label4);
            this.grbDatosPaciente.Controls.Add(this.txtDescripcionPaciente);
            this.grbDatosPaciente.Controls.Add(this.label10);
            this.grbDatosPaciente.Location = new System.Drawing.Point(510, 32);
            this.grbDatosPaciente.Name = "grbDatosPaciente";
            this.grbDatosPaciente.Size = new System.Drawing.Size(657, 472);
            this.grbDatosPaciente.TabIndex = 29;
            this.grbDatosPaciente.TabStop = false;
            this.grbDatosPaciente.Text = "Datos del paciente";
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
            // cboTutorPaciente
            // 
            this.cboTutorPaciente.DataSource = this.marcasBindingSource;
            this.cboTutorPaciente.DisplayMember = "marca";
            this.cboTutorPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTutorPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboTutorPaciente.FormattingEnabled = true;
            this.cboTutorPaciente.Location = new System.Drawing.Point(195, 132);
            this.cboTutorPaciente.Name = "cboTutorPaciente";
            this.cboTutorPaciente.Size = new System.Drawing.Size(430, 28);
            this.cboTutorPaciente.TabIndex = 37;
            this.cboTutorPaciente.ValueMember = "idMarca";
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
            // cboEspeciePaciente
            // 
            this.cboEspeciePaciente.DataSource = this.tipoProductoBindingSource;
            this.cboEspeciePaciente.DisplayMember = "tipoProducto";
            this.cboEspeciePaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspeciePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cboEspeciePaciente.FormattingEnabled = true;
            this.cboEspeciePaciente.Location = new System.Drawing.Point(195, 177);
            this.cboEspeciePaciente.Name = "cboEspeciePaciente";
            this.cboEspeciePaciente.Size = new System.Drawing.Size(430, 28);
            this.cboEspeciePaciente.TabIndex = 35;
            this.cboEspeciePaciente.ValueMember = "idTipoProducto";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
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
            // txtDescripcionPaciente
            // 
            this.txtDescripcionPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPaciente.Location = new System.Drawing.Point(195, 211);
            this.txtDescripcionPaciente.Name = "txtDescripcionPaciente";
            this.txtDescripcionPaciente.ReadOnly = true;
            this.txtDescripcionPaciente.Size = new System.Drawing.Size(430, 26);
            this.txtDescripcionPaciente.TabIndex = 19;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 429);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 26);
            this.textBox1.TabIndex = 39;
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
            // grbEdicionPaciente
            // 
            this.grbEdicionPaciente.Controls.Add(this.btnNuevoPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnModificarPaciente);
            this.grbEdicionPaciente.Controls.Add(this.btnEliminarPaciente);
            this.grbEdicionPaciente.Location = new System.Drawing.Point(510, 541);
            this.grbEdicionPaciente.Name = "grbEdicionPaciente";
            this.grbEdicionPaciente.Size = new System.Drawing.Size(320, 82);
            this.grbEdicionPaciente.TabIndex = 30;
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
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "marcas";
            this.marcasBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataMember = "tipoProducto";
            this.tipoProductoBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // tipoProductoTableAdapter
            // 
            this.tipoProductoTableAdapter.ClearBeforeFill = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.grbEdicionPaciente);
            this.Controls.Add(this.grbDatosPaciente);
            this.Controls.Add(this.grbNavegacionProducto);
            this.Name = "Productos";
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbNavegacionProducto.ResumeLayout(false);
            this.grbNavegacionProducto.PerformLayout();
            this.grbDatosPaciente.ResumeLayout(false);
            this.grbDatosPaciente.PerformLayout();
            this.grbEdicionPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNavegacionProducto;
        private System.Windows.Forms.Button btnPrimeroProducto;
        private System.Windows.Forms.Button btnAnteriorProducto;
        private System.Windows.Forms.Button btnUltimoProducto;
        private System.Windows.Forms.Button btnSiguienteProducto;
        private System.Windows.Forms.Label lblPosicionProducto;
        private System.Windows.Forms.GroupBox grbDatosPaciente;
        private System.Windows.Forms.Label lblSexoPaciente;
        private System.Windows.Forms.ComboBox cboTutorPaciente;
        private System.Windows.Forms.Label lblTutorPaciente;
        private System.Windows.Forms.ComboBox cboEspeciePaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionPaciente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbEdicionPaciente;
        private System.Windows.Forms.Button btnNuevoPaciente;
        private System.Windows.Forms.Button btnModificarPaciente;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.marcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.tipoProductoTableAdapter tipoProductoTableAdapter;
    }
}