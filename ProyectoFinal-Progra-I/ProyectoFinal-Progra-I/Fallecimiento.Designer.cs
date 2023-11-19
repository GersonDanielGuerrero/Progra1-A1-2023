
namespace ProyectoFinal_Progra_I
{
    partial class Fallecimiento
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFallecimientoPaciente = new System.Windows.Forms.Label();
            this.txtCausaFallecimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFallecimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(385, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 33);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(212, 227);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 33);
            this.btnAceptar.TabIndex = 26;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblFallecimientoPaciente
            // 
            this.lblFallecimientoPaciente.AutoSize = true;
            this.lblFallecimientoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallecimientoPaciente.Location = new System.Drawing.Point(226, 28);
            this.lblFallecimientoPaciente.Name = "lblFallecimientoPaciente";
            this.lblFallecimientoPaciente.Size = new System.Drawing.Size(215, 20);
            this.lblFallecimientoPaciente.TabIndex = 25;
            this.lblFallecimientoPaciente.Text = "Fallecimiento de Paciente";
            // 
            // txtCausaFallecimiento
            // 
            this.txtCausaFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausaFallecimiento.Location = new System.Drawing.Point(212, 165);
            this.txtCausaFallecimiento.Name = "txtCausaFallecimiento";
            this.txtCausaFallecimiento.Size = new System.Drawing.Size(430, 26);
            this.txtCausaFallecimiento.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Causa de fallecimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Fecha de fallecmiento";
            // 
            // dtpFechaFallecimiento
            // 
            this.dtpFechaFallecimiento.CustomFormat = "dddd d \'de\' MMMM \'de\' yyyy  hh:mm tt";
            this.dtpFechaFallecimiento.Enabled = false;
            this.dtpFechaFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFallecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFallecimiento.Location = new System.Drawing.Point(212, 83);
            this.dtpFechaFallecimiento.Name = "dtpFechaFallecimiento";
            this.dtpFechaFallecimiento.Size = new System.Drawing.Size(430, 26);
            this.dtpFechaFallecimiento.TabIndex = 28;
            // 
            // Fallecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 291);
            this.Controls.Add(this.dtpFechaFallecimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblFallecimientoPaciente);
            this.Controls.Add(this.txtCausaFallecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Fallecimiento";
            this.Text = "Fallecimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFallecimientoPaciente;
        private System.Windows.Forms.TextBox txtCausaFallecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFallecimiento;
    }
}