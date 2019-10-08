using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class Asignatura
    {
        private int asignaturaID;
        private string nombre;

        public Asignatura()
        {

        }

        [Key]
        public int AsignaturaID { get; set; }
        public string Nombre { get; set; }
    }
}
