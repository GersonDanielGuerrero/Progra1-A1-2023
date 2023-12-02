
namespace ProyectoFinal_Progra_I
{
    partial class Agenda
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
            this.lblTituloAgenda = new System.Windows.Forms.Label();
            this.calAgenda = new System.Windows.Forms.MonthCalendar();
            this.btnNuevaCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnDetallesCita = new System.Windows.Forms.Button();
            this.grdDatosAgenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloAgenda
            // 
            this.lblTituloAgenda.AutoSize = true;
            this.lblTituloAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAgenda.Location = new System.Drawing.Point(82, 25);
            this.lblTituloAgenda.Name = "lblTituloAgenda";
            this.lblTituloAgenda.Size = new System.Drawing.Size(170, 20);
            this.lblTituloAgenda.TabIndex = 0;
            this.lblTituloAgenda.Text = "Agenda de la clínica";
            // 
            // calAgenda
            // 
            this.calAgenda.Location = new System.Drawing.Point(86, 73);
            this.calAgenda.Name = "calAgenda";
            this.calAgenda.TabIndex = 1;
            // 
            // btnNuevaCita
            // 
            this.btnNuevaCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCita.Location = new System.Drawing.Point(12, 264);
            this.btnNuevaCita.Name = "btnNuevaCita";
            this.btnNuevaCita.Size = new System.Drawing.Size(120, 37);
            this.btnNuevaCita.TabIndex = 2;
            this.btnNuevaCita.Text = "Nueva cita";
            this.btnNuevaCita.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCita.Location = new System.Drawing.Point(157, 264);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(120, 37);
            this.btnEliminarCita.TabIndex = 3;
            this.btnEliminarCita.Text = "Eliminar cita";
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            // 
            // btnDetallesCita
            // 
            this.btnDetallesCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetallesCita.Location = new System.Drawing.Point(304, 264);
            this.btnDetallesCita.Name = "btnDetallesCita";
            this.btnDetallesCita.Size = new System.Drawing.Size(120, 37);
            this.btnDetallesCita.TabIndex = 4;
            this.btnDetallesCita.Text = "Ver detalles";
            this.btnDetallesCita.UseVisualStyleBackColor = true;
            // 
            // grdDatosAgenda
            // 
            this.grdDatosAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatosAgenda.Location = new System.Drawing.Point(442, 64);
            this.grdDatosAgenda.Name = "grdDatosAgenda";
            this.grdDatosAgenda.Size = new System.Drawing.Size(442, 194);
            this.grdDatosAgenda.TabIndex = 5;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.ControlBox = false;
            this.Controls.Add(this.grdDatosAgenda);
            this.Controls.Add(this.btnDetallesCita);
            this.Controls.Add(this.btnEliminarCita);
            this.Controls.Add(this.btnNuevaCita);
            this.Controls.Add(this.calAgenda);
            this.Controls.Add(this.lblTituloAgenda);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grdDatosAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloAgenda;
        private System.Windows.Forms.MonthCalendar calAgenda;
        private System.Windows.Forms.Button btnNuevaCita;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Button btnDetallesCita;
        private System.Windows.Forms.DataGridView grdDatosAgenda;
    }
}