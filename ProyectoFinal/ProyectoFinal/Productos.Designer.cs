
namespace ProyectoFinal
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
            this.grbEdicionProducto = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.grbNavegacionProducto = new System.Windows.Forms.GroupBox();
            this.btnUltimoProducto = new System.Windows.Forms.Button();
            this.btnPrimeroProducto = new System.Windows.Forms.Button();
            this.btnSiguienteProducto = new System.Windows.Forms.Button();
            this.btnAnteriorProducto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.grbInformacionProducto = new System.Windows.Forms.GroupBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrincipiosActivosProducto = new System.Windows.Forms.TextBox();
            this.txtMarcaProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbListaProductos = new System.Windows.Forms.GroupBox();
            this.cboOpcionBuscarProductos = new System.Windows.Forms.ComboBox();
            this.txtBuscarProductos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdListaProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.principiosActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erpProductos = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbEdicionProducto.SuspendLayout();
            this.grbNavegacionProducto.SuspendLayout();
            this.grbInformacionProducto.SuspendLayout();
            this.grbListaProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbEdicionProducto
            // 
            this.grbEdicionProducto.Controls.Add(this.btnEliminarProducto);
            this.grbEdicionProducto.Controls.Add(this.btnModificarProducto);
            this.grbEdicionProducto.Controls.Add(this.btnNuevoProducto);
            this.grbEdicionProducto.Location = new System.Drawing.Point(741, 342);
            this.grbEdicionProducto.Name = "grbEdicionProducto";
            this.grbEdicionProducto.Size = new System.Drawing.Size(282, 100);
            this.grbEdicionProducto.TabIndex = 16;
            this.grbEdicionProducto.TabStop = false;
            this.grbEdicionProducto.Text = "Edición";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEliminarProducto.Location = new System.Drawing.Point(192, 36);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(87, 40);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnModificarProducto.Location = new System.Drawing.Point(99, 36);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(87, 40);
            this.btnModificarProducto.TabIndex = 4;
            this.btnModificarProducto.Text = "Modificar datos";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNuevoProducto.Location = new System.Drawing.Point(6, 36);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(87, 40);
            this.btnNuevoProducto.TabIndex = 3;
            this.btnNuevoProducto.Text = "Nuevo producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // grbNavegacionProducto
            // 
            this.grbNavegacionProducto.Controls.Add(this.btnUltimoProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnPrimeroProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnSiguienteProducto);
            this.grbNavegacionProducto.Controls.Add(this.btnAnteriorProducto);
            this.grbNavegacionProducto.Controls.Add(this.label5);
            this.grbNavegacionProducto.Controls.Add(this.btnRegresar);
            this.grbNavegacionProducto.Location = new System.Drawing.Point(541, 342);
            this.grbNavegacionProducto.Name = "grbNavegacionProducto";
            this.grbNavegacionProducto.Size = new System.Drawing.Size(200, 100);
            this.grbNavegacionProducto.TabIndex = 15;
            this.grbNavegacionProducto.TabStop = false;
            this.grbNavegacionProducto.Text = "Navegación";
            // 
            // btnUltimoProducto
            // 
            this.btnUltimoProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUltimoProducto.Location = new System.Drawing.Point(155, 36);
            this.btnUltimoProducto.Name = "btnUltimoProducto";
            this.btnUltimoProducto.Size = new System.Drawing.Size(28, 23);
            this.btnUltimoProducto.TabIndex = 5;
            this.btnUltimoProducto.Text = ">|";
            this.btnUltimoProducto.UseVisualStyleBackColor = true;
            // 
            // btnPrimeroProducto
            // 
            this.btnPrimeroProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPrimeroProducto.Location = new System.Drawing.Point(11, 36);
            this.btnPrimeroProducto.Name = "btnPrimeroProducto";
            this.btnPrimeroProducto.Size = new System.Drawing.Size(28, 23);
            this.btnPrimeroProducto.TabIndex = 4;
            this.btnPrimeroProducto.Text = "|<";
            this.btnPrimeroProducto.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteProducto
            // 
            this.btnSiguienteProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSiguienteProducto.Location = new System.Drawing.Point(121, 36);
            this.btnSiguienteProducto.Name = "btnSiguienteProducto";
            this.btnSiguienteProducto.Size = new System.Drawing.Size(28, 23);
            this.btnSiguienteProducto.TabIndex = 3;
            this.btnSiguienteProducto.Text = ">";
            this.btnSiguienteProducto.UseVisualStyleBackColor = true;
            // 
            // btnAnteriorProducto
            // 
            this.btnAnteriorProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnteriorProducto.Location = new System.Drawing.Point(45, 36);
            this.btnAnteriorProducto.Name = "btnAnteriorProducto";
            this.btnAnteriorProducto.Size = new System.Drawing.Size(28, 23);
            this.btnAnteriorProducto.TabIndex = 2;
            this.btnAnteriorProducto.Text = "<";
            this.btnAnteriorProducto.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "x de n";
            // 
            // btnRegresar
            // 
            this.btnRegresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRegresar.Location = new System.Drawing.Point(59, 65);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // grbInformacionProducto
            // 
            this.grbInformacionProducto.Controls.Add(this.txtPrecioProducto);
            this.grbInformacionProducto.Controls.Add(this.label4);
            this.grbInformacionProducto.Controls.Add(this.txtDescripcionProducto);
            this.grbInformacionProducto.Controls.Add(this.label3);
            this.grbInformacionProducto.Controls.Add(this.txtPrincipiosActivosProducto);
            this.grbInformacionProducto.Controls.Add(this.txtMarcaProducto);
            this.grbInformacionProducto.Controls.Add(this.label2);
            this.grbInformacionProducto.Controls.Add(this.lblNombreCliente);
            this.grbInformacionProducto.Controls.Add(this.txtNombreProducto);
            this.grbInformacionProducto.Controls.Add(this.label1);
            this.grbInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInformacionProducto.Location = new System.Drawing.Point(541, 13);
            this.grbInformacionProducto.Name = "grbInformacionProducto";
            this.grbInformacionProducto.Size = new System.Drawing.Size(483, 323);
            this.grbInformacionProducto.TabIndex = 14;
            this.grbInformacionProducto.TabStop = false;
            this.grbInformacionProducto.Text = "Información del producto";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(88, 273);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 26);
            this.txtPrecioProducto.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(121, 217);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(265, 26);
            this.txtDescripcionProducto.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // txtPrincipiosActivosProducto
            // 
            this.txtPrincipiosActivosProducto.Location = new System.Drawing.Point(165, 156);
            this.txtPrincipiosActivosProducto.Name = "txtPrincipiosActivosProducto";
            this.txtPrincipiosActivosProducto.Size = new System.Drawing.Size(221, 26);
            this.txtPrincipiosActivosProducto.TabIndex = 9;
            // 
            // txtMarcaProducto
            // 
            this.txtMarcaProducto.Location = new System.Drawing.Point(100, 102);
            this.txtMarcaProducto.Name = "txtMarcaProducto";
            this.txtMarcaProducto.Size = new System.Drawing.Size(286, 26);
            this.txtMarcaProducto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Principios Activos";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(29, 62);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(65, 20);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(100, 59);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(286, 26);
            this.txtNombreProducto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marca";
            // 
            // grbListaProductos
            // 
            this.grbListaProductos.Controls.Add(this.cboOpcionBuscarProductos);
            this.grbListaProductos.Controls.Add(this.txtBuscarProductos);
            this.grbListaProductos.Controls.Add(this.label6);
            this.grbListaProductos.Controls.Add(this.grdListaProductos);
            this.grbListaProductos.Location = new System.Drawing.Point(12, 12);
            this.grbListaProductos.Name = "grbListaProductos";
            this.grbListaProductos.Size = new System.Drawing.Size(523, 498);
            this.grbListaProductos.TabIndex = 13;
            this.grbListaProductos.TabStop = false;
            this.grbListaProductos.Text = "Lista de Productos";
            // 
            // cboOpcionBuscarProductos
            // 
            this.cboOpcionBuscarProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpcionBuscarProductos.FormattingEnabled = true;
            this.cboOpcionBuscarProductos.Items.AddRange(new object[] {
            "Nombre",
            "Marca",
            "Principios activos",
            "Precio"});
            this.cboOpcionBuscarProductos.Location = new System.Drawing.Point(47, 47);
            this.cboOpcionBuscarProductos.Name = "cboOpcionBuscarProductos";
            this.cboOpcionBuscarProductos.Size = new System.Drawing.Size(101, 21);
            this.cboOpcionBuscarProductos.TabIndex = 19;
            // 
            // txtBuscarProductos
            // 
            this.txtBuscarProductos.Location = new System.Drawing.Point(154, 47);
            this.txtBuscarProductos.Name = "txtBuscarProductos";
            this.txtBuscarProductos.Size = new System.Drawing.Size(175, 20);
            this.txtBuscarProductos.TabIndex = 18;
            this.txtBuscarProductos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProductos_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Buscar:";
            // 
            // grdListaProductos
            // 
            this.grdListaProductos.AllowUserToAddRows = false;
            this.grdListaProductos.AllowUserToDeleteRows = false;
            this.grdListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.marca,
            this.principiosActivos,
            this.descripcion,
            this.precio});
            this.grdListaProductos.Location = new System.Drawing.Point(0, 73);
            this.grdListaProductos.Name = "grdListaProductos";
            this.grdListaProductos.ReadOnly = true;
            this.grdListaProductos.Size = new System.Drawing.Size(523, 425);
            this.grdListaProductos.TabIndex = 1;
            this.grdListaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListaProductos_CellClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // principiosActivos
            // 
            this.principiosActivos.DataPropertyName = "principiosActivos";
            this.principiosActivos.HeaderText = "PRINCIPIOS ACTIVOS";
            this.principiosActivos.Name = "principiosActivos";
            this.principiosActivos.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "PRECIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // erpProductos
            // 
            this.erpProductos.ContainerControl = this;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 749);
            this.ControlBox = false;
            this.Controls.Add(this.grbEdicionProducto);
            this.Controls.Add(this.grbNavegacionProducto);
            this.Controls.Add(this.grbInformacionProducto);
            this.Controls.Add(this.grbListaProductos);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.grbEdicionProducto.ResumeLayout(false);
            this.grbNavegacionProducto.ResumeLayout(false);
            this.grbNavegacionProducto.PerformLayout();
            this.grbInformacionProducto.ResumeLayout(false);
            this.grbInformacionProducto.PerformLayout();
            this.grbListaProductos.ResumeLayout(false);
            this.grbListaProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdicionProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.GroupBox grbNavegacionProducto;
        private System.Windows.Forms.Button btnUltimoProducto;
        private System.Windows.Forms.Button btnPrimeroProducto;
        private System.Windows.Forms.Button btnSiguienteProducto;
        private System.Windows.Forms.Button btnAnteriorProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.GroupBox grbInformacionProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrincipiosActivosProducto;
        private System.Windows.Forms.TextBox txtMarcaProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbListaProductos;
        private System.Windows.Forms.DataGridView grdListaProductos;
        private System.Windows.Forms.ComboBox cboOpcionBuscarProductos;
        private System.Windows.Forms.TextBox txtBuscarProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn principiosActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.ErrorProvider erpProductos;
    }
}