
namespace ProyectoFinal_Progra_I
{
    partial class Especies
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
            this.btnAgregarEspecie = new System.Windows.Forms.Button();
            this.btnCancelarEspecie = new System.Windows.Forms.Button();
            this.txtNuevaEspecie = new System.Windows.Forms.TextBox();
            this.lblNuevaEspecie = new System.Windows.Forms.Label();
            this.lblAgregarNuevaEspecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarEspecie
            // 
            this.btnAgregarEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecie.Location = new System.Drawing.Point(162, 163);
            this.btnAgregarEspecie.Name = "btnAgregarEspecie";
            this.btnAgregarEspecie.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarEspecie.TabIndex = 9;
            this.btnAgregarEspecie.Text = "Agregar";
            this.btnAgregarEspecie.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEspecie
            // 
            this.btnCancelarEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEspecie.Location = new System.Drawing.Point(286, 163);
            this.btnCancelarEspecie.Name = "btnCancelarEspecie";
            this.btnCancelarEspecie.Size = new System.Drawing.Size(88, 30);
            this.btnCancelarEspecie.TabIndex = 8;
            this.btnCancelarEspecie.Text = "Cancelar";
            this.btnCancelarEspecie.UseVisualStyleBackColor = true;
            // 
            // txtNuevaEspecie
            // 
            this.txtNuevaEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaEspecie.Location = new System.Drawing.Point(184, 107);
            this.txtNuevaEspecie.Name = "txtNuevaEspecie";
            this.txtNuevaEspecie.Size = new System.Drawing.Size(176, 26);
            this.txtNuevaEspecie.TabIndex = 7;
            // 
            // lblNuevaEspecie
            // 
            this.lblNuevaEspecie.AutoSize = true;
            this.lblNuevaEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaEspecie.Location = new System.Drawing.Point(50, 110);
            this.lblNuevaEspecie.Name = "lblNuevaEspecie";
            this.lblNuevaEspecie.Size = new System.Drawing.Size(126, 20);
            this.lblNuevaEspecie.TabIndex = 6;
            this.lblNuevaEspecie.Text = "Nueva especie";
            // 
            // lblAgregarNuevaEspecie
            // 
            this.lblAgregarNuevaEspecie.AutoSize = true;
            this.lblAgregarNuevaEspecie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevaEspecie.Location = new System.Drawing.Point(126, 29);
            this.lblAgregarNuevaEspecie.Name = "lblAgregarNuevaEspecie";
            this.lblAgregarNuevaEspecie.Size = new System.Drawing.Size(193, 20);
            this.lblAgregarNuevaEspecie.TabIndex = 5;
            this.lblAgregarNuevaEspecie.Text = "Agregar nueva especie";
            // 
            // Especies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 288);
            this.Controls.Add(this.btnAgregarEspecie);
            this.Controls.Add(this.btnCancelarEspecie);
            this.Controls.Add(this.txtNuevaEspecie);
            this.Controls.Add(this.lblNuevaEspecie);
            this.Controls.Add(this.lblAgregarNuevaEspecie);
            this.Name = "Especies";
            this.Text = "Especies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEspecie;
        private System.Windows.Forms.Button btnCancelarEspecie;
        private System.Windows.Forms.TextBox txtNuevaEspecie;
        private System.Windows.Forms.Label lblNuevaEspecie;
        private System.Windows.Forms.Label lblAgregarNuevaEspecie;
    }
}