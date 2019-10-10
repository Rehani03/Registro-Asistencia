namespace RegistroAsistencia.UI.Registros
{
    partial class rAsignatura
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
            this.IDlabel = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Asignaturalabel = new System.Windows.Forms.Label();
            this.AsignaturatextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Añadirbutton = new System.Windows.Forms.Button();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Location = new System.Drawing.Point(25, 26);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(18, 13);
            this.IDlabel.TabIndex = 0;
            this.IDlabel.Text = "ID";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(104, 19);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(125, 20);
            this.IDnumericUpDown.TabIndex = 1;
            // 
            // Asignaturalabel
            // 
            this.Asignaturalabel.AutoSize = true;
            this.Asignaturalabel.Location = new System.Drawing.Point(25, 65);
            this.Asignaturalabel.Name = "Asignaturalabel";
            this.Asignaturalabel.Size = new System.Drawing.Size(57, 13);
            this.Asignaturalabel.TabIndex = 0;
            this.Asignaturalabel.Text = "Asignatura";
            // 
            // AsignaturatextBox
            // 
            this.AsignaturatextBox.Location = new System.Drawing.Point(104, 57);
            this.AsignaturatextBox.Name = "AsignaturatextBox";
            this.AsignaturatextBox.Size = new System.Drawing.Size(259, 20);
            this.AsignaturatextBox.TabIndex = 2;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::RegistroAsistencia.Properties.Resources.agregar38px_opt;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(28, 97);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(88, 49);
            this.Nuevobutton.TabIndex = 3;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Añadirbutton
            // 
            this.Añadirbutton.Image = global::RegistroAsistencia.Properties.Resources.anadirOriginal38px_opt;
            this.Añadirbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Añadirbutton.Location = new System.Drawing.Point(150, 97);
            this.Añadirbutton.Name = "Añadirbutton";
            this.Añadirbutton.Size = new System.Drawing.Size(88, 49);
            this.Añadirbutton.TabIndex = 4;
            this.Añadirbutton.Text = "Añadir";
            this.Añadirbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Añadirbutton.UseVisualStyleBackColor = true;
            this.Añadirbutton.Click += new System.EventHandler(this.Añadirbutton_Click);
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::RegistroAsistencia.Properties.Resources.buscar20px;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(278, 16);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(81, 23);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::RegistroAsistencia.Properties.Resources.eliminar44px;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Eliminarbutton.Location = new System.Drawing.Point(270, 97);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(93, 49);
            this.Eliminarbutton.TabIndex = 6;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // rAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 161);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Añadirbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.AsignaturatextBox);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Asignaturalabel);
            this.Controls.Add(this.IDlabel);
            this.MaximizeBox = false;
            this.Name = "rAsignatura";
            this.Text = "Añadir Asignatura";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.Label Asignaturalabel;
        private System.Windows.Forms.TextBox AsignaturatextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Añadirbutton;
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}