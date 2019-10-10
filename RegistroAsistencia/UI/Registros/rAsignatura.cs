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
    public partial class rAsignatura : Form
    {
        RepositorioBase<Asignatura> repositorio;
        public rAsignatura()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            AsignaturatextBox.Text = string.Empty;

        }

        private bool validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(AsignaturatextBox.Text))
            {
                MyerrorProvider.SetError(AsignaturatextBox, "La asignatura no puede estar vacía.");
                paso = false;
            }

            return paso;
        }

        private Asignatura LlenaClase()
        {
            Asignatura asignatura = new Asignatura();
            asignatura.AsignaturaID = Convert.ToInt32(IDnumericUpDown.Value);
            asignatura.Nombre = AsignaturatextBox.Text;

            return asignatura;
        }

        private void LlenaCampos(Asignatura a)
        {
            IDnumericUpDown.Value = a.AsignaturaID;
            AsignaturatextBox.Text = a.Nombre;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Existe()
        {
            repositorio = new RepositorioBase<Asignatura>();
            Asignatura asignatura = repositorio.Buscar((int)IDnumericUpDown.Value);

            return (asignatura != null);
        }

        private void Añadirbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Asignatura>();
            Asignatura asignatura;
            bool paso;

            if (!validar())
                return;

            asignatura = LlenaClase();

            if(IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(asignatura);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modifiar porque no existe", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asignatura);

            }

            if (paso)
            {
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se puede guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            repositorio = new RepositorioBase<Asignatura>();
            Asignatura asignatura;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);

            asignatura = repositorio.Buscar(ID);

            if (asignatura != null)
            {
                Limpiar();
                LlenaCampos(asignatura);
            }
            else
            {
                MessageBox.Show("Asignatura no encontrada.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            repositorio = new RepositorioBase<Asignatura>();

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
