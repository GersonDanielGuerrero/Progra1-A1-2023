
namespace ProyectoFinal
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
            this.btnVerClientes = new System.Windows.Forms.Button();
            this.btnVerPacientes = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerClientes
            // 
            this.btnVerClientes.Location = new System.Drawing.Point(12, 24);
            this.btnVerClientes.Name = "btnVerClientes";
            this.btnVerClientes.Size = new System.Drawing.Size(96, 66);
            this.btnVerClientes.TabIndex = 0;
            this.btnVerClientes.Text = "Ver clientes";
            this.btnVerClientes.UseVisualStyleBackColor = true;
            this.btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // btnVerPacientes
            // 
            this.btnVerPacientes.Location = new System.Drawing.Point(12, 96);
            this.btnVerPacientes.Name = "btnVerPacientes";
            this.btnVerPacientes.Size = new System.Drawing.Size(96, 66);
            this.btnVerPacientes.TabIndex = 1;
            this.btnVerPacientes.Text = "Ver pacientes";
            this.btnVerPacientes.UseVisualStyleBackColor = true;
            this.btnVerPacientes.Click += new System.EventHandler(this.btnVerPacientes_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Location = new System.Drawing.Point(12, 168);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(96, 66);
            this.btnVerProductos.TabIndex = 2;
            this.btnVerProductos.Text = "Ver productos";
            this.btnVerProductos.UseVisualStyleBackColor = true;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnVerProductos);
            this.Controls.Add(this.btnVerPacientes);
            this.Controls.Add(this.btnVerClientes);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Button btnVerPacientes;
        private System.Windows.Forms.Button btnVerProductos;
    }
}

