
namespace ProyectoFinal_Progra_I
{
    partial class Colores
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
            this.lblNuevoAgregarColor = new System.Windows.Forms.Label();
            this.lblNuevoColor = new System.Windows.Forms.Label();
            this.txtNuevoColor = new System.Windows.Forms.TextBox();
            this.btnCancelarColor = new System.Windows.Forms.Button();
            this.btnAgregarColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevoAgregarColor
            // 
            this.lblNuevoAgregarColor.AutoSize = true;
            this.lblNuevoAgregarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoAgregarColor.Location = new System.Drawing.Point(132, 32);
            this.lblNuevoAgregarColor.Name = "lblNuevoAgregarColor";
            this.lblNuevoAgregarColor.Size = new System.Drawing.Size(170, 20);
            this.lblNuevoAgregarColor.TabIndex = 0;
            this.lblNuevoAgregarColor.Text = "Agregar nuevo color";
            // 
            // lblNuevoColor
            // 
            this.lblNuevoColor.AutoSize = true;
            this.lblNuevoColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoColor.Location = new System.Drawing.Point(66, 115);
            this.lblNuevoColor.Name = "lblNuevoColor";
            this.lblNuevoColor.Size = new System.Drawing.Size(103, 20);
            this.lblNuevoColor.TabIndex = 1;
            this.lblNuevoColor.Text = "Nuevo color";
            // 
            // txtNuevoColor
            // 
            this.txtNuevoColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoColor.Location = new System.Drawing.Point(188, 112);
            this.txtNuevoColor.Name = "txtNuevoColor";
            this.txtNuevoColor.Size = new System.Drawing.Size(176, 26);
            this.txtNuevoColor.TabIndex = 2;
            // 
            // btnCancelarColor
            // 
            this.btnCancelarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarColor.Location = new System.Drawing.Point(288, 168);
            this.btnCancelarColor.Name = "btnCancelarColor";
            this.btnCancelarColor.Size = new System.Drawing.Size(88, 30);
            this.btnCancelarColor.TabIndex = 3;
            this.btnCancelarColor.Text = "Cancelar";
            this.btnCancelarColor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarColor
            // 
            this.btnAgregarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarColor.Location = new System.Drawing.Point(178, 168);
            this.btnAgregarColor.Name = "btnAgregarColor";
            this.btnAgregarColor.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarColor.TabIndex = 4;
            this.btnAgregarColor.Text = "Agregar";
            this.btnAgregarColor.UseVisualStyleBackColor = true;
            // 
            // Colores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 288);
            this.Controls.Add(this.btnAgregarColor);
            this.Controls.Add(this.btnCancelarColor);
            this.Controls.Add(this.txtNuevoColor);
            this.Controls.Add(this.lblNuevoColor);
            this.Controls.Add(this.lblNuevoAgregarColor);
            this.Name = "Colores";
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevoAgregarColor;
        private System.Windows.Forms.Label lblNuevoColor;
        private System.Windows.Forms.TextBox txtNuevoColor;
        private System.Windows.Forms.Button btnCancelarColor;
        private System.Windows.Forms.Button btnAgregarColor;
    }
}