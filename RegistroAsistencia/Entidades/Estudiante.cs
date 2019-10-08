using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class Estudiante
    {
        private int estudianteID;
        private string nombre;

        public Estudiante()
        {

        }

        [Key]
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
    }
}
