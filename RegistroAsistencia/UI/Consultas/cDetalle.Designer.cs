namespace RegistroAsistencia.UI.Consultas
{
    partial class cDetalle
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
            this.DetalleAsistenciadataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsistenciadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DetalleAsistenciadataGridView
            // 
            this.DetalleAsistenciadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleAsistenciadataGridView.Location = new System.Drawing.Point(12, 12);
            this.DetalleAsistenciadataGridView.Name = "DetalleAsistenciadataGridView";
            this.DetalleAsistenciadataGridView.ReadOnly = true;
            this.DetalleAsistenciadataGridView.Size = new System.Drawing.Size(624, 265);
            this.DetalleAsistenciadataGridView.TabIndex = 0;
            // 
            // cDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 289);
            this.Controls.Add(this.DetalleAsistenciadataGridView);
            this.MaximizeBox = false;
            this.Name = "cDetalle";
            this.Text = "Detalle de Asistencia";
            ((System.ComponentModel.ISupportInitialize)(this.DetalleAsistenciadataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DetalleAsistenciadataGridView;
    }
}