
namespace ProyectoFinal_Progra_I
{
    partial class tipoProductos
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
            this.btnAgregarTipoDeProducto = new System.Windows.Forms.Button();
            this.btnCancelarTipoDeProducto = new System.Windows.Forms.Button();
            this.txtNuevoTipoDeProducto = new System.Windows.Forms.TextBox();
            this.lblNuevoTipoDeProducto = new System.Windows.Forms.Label();
            this.lblAgregarNuevoTipoDeProducto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarTipoDeProducto
            // 
            this.btnAgregarTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTipoDeProducto.Location = new System.Drawing.Point(127, 197);
            this.btnAgregarTipoDeProducto.Name = "btnAgregarTipoDeProducto";
            this.btnAgregarTipoDeProducto.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarTipoDeProducto.TabIndex = 14;
            this.btnAgregarTipoDeProducto.Text = "Agregar";
            this.btnAgregarTipoDeProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarTipoDeProducto
            // 
            this.btnCancelarTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTipoDeProducto.Location = new System.Drawing.Point(237, 197);
            this.btnCancelarTipoDeProducto.Name = "btnCancelarTipoDeProducto";
            this.btnCancelarTipoDeProducto.Size = new System.Drawing.Size(88, 30);
            this.btnCancelarTipoDeProducto.TabIndex = 13;
            this.btnCancelarTipoDeProducto.Text = "Cancelar";
            this.btnCancelarTipoDeProducto.UseVisualStyleBackColor = true;
            // 
            // txtNuevoTipoDeProducto
            // 
            this.txtNuevoTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoTipoDeProducto.Location = new System.Drawing.Point(237, 126);
            this.txtNuevoTipoDeProducto.Name = "txtNuevoTipoDeProducto";
            this.txtNuevoTipoDeProducto.Size = new System.Drawing.Size(176, 26);
            this.txtNuevoTipoDeProducto.TabIndex = 12;
            // 
            // lblNuevoTipoDeProducto
            // 
            this.lblNuevoTipoDeProducto.AutoSize = true;
            this.lblNuevoTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoTipoDeProducto.Location = new System.Drawing.Point(35, 129);
            this.lblNuevoTipoDeProducto.Name = "lblNuevoTipoDeProducto";
            this.lblNuevoTipoDeProducto.Size = new System.Drawing.Size(195, 20);
            this.lblNuevoTipoDeProducto.TabIndex = 11;
            this.lblNuevoTipoDeProducto.Text = "Nuevo tipo de producto";
            // 
            // lblAgregarNuevoTipoDeProducto
            // 
            this.lblAgregarNuevoTipoDeProducto.AutoSize = true;
            this.lblAgregarNuevoTipoDeProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevoTipoDeProducto.Location = new System.Drawing.Point(94, 61);
            this.lblAgregarNuevoTipoDeProducto.Name = "lblAgregarNuevoTipoDeProducto";
            this.lblAgregarNuevoTipoDeProducto.Size = new System.Drawing.Size(262, 20);
            this.lblAgregarNuevoTipoDeProducto.TabIndex = 10;
            this.lblAgregarNuevoTipoDeProducto.Text = "Agregar nuevo tipo de producto";
            // 
            // tipoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 288);
            this.Controls.Add(this.btnAgregarTipoDeProducto);
            this.Controls.Add(this.btnCancelarTipoDeProducto);
            this.Controls.Add(this.txtNuevoTipoDeProducto);
            this.Controls.Add(this.lblNuevoTipoDeProducto);
            this.Controls.Add(this.lblAgregarNuevoTipoDeProducto);
            this.Name = "tipoProductos";
            this.Text = "tipoProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarTipoDeProducto;
        private System.Windows.Forms.Button btnCancelarTipoDeProducto;
        private System.Windows.Forms.TextBox txtNuevoTipoDeProducto;
        private System.Windows.Forms.Label lblNuevoTipoDeProducto;
        private System.Windows.Forms.Label lblAgregarNuevoTipoDeProducto;
    }
}