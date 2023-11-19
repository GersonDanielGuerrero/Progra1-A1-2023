
namespace ProyectoFinal_Progra_I
{
    partial class MenuPacientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPacienteMenu = new System.Windows.Forms.Label();
            this.btnAnteriorPacienteMenu = new System.Windows.Forms.Button();
            this.btnSiguientePacienteMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDePacientesToolStripMenuItem,
            this.tratamientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDePacientesToolStripMenuItem
            // 
            this.listaDePacientesToolStripMenuItem.Name = "listaDePacientesToolStripMenuItem";
            this.listaDePacientesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.listaDePacientesToolStripMenuItem.Text = "Lista de pacientes";
            // 
            // tratamientosToolStripMenuItem
            // 
            this.tratamientosToolStripMenuItem.Name = "tratamientosToolStripMenuItem";
            this.tratamientosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.tratamientosToolStripMenuItem.Text = "Tratamientos";
            // 
            // lblPacienteMenu
            // 
            this.lblPacienteMenu.AutoSize = true;
            this.lblPacienteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacienteMenu.Location = new System.Drawing.Point(606, 29);
            this.lblPacienteMenu.Name = "lblPacienteMenu";
            this.lblPacienteMenu.Size = new System.Drawing.Size(79, 20);
            this.lblPacienteMenu.TabIndex = 26;
            this.lblPacienteMenu.Text = "Paciente";
            // 
            // btnAnteriorPacienteMenu
            // 
            this.btnAnteriorPacienteMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAnteriorPacienteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnteriorPacienteMenu.Location = new System.Drawing.Point(450, 24);
            this.btnAnteriorPacienteMenu.Name = "btnAnteriorPacienteMenu";
            this.btnAnteriorPacienteMenu.Size = new System.Drawing.Size(32, 30);
            this.btnAnteriorPacienteMenu.TabIndex = 40;
            this.btnAnteriorPacienteMenu.Text = "<";
            this.btnAnteriorPacienteMenu.UseVisualStyleBackColor = false;
            // 
            // btnSiguientePacienteMenu
            // 
            this.btnSiguientePacienteMenu.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSiguientePacienteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguientePacienteMenu.Location = new System.Drawing.Point(810, 24);
            this.btnSiguientePacienteMenu.Name = "btnSiguientePacienteMenu";
            this.btnSiguientePacienteMenu.Size = new System.Drawing.Size(32, 30);
            this.btnSiguientePacienteMenu.TabIndex = 41;
            this.btnSiguientePacienteMenu.Text = ">";
            this.btnSiguientePacienteMenu.UseVisualStyleBackColor = false;
            // 
            // MenuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.btnSiguientePacienteMenu);
            this.Controls.Add(this.btnAnteriorPacienteMenu);
            this.Controls.Add(this.lblPacienteMenu);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPacientes";
            this.Text = "MenuPacientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamientosToolStripMenuItem;
        private System.Windows.Forms.Label lblPacienteMenu;
        private System.Windows.Forms.Button btnAnteriorPacienteMenu;
        private System.Windows.Forms.Button btnSiguientePacienteMenu;
    }
}