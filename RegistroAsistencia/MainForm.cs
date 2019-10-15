using RegistroAsistencia.UI.Consultas;
using RegistroAsistencia.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencia asistencia = new rAsistencia();
            asistencia.MdiParent = this;
            asistencia.Show();
        }

        private void ConsultarAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsistencia asistencia = new cAsistencia();
            asistencia.MdiParent = this;
            asistencia.Show();
        }

        private void ConsultarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEstudiante estudiante = new cEstudiante();
            estudiante.MdiParent = this;
            estudiante.Show();
        }
    }
}
