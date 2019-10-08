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
        private int estudianteID;
        private string nombres;
        private int presente;

        [Key]
        public int EstudianteID { get; set; }
        public string Nombres { get; set; }
        public int Presente { get; set; }

        public DetalleAsistencia()
        {
            EstudianteID = 0;
            Nombres = string.Empty;
            Presente = 0;
        }

    }
}
