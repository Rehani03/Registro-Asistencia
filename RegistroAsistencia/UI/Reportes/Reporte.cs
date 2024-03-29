﻿using RegistroAsistencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia.UI.Reportes
{
    public partial class Reporte : Form
    {
        
        public Reporte(List<Estudiante> listado)
        {
            InitializeComponent();
            ReporteEstudiante estudiante = new ReporteEstudiante();
            estudiante.SetDataSource(listado);
            ReportViewer.ReportSource = estudiante;
            ReportViewer.Refresh();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
           
        }
    }
}
