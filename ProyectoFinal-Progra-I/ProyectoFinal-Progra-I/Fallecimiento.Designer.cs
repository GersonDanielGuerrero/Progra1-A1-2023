
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
            this.components = new System.ComponentModel.Container();
            this.btnCancelarFallecimiento = new System.Windows.Forms.Button();
            this.btnAceptarFallecimiento = new System.Windows.Forms.Button();
            this.lblFallecimientoPaciente = new System.Windows.Forms.Label();
            this.txtCausaFallecimiento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFallecimiento = new System.Windows.Forms.DateTimePicker();
            this.bd_veterinaria_huellitasDataSet = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSet();
            this.fallecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fallecimientosTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.fallecimientosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ProyectoFinal_Progra_I.bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallecimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarFallecimiento
            // 
            this.btnCancelarFallecimiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCancelarFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFallecimiento.Location = new System.Drawing.Point(385, 227);
            this.btnCancelarFallecimiento.Name = "btnCancelarFallecimiento";
            this.btnCancelarFallecimiento.Size = new System.Drawing.Size(90, 33);
            this.btnCancelarFallecimiento.TabIndex = 27;
            this.btnCancelarFallecimiento.Text = "Cancelar";
            this.btnCancelarFallecimiento.UseVisualStyleBackColor = false;
            this.btnCancelarFallecimiento.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarFallecimiento
            // 
            this.btnAceptarFallecimiento.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAceptarFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarFallecimiento.Location = new System.Drawing.Point(212, 227);
            this.btnAceptarFallecimiento.Name = "btnAceptarFallecimiento";
            this.btnAceptarFallecimiento.Size = new System.Drawing.Size(90, 33);
            this.btnAceptarFallecimiento.TabIndex = 26;
            this.btnAceptarFallecimiento.Text = "Aceptar";
            this.btnAceptarFallecimiento.UseVisualStyleBackColor = false;
            this.btnAceptarFallecimiento.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFallecimientoPaciente
            // 
            this.lblFallecimientoPaciente.AutoSize = true;
            this.lblFallecimientoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallecimientoPaciente.Location = new System.Drawing.Point(199, 31);
            this.lblFallecimientoPaciente.Name = "lblFallecimientoPaciente";
            this.lblFallecimientoPaciente.Size = new System.Drawing.Size(145, 20);
            this.lblFallecimientoPaciente.TabIndex = 25;
            this.lblFallecimientoPaciente.Text = "Fallecimiento de ";
            // 
            // txtCausaFallecimiento
            // 
            this.txtCausaFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCausaFallecimiento.Location = new System.Drawing.Point(212, 144);
            this.txtCausaFallecimiento.Multiline = true;
            this.txtCausaFallecimiento.Name = "txtCausaFallecimiento";
            this.txtCausaFallecimiento.Size = new System.Drawing.Size(430, 60);
            this.txtCausaFallecimiento.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 147);
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
            this.dtpFechaFallecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFallecimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFallecimiento.Location = new System.Drawing.Point(212, 83);
            this.dtpFechaFallecimiento.Name = "dtpFechaFallecimiento";
            this.dtpFechaFallecimiento.Size = new System.Drawing.Size(430, 26);
            this.dtpFechaFallecimiento.TabIndex = 28;
            this.dtpFechaFallecimiento.Value = new System.DateTime(2023, 11, 20, 19, 5, 53, 0);
            // 
            // bd_veterinaria_huellitasDataSet
            // 
            this.bd_veterinaria_huellitasDataSet.DataSetName = "bd_veterinaria_huellitasDataSet";
            this.bd_veterinaria_huellitasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fallecimientosBindingSource
            // 
            this.fallecimientosBindingSource.DataMember = "fallecimientos";
            this.fallecimientosBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // fallecimientosTableAdapter
            // 
            this.fallecimientosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "nombre", true));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Paciente";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.bd_veterinaria_huellitasDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // Fallecimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaFallecimiento);
            this.Controls.Add(this.btnCancelarFallecimiento);
            this.Controls.Add(this.btnAceptarFallecimiento);
            this.Controls.Add(this.lblFallecimientoPaciente);
            this.Controls.Add(this.txtCausaFallecimiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Fallecimiento";
            this.Text = "Fallecimiento";
            this.Load += new System.EventHandler(this.Fallecimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_veterinaria_huellitasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallecimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarFallecimiento;
        private System.Windows.Forms.Button btnAceptarFallecimiento;
        private System.Windows.Forms.Label lblFallecimientoPaciente;
        private System.Windows.Forms.TextBox txtCausaFallecimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaFallecimiento;
        private bd_veterinaria_huellitasDataSet bd_veterinaria_huellitasDataSet;
        private System.Windows.Forms.BindingSource fallecimientosBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.fallecimientosTableAdapter fallecimientosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private bd_veterinaria_huellitasDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
    }
}