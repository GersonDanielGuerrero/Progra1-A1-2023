
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
            this.listaDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listaDePacientesToolStripMenuItem_Click);
            // 
            // tratamientosToolStripMenuItem
            // 
            this.tratamientosToolStripMenuItem.Name = "tratamientosToolStripMenuItem";
            this.tratamientosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.tratamientosToolStripMenuItem.Text = "Tratamientos";
            this.tratamientosToolStripMenuItem.Click += new System.EventHandler(this.tratamientosToolStripMenuItem_Click);
            // 
            // MenuPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
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
    }
}