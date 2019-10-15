using RegistroAsistencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAsistencia.BLL;

namespace RegistroAsistencia.UI.Consultas
{
    public partial class cAsistencia : Form
    {
       
        public cAsistencia()
        {
            InitializeComponent();
           
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asistencia>();

            if(CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //Todo
                        listado = AsistenciaBLL.GetList(p => true);
                        break;
                    case 1: //ID
                        int ID = GetCriterio();
                        listado = AsistenciaBLL.GetList(p => p.AsistenciaID == ID);
                        break;
                    case 2: //ID Asignatura
                        int IDAsignatura = GetCriterio();
                        listado = AsistenciaBLL.GetList(p => p.AsignaturaID == IDAsignatura);
                        break;
                    case 3: //Cantidad
                        int Cantidad = GetCriterio();
                        listado = AsistenciaBLL.GetList(p => p.AsignaturaID == Cantidad);
                        break;
                    default:
                        MessageBox.Show("No existe esa opción en el filtro.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                //Fecha
                listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date && p.Fecha <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = AsistenciaBLL.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultadataGridView.DataSource = listado;

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

        private void ConsultadataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(ConsultadataGridView.CurrentRow.Cells[0].Value);
            List<DetalleAsistencia> dt = new List<DetalleAsistencia>();
            Asistencia asistencia = AsistenciaBLL.Buscar(ID);
            cDetalle detalle = new cDetalle();
           
            dt = asistencia.Presentes;
            detalle.DetalleAsistenciadataGridView.DataSource = null;
            detalle.DetalleAsistenciadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            detalle.DetalleAsistenciadataGridView.DataSource = dt;
            detalle.DetalleAsistenciadataGridView.Columns["DetalleAsistenciaID"].Visible = false;
            detalle.DetalleAsistenciadataGridView.Columns["AsistenciaID"].Visible = false;
            detalle.ShowDialog();


        }
    }
}
