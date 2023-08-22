
namespace PracticaProgramacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDeConversor = new System.Windows.Forms.ComboBox();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.cboAConversor = new System.Windows.Forms.ComboBox();
            this.btnConvertirConversor = new System.Windows.Forms.Button();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.lblCantidadConversores = new System.Windows.Forms.Label();
            this.txtCantidadConversores = new System.Windows.Forms.TextBox();
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.cboTipoConversor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboDeConversor
            // 
            this.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeConversor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDeConversor.FormattingEnabled = true;
            this.cboDeConversor.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Colon Salvadoreño",
            "Cordoba",
            "Peso Costarricense",
            "Yenes",
            "Libras Esterlinas",
            "Rupia India"});
            this.cboDeConversor.Location = new System.Drawing.Point(395, 116);
            this.cboDeConversor.Name = "cboDeConversor";
            this.cboDeConversor.Size = new System.Drawing.Size(121, 31);
            this.cboDeConversor.TabIndex = 0;
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(342, 120);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(44, 22);
            this.lblDeConversor.TabIndex = 1;
            this.lblDeConversor.Text = "DE:";
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(356, 168);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(30, 22);
            this.lblAConversor.TabIndex = 3;
            this.lblAConversor.Text = "A:";
            this.lblAConversor.Click += new System.EventHandler(this.lblAConversor_Click);
            // 
            // cboAConversor
            // 
            this.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAConversor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAConversor.FormattingEnabled = true;
            this.cboAConversor.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Colon Salvadoreño",
            "Cordoba",
            "Peso Costarricense",
            "Yenes",
            "Libras Esterlinas",
            "Rupia India"});
            this.cboAConversor.Location = new System.Drawing.Point(395, 164);
            this.cboAConversor.Name = "cboAConversor";
            this.cboAConversor.Size = new System.Drawing.Size(121, 31);
            this.cboAConversor.TabIndex = 2;
            // 
            // btnConvertirConversor
            // 
            this.btnConvertirConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertirConversor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvertirConversor.Location = new System.Drawing.Point(333, 316);
            this.btnConvertirConversor.Name = "btnConvertirConversor";
            this.btnConvertirConversor.Size = new System.Drawing.Size(139, 31);
            this.btnConvertirConversor.TabIndex = 4;
            this.btnConvertirConversor.Text = "CONVERTIR";
            this.btnConvertirConversor.UseVisualStyleBackColor = true;
            this.btnConvertirConversor.Click += new System.EventHandler(this.btnConvertirConversor_Click);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.Location = new System.Drawing.Point(342, 278);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(127, 22);
            this.lblRespuesta.TabIndex = 5;
            this.lblRespuesta.Text = "Respuesta:?";
            // 
            // lblCantidadConversores
            // 
            this.lblCantidadConversores.AutoSize = true;
            this.lblCantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversores.Location = new System.Drawing.Point(286, 229);
            this.lblCantidadConversores.Name = "lblCantidadConversores";
            this.lblCantidadConversores.Size = new System.Drawing.Size(93, 22);
            this.lblCantidadConversores.TabIndex = 6;
            this.lblCantidadConversores.Text = "Cantidad";
            // 
            // txtCantidadConversores
            // 
            this.txtCantidadConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadConversores.Location = new System.Drawing.Point(395, 226);
            this.txtCantidadConversores.Name = "txtCantidadConversores";
            this.txtCantidadConversores.Size = new System.Drawing.Size(121, 29);
            this.txtCantidadConversores.TabIndex = 7;
            this.txtCantidadConversores.Text = "1";
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(329, 71);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(63, 22);
            this.lblTipoConversor.TabIndex = 9;
            this.lblTipoConversor.Text = "TIPO:";
            // 
            // cboTipoConversor
            // 
            this.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConversor.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoConversor.FormattingEnabled = true;
            this.cboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.cboTipoConversor.Location = new System.Drawing.Point(395, 67);
            this.cboTipoConversor.Name = "cboTipoConversor";
            this.cboTipoConversor.Size = new System.Drawing.Size(121, 31);
            this.cboTipoConversor.TabIndex = 8;
            this.cboTipoConversor.TextChanged += new System.EventHandler(this.cboTipoConversor_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTipoConversor);
            this.Controls.Add(this.cboTipoConversor);
            this.Controls.Add(this.txtCantidadConversores);
            this.Controls.Add(this.lblCantidadConversores);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.btnConvertirConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.cboAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.cboDeConversor);
            this.Name = "Form1";
            this.Text = "Respuesta: ?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDeConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.ComboBox cboAConversor;
        private System.Windows.Forms.Button btnConvertirConversor;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.Label lblCantidadConversores;
        private System.Windows.Forms.TextBox txtCantidadConversores;
        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.ComboBox cboTipoConversor;
    }
}

