using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAsistencia.Entidades;

namespace RegistroAsistencia.DAL
{
    public class Contexto: DbContext
    {
       
        public DbSet<Asistencia> Asistencia { get; set; } 
        public DbSet<Estudiante> Estudiante { get; set; } 
        public DbSet<Asignatura> Asignatura { get; set; }


        public Contexto() : base("ConStr")
        {

        }
    }

}
