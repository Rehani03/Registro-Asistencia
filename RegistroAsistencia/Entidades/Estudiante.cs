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
  
        public Estudiante()
        {

        }

        [Key]
        public int EstudianteID { get; set; }
        public string Nombre { get; set; }
        public int Presente { get; set; }
        public int Ausente { get; set; }
    }
}
