
namespace ProyectoFinal_Progra_I
{
    partial class Razas
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
            this.btnAgregarRaza = new System.Windows.Forms.Button();
            this.btnCancelarRaza = new System.Windows.Forms.Button();
            this.lblNuevaRaza = new System.Windows.Forms.Label();
            this.lblAgregarNuevaRaza = new System.Windows.Forms.Label();
            this.txtNuevaRaza = new System.Windows.Forms.TextBox();
            this.lblIdEspecieRazas = new System.Windows.Forms.Label();
            this.cboEspecieRazas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAgregarRaza
            // 
            this.btnAgregarRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarRaza.Location = new System.Drawing.Point(140, 217);
            this.btnAgregarRaza.Name = "btnAgregarRaza";
            this.btnAgregarRaza.Size = new System.Drawing.Size(84, 30);
            this.btnAgregarRaza.TabIndex = 14;
            this.btnAgregarRaza.Text = "Agregar";
            this.btnAgregarRaza.UseVisualStyleBackColor = true;
            // 
            // btnCancelarRaza
            // 
            this.btnCancelarRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRaza.Location = new System.Drawing.Point(264, 217);
            this.btnCancelarRaza.Name = "btnCancelarRaza";
            this.btnCancelarRaza.Size = new System.Drawing.Size(88, 30);
            this.btnCancelarRaza.TabIndex = 13;
            this.btnCancelarRaza.Text = "Cancelar";
            this.btnCancelarRaza.UseVisualStyleBackColor = true;
            // 
            // lblNuevaRaza
            // 
            this.lblNuevaRaza.AutoSize = true;
            this.lblNuevaRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaRaza.Location = new System.Drawing.Point(28, 112);
            this.lblNuevaRaza.Name = "lblNuevaRaza";
            this.lblNuevaRaza.Size = new System.Drawing.Size(99, 20);
            this.lblNuevaRaza.TabIndex = 11;
            this.lblNuevaRaza.Text = "Nueva raza";
            // 
            // lblAgregarNuevaRaza
            // 
            this.lblAgregarNuevaRaza.AutoSize = true;
            this.lblAgregarNuevaRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarNuevaRaza.Location = new System.Drawing.Point(136, 31);
            this.lblAgregarNuevaRaza.Name = "lblAgregarNuevaRaza";
            this.lblAgregarNuevaRaza.Size = new System.Drawing.Size(166, 20);
            this.lblAgregarNuevaRaza.TabIndex = 10;
            this.lblAgregarNuevaRaza.Text = "Agregar nueva raza";
            // 
            // txtNuevaRaza
            // 
            this.txtNuevaRaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevaRaza.Location = new System.Drawing.Point(162, 109);
            this.txtNuevaRaza.Name = "txtNuevaRaza";
            this.txtNuevaRaza.Size = new System.Drawing.Size(176, 26);
            this.txtNuevaRaza.TabIndex = 12;
            // 
            // lblIdEspecieRazas
            // 
            this.lblIdEspecieRazas.AutoSize = true;
            this.lblIdEspecieRazas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEspecieRazas.Location = new System.Drawing.Point(54, 161);
            this.lblIdEspecieRazas.Name = "lblIdEspecieRazas";
            this.lblIdEspecieRazas.Size = new System.Drawing.Size(73, 20);
            this.lblIdEspecieRazas.TabIndex = 15;
            this.lblIdEspecieRazas.Text = "Especie";
            // 
            // cboEspecieRazas
            // 
            this.cboEspecieRazas.FormattingEnabled = true;
            this.cboEspecieRazas.Location = new System.Drawing.Point(162, 163);
            this.cboEspecieRazas.Name = "cboEspecieRazas";
            this.cboEspecieRazas.Size = new System.Drawing.Size(176, 21);
            this.cboEspecieRazas.TabIndex = 16;
            // 
            // Razas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 288);
            this.Controls.Add(this.cboEspecieRazas);
            this.Controls.Add(this.lblIdEspecieRazas);
            this.Controls.Add(this.btnAgregarRaza);
            this.Controls.Add(this.btnCancelarRaza);
            this.Controls.Add(this.txtNuevaRaza);
            this.Controls.Add(this.lblNuevaRaza);
            this.Controls.Add(this.lblAgregarNuevaRaza);
            this.Name = "Razas";
            this.Text = "Razas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarRaza;
        private System.Windows.Forms.Button btnCancelarRaza;
        private System.Windows.Forms.Label lblNuevaRaza;
        private System.Windows.Forms.Label lblAgregarNuevaRaza;
        private System.Windows.Forms.TextBox txtNuevaRaza;
        private System.Windows.Forms.Label lblIdEspecieRazas;
        private System.Windows.Forms.ComboBox cboEspecieRazas;
    }
}