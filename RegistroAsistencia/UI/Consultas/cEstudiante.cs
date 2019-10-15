using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAsistencia.Entidades;
using RegistroAsistencia.BLL;

namespace RegistroAsistencia.UI.Consultas
{
    public partial class cEstudiante : Form
    {
        public cEstudiante()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            List<Estudiante> lista = new List<Estudiante>();

            if(CriteriotextBox.Text.Trim().Length> 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0:
                        lista = repositorio.GetList(p => true);
                        break;
                    case 1:
                        int ID = GetCriterio();
                        lista = repositorio.GetList(p => p.EstudianteID == ID);
                        break;
                    case 2:
                        lista = repositorio.GetList(p => p.Nombre == CriteriotextBox.Text);
                        break;
                    case 3:
                        int cantidadPresente = GetCriterio();
                        lista = repositorio.GetList(p => p.Presente == cantidadPresente);
                        break;
                    case 4:
                        int cantidadAusente = GetCriterio();
                        lista = repositorio.GetList(p => p.Ausente == cantidadAusente);
                        break;
                    default:
                        MessageBox.Show("No Existe esa opción en el Filtro.");
                        break;
                }

               
            }
            else
            {
                lista = repositorio.GetList(p => true);
            }

            EstudiantedataGridView.DataSource = null;
            this.EstudiantedataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EstudiantedataGridView.DataSource = lista;
        }

        private int GetCriterio()
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(CriteriotextBox.Text);
                return ID;
            }
            catch (Exception)
            {
                MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return ID;
        }

    }
}
