using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class Asistencia
    {
        private int asistenciaID;
        private DateTime fecha;
        private int asignaturaID;
        private int cantidad;
       

        [Key]
        public int AsistenciaID { get; set; }
        public DateTime Fecha { get; set; }
        public int AsignaturaID { get; set; }
        public int Cantidad { get; set; }
        public virtual List<DetalleAsistencia> Presentes { get; set; }


        public Asistencia()
        {
            AsistenciaID = 0;
            Fecha = DateTime.Now;
            AsignaturaID = 0;
            Cantidad = 0;
            Presentes = new List<DetalleAsistencia>();

        }
    }
}
