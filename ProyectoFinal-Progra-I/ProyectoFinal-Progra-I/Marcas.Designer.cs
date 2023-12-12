
namespace ProyectoFinal_Progra_I
{
    partial class Marcas
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
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.txtNuevaMarca = new System.Windows.Forms.TextBox();
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.lblAgregarNuevaMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMarca.Location = new System.Drawing.Point(126, 169);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarMarca.TabIndex = 14;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarMarca.Location = new System.Drawing.Point(236, 169);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(88, 30);
            this.btnCancelarMarca.TabIndex = 13;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            // 
            // txtNuevaMarca
            // 
            this.txtNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaMarca.Location = new System.Drawing.Point(181, 104);
            this.txtNuevaMarca.Name = "txtNuevaMarca";
            this.txtNuevaMarca.Size = new System.Drawing.Size(176, 26);
            this.txtNuevaMarca.TabIndex = 12;
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaMarca.Location = new System.Drawing.Point(52, 110);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(113, 20);
            this.lblNuevaMarca.TabIndex = 11;
            this.lblNuevaMarca.Text = "Nuevo marca";
            // 
            // lblAgregarNuevaMarca
            // 
            this.lblAgregarNuevaMarca.AutoSize = true;
            this.lblAgregarNuevaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevaMarca.Location = new System.Drawing.Point(134, 44);
            this.lblAgregarNuevaMarca.Name = "lblAgregarNuevaMarca";
            this.lblAgregarNuevaMarca.Size = new System.Drawing.Size(180, 20);
            this.lblAgregarNuevaMarca.TabIndex = 10;
            this.lblAgregarNuevaMarca.Text = "Agregar nueva marca";
            // 
            // Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 288);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.txtNuevaMarca);
            this.Controls.Add(this.lblNuevaMarca);
            this.Controls.Add(this.lblAgregarNuevaMarca);
            this.Name = "Marcas";
            this.Text = "Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.TextBox txtNuevaMarca;
        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.Label lblAgregarNuevaMarca;
    }
}