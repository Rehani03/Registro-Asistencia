using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class DetalleAsistencia
    {
        private int detalleAsistenciaID;
        private int asistenciaID;
        private int estudianteID;
        private string nombres;
        private bool presente;

        [Key]
        public int DetalleAsistenciaID { get; set; }
        public int AsistenciaID { get; set; }
        public int EstudianteID { get; set; }
        public string Nombres { get; set; }
        public bool Presente { get; set; }
       

        public DetalleAsistencia()
        {
            DetalleAsistenciaID = 0;
            AsistenciaID = 0;
            EstudianteID = 0;
            Nombres = string.Empty;
            Presente = false;
        }

        public DetalleAsistencia(int DetalleAsistenciaID, int AsistenciaID, int EstudianteID, string Nombres, bool Presente)
        {
            this.DetalleAsistenciaID = DetalleAsistenciaID;
            this.AsistenciaID = AsistenciaID;
            this.EstudianteID = EstudianteID;
            this.Nombres = Nombres;
            this.Presente = Presente;
        }

    }
}
