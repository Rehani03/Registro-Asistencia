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

namespace RegistroAsistencia.UI.Registros
{
    public partial class rEstudiante : Form
    {
       
        public rEstudiante()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            NombremaskedTextBox.Text = string.Empty;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombremaskedTextBox.Text))
            {
                MyerrorProvider.SetError(NombremaskedTextBox, "El nombre no puede estar vacío.");
                paso = false;
            }

            return paso;
        }

        private Estudiante LlenaClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.EstudianteID = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Nombre = NombremaskedTextBox.Text;

            return estudiante;
        }

        private void LlenaCampos(Estudiante e)
        {
            IDnumericUpDown.Value = e.EstudianteID;
            NombremaskedTextBox.Text = e.Nombre;
        }

        private bool Existe()
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Estudiante e = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (e != null);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Estudiante estudiante;

            if (!Validar())
                return;

           estudiante = LlenaClase();

            if(IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(estudiante);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modifiar porque no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(estudiante);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Estudiante estudiante;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante = repositorio.Buscar(ID);

            if (estudiante != null)
            {
                Limpiar();
                LlenaCampos(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la base de datos.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                paso = repositorio.Eliminar(ID);

                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Elimando con exito.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al tratar de eliminar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
