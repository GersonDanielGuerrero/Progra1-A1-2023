
namespace ProyectoFinal
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grdListaClientes = new System.Windows.Forms.DataGridView();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.grbListaClientes = new System.Windows.Forms.GroupBox();
            this.cboOpcionBuscarClientes = new System.Windows.Forms.ComboBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.dtpNacimientoCliente = new System.Windows.Forms.DateTimePicker();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbNavegacionCliente = new System.Windows.Forms.GroupBox();
            this.btnUltimoCliente = new System.Windows.Forms.Button();
            this.btnPrimeroCliente = new System.Windows.Forms.Button();
            this.btnSiguienteCliente = new System.Windows.Forms.Button();
            this.btnAnteriorCliente = new System.Windows.Forms.Button();
            this.lblNRegistroCliente = new System.Windows.Forms.Label();
            this.grbEdicionCliente = new System.Windows.Forms.GroupBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.erpClientes = new System.Windows.Forms.ErrorProvider(this.components);
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimientoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaClientes)).BeginInit();
            this.grbListaClientes.SuspendLayout();
            this.grbInformacionCliente.SuspendLayout();
            this.grbNavegacionCliente.SuspendLayout();
            this.grbEdicionCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.Location = new System.Drawing.Point(49, 68);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 29);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grdListaClientes
            // 
            this.grdListaClientes.AllowUserToAddRows = false;
            this.grdListaClientes.AllowUserToDeleteRows = false;
            this.grdListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombre,
            this.nacimientoCliente,
            this.telefono,
            this.direccion,
            this.correo});
            this.grdListaClientes.Location = new System.Drawing.Point(6, 75);
            this.grdListaClientes.Name = "grdListaClientes";
            this.grdListaClientes.ReadOnly = true;
            this.grdListaClientes.Size = new System.Drawing.Size(490, 426);
            this.grdListaClientes.TabIndex = 1;
            this.grdListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaClientes_CellClick);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(20, 74);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(65, 20);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(102, 74);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(390, 26);
            this.txtNombreCliente.TabIndex = 3;
            // 
            // grbListaClientes
            // 
            this.grbListaClientes.Controls.Add(this.cboOpcionBuscarClientes);
            this.grbListaClientes.Controls.Add(this.txtBuscarCliente);
            this.grbListaClientes.Controls.Add(this.grdListaClientes);
            this.grbListaClientes.Controls.Add(this.label6);
            this.grbListaClientes.Location = new System.Drawing.Point(23, 68);
            this.grbListaClientes.Name = "grbListaClientes";
            this.grbListaClientes.Size = new System.Drawing.Size(502, 498);
            this.grbListaClientes.TabIndex = 4;
            this.grbListaClientes.TabStop = false;
            this.grbListaClientes.Text = "Lista de Clientes";
            // 
            // cboOpcionBuscarClientes
            // 
            this.cboOpcionBuscarClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarClientes.FormattingEnabled = true;
            this.cboOpcionBuscarClientes.Items.AddRange(new object[] {
            "Nombre",
            "Telefono",
            "Direccion",
            "Correo"});
            this.cboOpcionBuscarClientes.Location = new System.Drawing.Point(46, 49);
            this.cboOpcionBuscarClientes.Name = "cboOpcionBuscarClientes";
            this.cboOpcionBuscarClientes.Size = new System.Drawing.Size(101, 21);
            this.cboOpcionBuscarClientes.TabIndex = 16;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(153, 49);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarCliente.TabIndex = 15;
            this.txtBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCliente_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de nacimiento";
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(115, 214);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.ReadOnly = true;
            this.txtTelefonoCliente.Size = new System.Drawing.Size(100, 26);
            this.txtTelefonoCliente.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Teléfono";
            // 
            // grbInformacionCliente
            // 
            this.grbInformacionCliente.Controls.Add(this.dtpNacimientoCliente);
            this.grbInformacionCliente.Controls.Add(this.txtCorreoCliente);
            this.grbInformacionCliente.Controls.Add(this.label4);
            this.grbInformacionCliente.Controls.Add(this.txtDireccionCliente);
            this.grbInformacionCliente.Controls.Add(this.label3);
            this.grbInformacionCliente.Controls.Add(this.txtTelefonoCliente);
            this.grbInformacionCliente.Controls.Add(this.label2);
            this.grbInformacionCliente.Controls.Add(this.lblNombreCliente);
            this.grbInformacionCliente.Controls.Add(this.txtNombreCliente);
            this.grbInformacionCliente.Controls.Add(this.label1);
            this.grbInformacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacionCliente.Location = new System.Drawing.Point(531, 69);
            this.grbInformacionCliente.Name = "grbInformacionCliente";
            this.grbInformacionCliente.Size = new System.Drawing.Size(503, 394);
            this.grbInformacionCliente.TabIndex = 10;
            this.grbInformacionCliente.TabStop = false;
            this.grbInformacionCliente.Text = "Información del cliente";
            // 
            // dtpNacimientoCliente
            // 
            this.dtpNacimientoCliente.Enabled = false;
            this.dtpNacimientoCliente.Location = new System.Drawing.Point(185, 144);
            this.dtpNacimientoCliente.Name = "dtpNacimientoCliente";
            this.dtpNacimientoCliente.Size = new System.Drawing.Size(280, 26);
            this.dtpNacimientoCliente.TabIndex = 14;
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(154, 359);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.ReadOnly = true;
            this.txtCorreoCliente.Size = new System.Drawing.Size(208, 26);
            this.txtCorreoCliente.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Correo electrónico";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(115, 288);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(249, 26);
            this.txtDireccionCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dirección";
            // 
            // grbNavegacionCliente
            // 
            this.grbNavegacionCliente.Controls.Add(this.btnUltimoCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnPrimeroCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnSiguienteCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnAnteriorCliente);
            this.grbNavegacionCliente.Controls.Add(this.lblNRegistroCliente);
            this.grbNavegacionCliente.Controls.Add(this.btnRegresar);
            this.grbNavegacionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNavegacionCliente.Location = new System.Drawing.Point(530, 469);
            this.grbNavegacionCliente.Name = "grbNavegacionCliente";
            this.grbNavegacionCliente.Size = new System.Drawing.Size(200, 100);
            this.grbNavegacionCliente.TabIndex = 11;
            this.grbNavegacionCliente.TabStop = false;
            this.grbNavegacionCliente.Text = "Navegación";
            // 
            // btnUltimoCliente
            // 
            this.btnUltimoCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUltimoCliente.Location = new System.Drawing.Point(166, 36);
            this.btnUltimoCliente.Name = "btnUltimoCliente";
            this.btnUltimoCliente.Size = new System.Drawing.Size(34, 26);
            this.btnUltimoCliente.TabIndex = 5;
            this.btnUltimoCliente.Text = ">|";
            this.btnUltimoCliente.UseVisualStyleBackColor = true;
            this.btnUltimoCliente.Click += new System.EventHandler(this.btnUltimoCliente_Click);
            // 
            // btnPrimeroCliente
            // 
            this.btnPrimeroCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimeroCliente.Location = new System.Drawing.Point(6, 36);
            this.btnPrimeroCliente.Name = "btnPrimeroCliente";
            this.btnPrimeroCliente.Size = new System.Drawing.Size(33, 25);
            this.btnPrimeroCliente.TabIndex = 4;
            this.btnPrimeroCliente.Text = "|<";
            this.btnPrimeroCliente.UseVisualStyleBackColor = true;
            this.btnPrimeroCliente.Click += new System.EventHandler(this.btnPrimeroCliente_Click);
            // 
            // btnSiguienteCliente
            // 
            this.btnSiguienteCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSiguienteCliente.Location = new System.Drawing.Point(132, 36);
            this.btnSiguienteCliente.Name = "btnSiguienteCliente";
            this.btnSiguienteCliente.Size = new System.Drawing.Size(28, 26);
            this.btnSiguienteCliente.TabIndex = 3;
            this.btnSiguienteCliente.Text = ">";
            this.btnSiguienteCliente.UseVisualStyleBackColor = true;
            this.btnSiguienteCliente.Click += new System.EventHandler(this.btnSiguienteCliente_Click);
            // 
            // btnAnteriorCliente
            // 
            this.btnAnteriorCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnteriorCliente.Location = new System.Drawing.Point(41, 36);
            this.btnAnteriorCliente.Name = "btnAnteriorCliente";
            this.btnAnteriorCliente.Size = new System.Drawing.Size(28, 26);
            this.btnAnteriorCliente.TabIndex = 2;
            this.btnAnteriorCliente.Text = "<";
            this.btnAnteriorCliente.UseVisualStyleBackColor = true;
            this.btnAnteriorCliente.Click += new System.EventHandler(this.btnAnteriorCliente_Click);
            // 
            // lblNRegistroCliente
            // 
            this.lblNRegistroCliente.AutoSize = true;
            this.lblNRegistroCliente.Location = new System.Drawing.Point(75, 37);
            this.lblNRegistroCliente.Name = "lblNRegistroCliente";
            this.lblNRegistroCliente.Size = new System.Drawing.Size(51, 20);
            this.lblNRegistroCliente.TabIndex = 1;
            this.lblNRegistroCliente.Text = "x de n";
            // 
            // grbEdicionCliente
            // 
            this.grbEdicionCliente.Controls.Add(this.btnEliminarCliente);
            this.grbEdicionCliente.Controls.Add(this.btnModificarCliente);
            this.grbEdicionCliente.Controls.Add(this.btnNuevoCliente);
            this.grbEdicionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicionCliente.Location = new System.Drawing.Point(736, 469);
            this.grbEdicionCliente.Name = "grbEdicionCliente";
            this.grbEdicionCliente.Size = new System.Drawing.Size(297, 100);
            this.grbEdicionCliente.TabIndex = 12;
            this.grbEdicionCliente.TabStop = false;
            this.grbEdicionCliente.Text = "Edición";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarCliente.Location = new System.Drawing.Point(200, 36);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(87, 52);
            this.btnEliminarCliente.TabIndex = 5;
            this.btnEliminarCliente.Text = "Eliminar cliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarCliente.Location = new System.Drawing.Point(107, 36);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(87, 52);
            this.btnModificarCliente.TabIndex = 4;
            this.btnModificarCliente.Text = "Modificar datos";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNuevoCliente.Location = new System.Drawing.Point(14, 36);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(87, 52);
            this.btnNuevoCliente.TabIndex = 3;
            this.btnNuevoCliente.Text = "Nuevo cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // erpClientes
            // 
            this.erpClientes.ContainerControl = this;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "idCliente";
            this.idCliente.HeaderText = "ID";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nacimientoCliente
            // 
            this.nacimientoCliente.DataPropertyName = "fechaNacimiento";
            this.nacimientoCliente.HeaderText = "FECHA DE NACIMIENTO";
            this.nacimientoCliente.Name = "nacimientoCliente";
            this.nacimientoCliente.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 50;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "CORREO";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 200;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnRegresar;
            this.ClientSize = new System.Drawing.Size(1046, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbEdicionCliente);
            this.Controls.Add(this.grbNavegacionCliente);
            this.Controls.Add(this.grbInformacionCliente);
            this.Controls.Add(this.grbListaClientes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Location = new System.Drawing.Point(500, 200);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaClientes)).EndInit();
            this.grbListaClientes.ResumeLayout(false);
            this.grbListaClientes.PerformLayout();
            this.grbInformacionCliente.ResumeLayout(false);
            this.grbInformacionCliente.PerformLayout();
            this.grbNavegacionCliente.ResumeLayout(false);
            this.grbNavegacionCliente.PerformLayout();
            this.grbEdicionCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridView grdListaClientes;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.GroupBox grbListaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbInformacionCliente;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbNavegacionCliente;
        private System.Windows.Forms.Button btnUltimoCliente;
        private System.Windows.Forms.Button btnPrimeroCliente;
        private System.Windows.Forms.Button btnSiguienteCliente;
        private System.Windows.Forms.Button btnAnteriorCliente;
        private System.Windows.Forms.Label lblNRegistroCliente;
        private System.Windows.Forms.GroupBox grbEdicionCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.ComboBox cboOpcionBuscarClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNacimientoCliente;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider erpClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacimientoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
    }
}