
namespace ProyectoFinal_Progra_I
{
    partial class casosClinicos
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
            this.casosClinicosDataGridView = new System.Windows.Forms.DataGridView();
            this.grbDatosCasoClinico = new System.Windows.Forms.GroupBox();
            this.lboConsultasCasoClinico = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblConsultasCasoClinico = new System.Windows.Forms.Label();
            this.lblPacienteCasoClinico = new System.Windows.Forms.Label();
            this.lblExamenesCasoClinico = new System.Windows.Forms.Label();
            this.cboPacienteCasoClinico = new System.Windows.Forms.ComboBox();
            this.lboExamenesCasoClinico = new System.Windows.Forms.ListBox();
            this.lboTratamientosCasoClinico = new System.Windows.Forms.ListBox();
            this.lboServiciosCasoClinico = new System.Windows.Forms.ListBox();
            this.grbNavegacionCasoClinico = new System.Windows.Forms.GroupBox();
            this.btnPrimeroCasoClinico = new System.Windows.Forms.Button();
            this.btnAnteriorCasoClinico = new System.Windows.Forms.Button();
            this.btnUltimoCasoClinico = new System.Windows.Forms.Button();
            this.btnSiguienteCasoClinico = new System.Windows.Forms.Button();
            this.lblPosicionCasoClinico = new System.Windows.Forms.Label();
            this.grbEdicionCasoClinico = new System.Windows.Forms.GroupBox();
            this.btnNuevoCasoClinico = new System.Windows.Forms.Button();
            this.btnModificarCasoClinico = new System.Windows.Forms.Button();
            this.btnEliminarCasoClinico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.casosClinicosDataGridView)).BeginInit();
            this.grbDatosCasoClinico.SuspendLayout();
            this.grbNavegacionCasoClinico.SuspendLayout();
            this.grbEdicionCasoClinico.SuspendLayout();
            this.SuspendLayout();
            // 
            // casosClinicosDataGridView
            // 
            this.casosClinicosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.casosClinicosDataGridView.Location = new System.Drawing.Point(43, 38);
            this.casosClinicosDataGridView.Name = "casosClinicosDataGridView";
            this.casosClinicosDataGridView.Size = new System.Drawing.Size(504, 313);
            this.casosClinicosDataGridView.TabIndex = 0;
            // 
            // grbDatosCasoClinico
            // 
            this.grbDatosCasoClinico.Controls.Add(this.lboServiciosCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.lboTratamientosCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.lboExamenesCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.cboPacienteCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.lboConsultasCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.label9);
            this.grbDatosCasoClinico.Controls.Add(this.label5);
            this.grbDatosCasoClinico.Controls.Add(this.lblConsultasCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.lblPacienteCasoClinico);
            this.grbDatosCasoClinico.Controls.Add(this.lblExamenesCasoClinico);
            this.grbDatosCasoClinico.Location = new System.Drawing.Point(580, 30);
            this.grbDatosCasoClinico.Name = "grbDatosCasoClinico";
            this.grbDatosCasoClinico.Size = new System.Drawing.Size(657, 362);
            this.grbDatosCasoClinico.TabIndex = 27;
            this.grbDatosCasoClinico.TabStop = false;
            this.grbDatosCasoClinico.Text = "Datos del caso clinico";
            // 
            // lboConsultasCasoClinico
            // 
            this.lboConsultasCasoClinico.DisplayMember = "nombre";
            this.lboConsultasCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lboConsultasCasoClinico.FormattingEnabled = true;
            this.lboConsultasCasoClinico.ItemHeight = 20;
            this.lboConsultasCasoClinico.Location = new System.Drawing.Point(194, 90);
            this.lboConsultasCasoClinico.Name = "lboConsultasCasoClinico";
            this.lboConsultasCasoClinico.Size = new System.Drawing.Size(429, 44);
            this.lboConsultasCasoClinico.TabIndex = 20;
            this.lboConsultasCasoClinico.ValueMember = "nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(93, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Servicios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tratamientos";
            // 
            // lblConsultasCasoClinico
            // 
            this.lblConsultasCasoClinico.AutoSize = true;
            this.lblConsultasCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultasCasoClinico.Location = new System.Drawing.Point(93, 101);
            this.lblConsultasCasoClinico.Name = "lblConsultasCasoClinico";
            this.lblConsultasCasoClinico.Size = new System.Drawing.Size(89, 20);
            this.lblConsultasCasoClinico.TabIndex = 2;
            this.lblConsultasCasoClinico.Text = "Consultas";
            // 
            // lblPacienteCasoClinico
            // 
            this.lblPacienteCasoClinico.AutoSize = true;
            this.lblPacienteCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteCasoClinico.Location = new System.Drawing.Point(111, 51);
            this.lblPacienteCasoClinico.Name = "lblPacienteCasoClinico";
            this.lblPacienteCasoClinico.Size = new System.Drawing.Size(79, 20);
            this.lblPacienteCasoClinico.TabIndex = 4;
            this.lblPacienteCasoClinico.Text = "Paciente";
            // 
            // lblExamenesCasoClinico
            // 
            this.lblExamenesCasoClinico.AutoSize = true;
            this.lblExamenesCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExamenesCasoClinico.Location = new System.Drawing.Point(90, 158);
            this.lblExamenesCasoClinico.Name = "lblExamenesCasoClinico";
            this.lblExamenesCasoClinico.Size = new System.Drawing.Size(92, 20);
            this.lblExamenesCasoClinico.TabIndex = 3;
            this.lblExamenesCasoClinico.Text = "Exámenes";
            // 
            // cboPacienteCasoClinico
            // 
            this.cboPacienteCasoClinico.FormattingEnabled = true;
            this.cboPacienteCasoClinico.Location = new System.Drawing.Point(195, 53);
            this.cboPacienteCasoClinico.Name = "cboPacienteCasoClinico";
            this.cboPacienteCasoClinico.Size = new System.Drawing.Size(430, 21);
            this.cboPacienteCasoClinico.TabIndex = 21;
            // 
            // lboExamenesCasoClinico
            // 
            this.lboExamenesCasoClinico.DisplayMember = "nombre";
            this.lboExamenesCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lboExamenesCasoClinico.FormattingEnabled = true;
            this.lboExamenesCasoClinico.ItemHeight = 20;
            this.lboExamenesCasoClinico.Location = new System.Drawing.Point(194, 149);
            this.lboExamenesCasoClinico.Name = "lboExamenesCasoClinico";
            this.lboExamenesCasoClinico.Size = new System.Drawing.Size(429, 44);
            this.lboExamenesCasoClinico.TabIndex = 22;
            this.lboExamenesCasoClinico.ValueMember = "nombre";
            // 
            // lboTratamientosCasoClinico
            // 
            this.lboTratamientosCasoClinico.DisplayMember = "nombre";
            this.lboTratamientosCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lboTratamientosCasoClinico.FormattingEnabled = true;
            this.lboTratamientosCasoClinico.ItemHeight = 20;
            this.lboTratamientosCasoClinico.Location = new System.Drawing.Point(196, 213);
            this.lboTratamientosCasoClinico.Name = "lboTratamientosCasoClinico";
            this.lboTratamientosCasoClinico.Size = new System.Drawing.Size(429, 44);
            this.lboTratamientosCasoClinico.TabIndex = 23;
            this.lboTratamientosCasoClinico.ValueMember = "nombre";
            // 
            // lboServiciosCasoClinico
            // 
            this.lboServiciosCasoClinico.DisplayMember = "nombre";
            this.lboServiciosCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lboServiciosCasoClinico.FormattingEnabled = true;
            this.lboServiciosCasoClinico.ItemHeight = 20;
            this.lboServiciosCasoClinico.Location = new System.Drawing.Point(194, 277);
            this.lboServiciosCasoClinico.Name = "lboServiciosCasoClinico";
            this.lboServiciosCasoClinico.Size = new System.Drawing.Size(429, 44);
            this.lboServiciosCasoClinico.TabIndex = 24;
            this.lboServiciosCasoClinico.ValueMember = "nombre";
            // 
            // grbNavegacionCasoClinico
            // 
            this.grbNavegacionCasoClinico.BackColor = System.Drawing.SystemColors.Control;
            this.grbNavegacionCasoClinico.Controls.Add(this.btnPrimeroCasoClinico);
            this.grbNavegacionCasoClinico.Controls.Add(this.btnAnteriorCasoClinico);
            this.grbNavegacionCasoClinico.Controls.Add(this.btnUltimoCasoClinico);
            this.grbNavegacionCasoClinico.Controls.Add(this.btnSiguienteCasoClinico);
            this.grbNavegacionCasoClinico.Controls.Add(this.lblPosicionCasoClinico);
            this.grbNavegacionCasoClinico.Location = new System.Drawing.Point(12, 396);
            this.grbNavegacionCasoClinico.Name = "grbNavegacionCasoClinico";
            this.grbNavegacionCasoClinico.Size = new System.Drawing.Size(278, 82);
            this.grbNavegacionCasoClinico.TabIndex = 29;
            this.grbNavegacionCasoClinico.TabStop = false;
            this.grbNavegacionCasoClinico.Text = "Navegación";
            // 
            // btnPrimeroCasoClinico
            // 
            this.btnPrimeroCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrimeroCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeroCasoClinico.Location = new System.Drawing.Point(14, 31);
            this.btnPrimeroCasoClinico.Name = "btnPrimeroCasoClinico";
            this.btnPrimeroCasoClinico.Size = new System.Drawing.Size(37, 30);
            this.btnPrimeroCasoClinico.TabIndex = 19;
            this.btnPrimeroCasoClinico.Text = "|<";
            this.btnPrimeroCasoClinico.UseVisualStyleBackColor = false;
            // 
            // btnAnteriorCasoClinico
            // 
            this.btnAnteriorCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorCasoClinico.Location = new System.Drawing.Point(57, 31);
            this.btnAnteriorCasoClinico.Name = "btnAnteriorCasoClinico";
            this.btnAnteriorCasoClinico.Size = new System.Drawing.Size(37, 30);
            this.btnAnteriorCasoClinico.TabIndex = 22;
            this.btnAnteriorCasoClinico.Text = "<";
            this.btnAnteriorCasoClinico.UseVisualStyleBackColor = false;
            // 
            // btnUltimoCasoClinico
            // 
            this.btnUltimoCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnUltimoCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoCasoClinico.Location = new System.Drawing.Point(231, 31);
            this.btnUltimoCasoClinico.Name = "btnUltimoCasoClinico";
            this.btnUltimoCasoClinico.Size = new System.Drawing.Size(37, 30);
            this.btnUltimoCasoClinico.TabIndex = 20;
            this.btnUltimoCasoClinico.Text = ">|";
            this.btnUltimoCasoClinico.UseVisualStyleBackColor = false;
            // 
            // btnSiguienteCasoClinico
            // 
            this.btnSiguienteCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguienteCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteCasoClinico.Location = new System.Drawing.Point(188, 31);
            this.btnSiguienteCasoClinico.Name = "btnSiguienteCasoClinico";
            this.btnSiguienteCasoClinico.Size = new System.Drawing.Size(37, 30);
            this.btnSiguienteCasoClinico.TabIndex = 21;
            this.btnSiguienteCasoClinico.Text = ">";
            this.btnSiguienteCasoClinico.UseVisualStyleBackColor = false;
            // 
            // lblPosicionCasoClinico
            // 
            this.lblPosicionCasoClinico.AutoSize = true;
            this.lblPosicionCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicionCasoClinico.Location = new System.Drawing.Point(107, 36);
            this.lblPosicionCasoClinico.Name = "lblPosicionCasoClinico";
            this.lblPosicionCasoClinico.Size = new System.Drawing.Size(57, 20);
            this.lblPosicionCasoClinico.TabIndex = 23;
            this.lblPosicionCasoClinico.Text = "x de n";
            // 
            // grbEdicionCasoClinico
            // 
            this.grbEdicionCasoClinico.Controls.Add(this.btnNuevoCasoClinico);
            this.grbEdicionCasoClinico.Controls.Add(this.btnModificarCasoClinico);
            this.grbEdicionCasoClinico.Controls.Add(this.btnEliminarCasoClinico);
            this.grbEdicionCasoClinico.Location = new System.Drawing.Point(321, 398);
            this.grbEdicionCasoClinico.Name = "grbEdicionCasoClinico";
            this.grbEdicionCasoClinico.Size = new System.Drawing.Size(331, 82);
            this.grbEdicionCasoClinico.TabIndex = 28;
            this.grbEdicionCasoClinico.TabStop = false;
            this.grbEdicionCasoClinico.Text = "Edición";
            // 
            // btnNuevoCasoClinico
            // 
            this.btnNuevoCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNuevoCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCasoClinico.Location = new System.Drawing.Point(17, 19);
            this.btnNuevoCasoClinico.Name = "btnNuevoCasoClinico";
            this.btnNuevoCasoClinico.Size = new System.Drawing.Size(90, 55);
            this.btnNuevoCasoClinico.TabIndex = 18;
            this.btnNuevoCasoClinico.Text = "Nuevo cliente";
            this.btnNuevoCasoClinico.UseVisualStyleBackColor = false;
            // 
            // btnModificarCasoClinico
            // 
            this.btnModificarCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnModificarCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCasoClinico.Location = new System.Drawing.Point(112, 19);
            this.btnModificarCasoClinico.Name = "btnModificarCasoClinico";
            this.btnModificarCasoClinico.Size = new System.Drawing.Size(90, 55);
            this.btnModificarCasoClinico.TabIndex = 16;
            this.btnModificarCasoClinico.Text = "Modificar datos";
            this.btnModificarCasoClinico.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCasoClinico
            // 
            this.btnEliminarCasoClinico.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEliminarCasoClinico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCasoClinico.Location = new System.Drawing.Point(208, 19);
            this.btnEliminarCasoClinico.Name = "btnEliminarCasoClinico";
            this.btnEliminarCasoClinico.Size = new System.Drawing.Size(90, 55);
            this.btnEliminarCasoClinico.TabIndex = 17;
            this.btnEliminarCasoClinico.Text = "Eliminar Cliente";
            this.btnEliminarCasoClinico.UseVisualStyleBackColor = false;
            // 
            // casosClinicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 721);
            this.Controls.Add(this.grbNavegacionCasoClinico);
            this.Controls.Add(this.grbEdicionCasoClinico);
            this.Controls.Add(this.grbDatosCasoClinico);
            this.Controls.Add(this.casosClinicosDataGridView);
            this.Name = "casosClinicos";
            this.Text = "casosClinicos";
            this.Load += new System.EventHandler(this.casosClinicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casosClinicosDataGridView)).EndInit();
            this.grbDatosCasoClinico.ResumeLayout(false);
            this.grbDatosCasoClinico.PerformLayout();
            this.grbNavegacionCasoClinico.ResumeLayout(false);
            this.grbNavegacionCasoClinico.PerformLayout();
            this.grbEdicionCasoClinico.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView casosClinicosDataGridView;
        private System.Windows.Forms.GroupBox grbDatosCasoClinico;
        private System.Windows.Forms.ListBox lboConsultasCasoClinico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblConsultasCasoClinico;
        private System.Windows.Forms.Label lblPacienteCasoClinico;
        private System.Windows.Forms.Label lblExamenesCasoClinico;
        private System.Windows.Forms.ComboBox cboPacienteCasoClinico;
        private System.Windows.Forms.ListBox lboExamenesCasoClinico;
        private System.Windows.Forms.ListBox lboServiciosCasoClinico;
        private System.Windows.Forms.ListBox lboTratamientosCasoClinico;
        private System.Windows.Forms.GroupBox grbNavegacionCasoClinico;
        private System.Windows.Forms.Button btnPrimeroCasoClinico;
        private System.Windows.Forms.Button btnAnteriorCasoClinico;
        private System.Windows.Forms.Button btnUltimoCasoClinico;
        private System.Windows.Forms.Button btnSiguienteCasoClinico;
        private System.Windows.Forms.Label lblPosicionCasoClinico;
        private System.Windows.Forms.GroupBox grbEdicionCasoClinico;
        private System.Windows.Forms.Button btnNuevoCasoClinico;
        private System.Windows.Forms.Button btnModificarCasoClinico;
        private System.Windows.Forms.Button btnEliminarCasoClinico;
    }
}