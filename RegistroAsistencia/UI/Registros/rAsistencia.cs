﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAsistencia.BLL;
using RegistroAsistencia.Entidades;
using RegistroAsistencia.UI.Registros;

namespace RegistroAsistencia.UI.Registros
{
    public partial class rAsistencia : Form
    {
        public List<DetalleAsistencia> Detalle { get; set; }
        private int cantidad = 0;
        
        public rAsistencia()
        {
            InitializeComponent();
            this.Detalle = new List<DetalleAsistencia>();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LlenaComboBoxAsignatura();
            LlenaComboxEstudiante();
            
        }
        private void LlenaComboBoxAsignatura()
        {
            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();
            List<Asignatura> lista = new List<Asignatura>();
            lista = repositorio.GetList(p => true);

            AsignaturacomboBox.DataSource = lista;
            AsignaturacomboBox.ValueMember = "AsignaturaID";
            AsignaturacomboBox.DisplayMember = "Nombre";
        }

        private void LlenaComboxEstudiante()
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            List<Estudiante> lista = new List<Estudiante>();
            lista = repositorio.GetList(p => true);

            EstudiantecomboBox.DataSource = lista;
            EstudiantecomboBox.ValueMember = "EstudianteID";
            EstudiantecomboBox.DisplayMember = "Nombre";
        }

        private void AgregarAsignaturabutton_Click(object sender, EventArgs e)
        {
            rAsignatura asignatura = new rAsignatura();
            asignatura.ShowDialog();
            LlenaComboBoxAsignatura();
        }

        private void AgregarEstudiantebutton_Click(object sender, EventArgs e)
        {
            rEstudiante estudiante = new rEstudiante();
            estudiante.ShowDialog();
            LlenaComboxEstudiante();
        }

        private string GetNombreAsignatura(int ID)
        {
            string nombre = "";
            RepositorioBase<Asignatura> repositorio = new RepositorioBase<Asignatura>();
            nombre = repositorio.Buscar(ID).Nombre;
            return nombre;
        }


        private void LimpiarCampos()
        {
            MyerrorProvider.Clear();
            AsistenciaIDnumericUpDown.Value = 0;
            AsignaturacomboBox.Text = string.Empty;
            EstudiantecomboBox.Text = string.Empty;
            PresentecheckBox.Checked = false;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Text = string.Empty;
            cantidad = 0;
            this.Detalle = new List<DetalleAsistencia>();
            CargarGrid();
        }

        private void CargarDetalleConGrid()
        {
            this.Detalle = (List<DetalleAsistencia>)DetalledataGridView.DataSource;
        }

        private Asistencia LlenaClase()
        {
            Asistencia asistencia = new Asistencia();
            
            asistencia.AsistenciaID = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            asistencia.AsignaturaID = (int)AsignaturacomboBox.SelectedValue;
            asistencia.Fecha = FechadateTimePicker.Value;
            asistencia.Cantidad = Convert.ToInt32(DetalledataGridView.Rows.Count);
            CargarDetalleConGrid();
            asistencia.Presentes = this.Detalle;

            return asistencia;
        }

        private void LlenaCampos(Asistencia a)
        {
            AsistenciaIDnumericUpDown.Value = a.AsistenciaID;
            AsignaturacomboBox.Text = GetNombreAsignatura(a.AsignaturaID);
            FechadateTimePicker.Value = a.Fecha;
            CantidadtextBox.Text = Convert.ToString(a.Presentes.Count);
            cantidad = a.Presentes.Count;
            this.Detalle = a.Presentes;
            CargarGrid();
           
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (AsignaturacomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(AsignaturacomboBox, "Debe elegir una asignatura.");
                paso = false;
            }

            if (AsignaturacomboBox.Text == "")
            {
                MyerrorProvider.SetError(AsignaturacomboBox, "Debe elegir una asignatura.");
                paso = false;
            }

            if(this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(Agregarbutton, "Debe agregar al menos un estudiante.");
                Agregarbutton.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarAgregar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if(EstudiantecomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Debe elegir al menos un estudiante.");
                paso = false;
            }
            if (EstudiantecomboBox.Text == "")
            {
                MyerrorProvider.SetError(EstudiantecomboBox, "Debe elegir al menos un estudiante.");
                paso = false;
            }

            if (paso)
            {
                foreach (var item in this.Detalle)
                {
                    if(item.EstudianteID == (int)EstudiantecomboBox.SelectedValue)
                    {
                        MyerrorProvider.SetError(EstudiantecomboBox, "Ya el Estudiante existe en el detalle.");
                        return paso = false;
                    }

                }
            }

            return paso;
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
            DetalledataGridView.Columns["DetalleAsistenciaID"].Visible = false;
            DetalledataGridView.Columns["AsistenciaID"].Visible = false;
            
        }

        
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }
        
        private string GetNombreEstudiante()
        {
            string nombre = "";

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            nombre = repositorio.Buscar((int)EstudiantecomboBox.SelectedValue).Nombre;

            return nombre;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
           if (DetalledataGridView.DataSource != null)
            this.Detalle = (List<DetalleAsistencia>)DetalledataGridView.DataSource;
            if (!ValidarAgregar())
                return;
            this.Detalle.Add(
                new DetalleAsistencia(
                        DetalleAsistenciaID: 0,
                        AsistenciaID: Convert.ToInt32(AsistenciaIDnumericUpDown.Value),
                        EstudianteID: (int)EstudiantecomboBox.SelectedValue,
                        Nombres: GetNombreEstudiante(),
                        Presente: PresentecheckBox.Checked
                    )
             );
            cantidad++;
            CantidadtextBox.Text = Convert.ToString(cantidad);
            CargarGrid();
            MyerrorProvider.Clear();
            PresentecheckBox.Checked = false;
            EstudiantecomboBox.Text = string.Empty;
        }


        private bool Existe()
        {
            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();
            Asistencia asistencia = repositorio.Buscar((int)AsistenciaIDnumericUpDown.Value);
            return (asistencia != null);
        }

        private void Gurdarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            bool paso;
            Asistencia asistencia;
            RepositorioAsistencia repositorio = new RepositorioAsistencia();

            asistencia = LlenaClase();

            if(AsistenciaIDnumericUpDown.Value == 0)
                paso = repositorio.Guardar(asistencia);
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asistencia);
            }

            if (paso)
            {
                LimpiarCampos();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            Asistencia asistencia;
            RepositorioAsistencia repositorio = new RepositorioAsistencia();
            asistencia = repositorio.Buscar(ID);
            
            if (asistencia != null)
            {
                LimpiarCampos();
                LlenaCampos(asistencia);
            }
            else
            {
                MessageBox.Show("Asistencia no encontrada.");
            }  
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int ID = Convert.ToInt32(AsistenciaIDnumericUpDown.Value);
            bool paso;
            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                paso = repositorio.Eliminar(ID);
                if (paso)
                {
                    LimpiarCampos();
                    MessageBox.Show("Asistencia eliminada!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la asistencia", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool ValidarRemover()
        {
            bool paso = true;
            
            if (DetalledataGridView.SelectedRows == null)
            {
                MyerrorProvider.SetError(Removerbutton, "Debe seleccionar al menos una fila.");
                paso = false;
            }

            return paso;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            int filaDetalle = Convert.ToInt32(DetalledataGridView.CurrentRow.Cells[0].Value);

            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null && filaDetalle > 0)
            {
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                cantidad--;
                CantidadtextBox.Text = Convert.ToString(cantidad);
                CargarGrid();
            }
        }
    }
}
