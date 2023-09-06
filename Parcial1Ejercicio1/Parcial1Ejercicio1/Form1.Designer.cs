
namespace Parcial1Ejercicio1
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
            this.lblMontoImpuesto = new System.Windows.Forms.Label();
            this.btnCalcularImpuesto = new System.Windows.Forms.Button();
            this.lblRespuestaImpuesto = new System.Windows.Forms.Label();
            this.txtMontoImpuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMontoImpuesto
            // 
            this.lblMontoImpuesto.AutoSize = true;
            this.lblMontoImpuesto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoImpuesto.Location = new System.Drawing.Point(313, 144);
            this.lblMontoImpuesto.Name = "lblMontoImpuesto";
            this.lblMontoImpuesto.Size = new System.Drawing.Size(76, 22);
            this.lblMontoImpuesto.TabIndex = 0;
            this.lblMontoImpuesto.Text = "Monto:";
            // 
            // btnCalcularImpuesto
            // 
            this.btnCalcularImpuesto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularImpuesto.Location = new System.Drawing.Point(340, 191);
            this.btnCalcularImpuesto.Name = "btnCalcularImpuesto";
            this.btnCalcularImpuesto.Size = new System.Drawing.Size(119, 58);
            this.btnCalcularImpuesto.TabIndex = 1;
            this.btnCalcularImpuesto.Text = "Calcular Impuesto";
            this.btnCalcularImpuesto.UseVisualStyleBackColor = true;
            this.btnCalcularImpuesto.Click += new System.EventHandler(this.btnCalcularImpuesto_Click);
            // 
            // lblRespuestaImpuesto
            // 
            this.lblRespuestaImpuesto.AutoSize = true;
            this.lblRespuestaImpuesto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaImpuesto.Location = new System.Drawing.Point(336, 294);
            this.lblRespuestaImpuesto.Name = "lblRespuestaImpuesto";
            this.lblRespuestaImpuesto.Size = new System.Drawing.Size(108, 22);
            this.lblRespuestaImpuesto.TabIndex = 2;
            this.lblRespuestaImpuesto.Text = "Respuesta";
            this.lblRespuestaImpuesto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMontoImpuesto
            // 
            this.txtMontoImpuesto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoImpuesto.Location = new System.Drawing.Point(395, 141);
            this.txtMontoImpuesto.Name = "txtMontoImpuesto";
            this.txtMontoImpuesto.Size = new System.Drawing.Size(100, 29);
            this.txtMontoImpuesto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(631, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMPUESTO A LAS ACTIVIDADES ECONOMICAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMontoImpuesto);
            this.Controls.Add(this.lblRespuestaImpuesto);
            this.Controls.Add(this.btnCalcularImpuesto);
            this.Controls.Add(this.lblMontoImpuesto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMontoImpuesto;
        private System.Windows.Forms.Button btnCalcularImpuesto;
        private System.Windows.Forms.Label lblRespuestaImpuesto;
        private System.Windows.Forms.TextBox txtMontoImpuesto;
        private System.Windows.Forms.Label label2;
    }
}

