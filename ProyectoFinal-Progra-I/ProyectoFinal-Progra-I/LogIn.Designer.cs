
namespace ProyectoFinal_Progra_I
{
    partial class LogIn
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
            this.txtClaveLogIn = new System.Windows.Forms.TextBox();
            this.txtUsuarioLogIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresarLogIn = new System.Windows.Forms.Button();
            this.btnSalirLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClaveLogIn
            // 
            this.txtClaveLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveLogIn.Location = new System.Drawing.Point(167, 201);
            this.txtClaveLogIn.Name = "txtClaveLogIn";
            this.txtClaveLogIn.Size = new System.Drawing.Size(430, 26);
            this.txtClaveLogIn.TabIndex = 15;
            // 
            // txtUsuarioLogIn
            // 
            this.txtUsuarioLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioLogIn.Location = new System.Drawing.Point(167, 121);
            this.txtUsuarioLogIn.Name = "txtUsuarioLogIn";
            this.txtUsuarioLogIn.Size = new System.Drawing.Size(430, 26);
            this.txtUsuarioLogIn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ingreso al sistema";
            // 
            // btnIngresarLogIn
            // 
            this.btnIngresarLogIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnIngresarLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogIn.Location = new System.Drawing.Point(241, 260);
            this.btnIngresarLogIn.Name = "btnIngresarLogIn";
            this.btnIngresarLogIn.Size = new System.Drawing.Size(90, 55);
            this.btnIngresarLogIn.TabIndex = 19;
            this.btnIngresarLogIn.Text = "Ingresar";
            this.btnIngresarLogIn.UseVisualStyleBackColor = false;
            this.btnIngresarLogIn.Click += new System.EventHandler(this.btnIngresarLogIn_Click);
            // 
            // btnSalirLogIn
            // 
            this.btnSalirLogIn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSalirLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLogIn.Location = new System.Drawing.Point(412, 260);
            this.btnSalirLogIn.Name = "btnSalirLogIn";
            this.btnSalirLogIn.Size = new System.Drawing.Size(90, 55);
            this.btnSalirLogIn.TabIndex = 20;
            this.btnSalirLogIn.Text = "Salir";
            this.btnSalirLogIn.UseVisualStyleBackColor = false;
            this.btnSalirLogIn.Click += new System.EventHandler(this.btnSalirLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 369);
            this.Controls.Add(this.btnSalirLogIn);
            this.Controls.Add(this.btnIngresarLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveLogIn);
            this.Controls.Add(this.txtUsuarioLogIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClaveLogIn;
        private System.Windows.Forms.TextBox txtUsuarioLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngresarLogIn;
        private System.Windows.Forms.Button btnSalirLogIn;
    }
}