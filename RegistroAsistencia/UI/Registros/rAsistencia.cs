using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAsistencia.UI.Registros;

namespace RegistroAsistencia.UI.Registros
{
    public partial class rAsistencia : Form
    {
        public rAsistencia()
        {
            InitializeComponent();
        }

        private void AsistenciaIDlabel_Click(object sender, EventArgs e)
        {

        }

        private void AgregarAsignaturabutton_Click(object sender, EventArgs e)
        {
            rAsignatura asignatura = new rAsignatura();
            asignatura.ShowDialog();
        }

        private void AgregarEstudiantebutton_Click(object sender, EventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.ShowDialog();
        }
    }
}
