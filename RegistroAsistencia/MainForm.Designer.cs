﻿namespace RegistroAsistencia
{
    partial class MainForm
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
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(608, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAsistenciaToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarAsistenciaToolStripMenuItem
            // 
            this.registrarAsistenciaToolStripMenuItem.Name = "registrarAsistenciaToolStripMenuItem";
            this.registrarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarAsistenciaToolStripMenuItem.Text = "Registrar Asistencia";
            this.registrarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.RegistrarAsistenciaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAsistenciaToolStripMenuItem,
            this.consultarEstudianteToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarAsistenciaToolStripMenuItem
            // 
            this.consultarAsistenciaToolStripMenuItem.Name = "consultarAsistenciaToolStripMenuItem";
            this.consultarAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarAsistenciaToolStripMenuItem.Text = "Consultar Asistencia";
            this.consultarAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.ConsultarAsistenciaToolStripMenuItem_Click);
            // 
            // consultarEstudianteToolStripMenuItem
            // 
            this.consultarEstudianteToolStripMenuItem.Name = "consultarEstudianteToolStripMenuItem";
            this.consultarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarEstudianteToolStripMenuItem.Text = "Consultar Estudiante";
            this.consultarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEstudianteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(608, 323);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstudianteToolStripMenuItem;
    }
}

