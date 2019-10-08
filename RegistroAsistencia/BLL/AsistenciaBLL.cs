using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroAsistencia.Entidades;
using RegistroAsistencia.DAL;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RegistroAsistencia.BLL
{
    public class AsistenciaBLL
    {
        public static bool Guardar(Asistencia asistencia)
        {
            bool flag = false;
            Contexto db = new Contexto();


            try
            {
                if (db.Asistencia.Add(asistencia) != null)
                    flag = db.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return flag;
        }

        public static bool Modificar(Asistencia asistencia)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = db.Asistencia.Find(asistencia.AsistenciaID);
                foreach (var item in Anterior.Presentes)
                {
                    if (!asistencia.Presentes.Exists(d => d.EstudianteID == item.EstudianteID))
                        db.Entry(item).State = EntityState.Deleted;
                }

                db.Entry(asistencia).State = EntityState.Modified;
                flag = (db.SaveChanges() > 0);


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return flag;
        }

        //este metodo elimina el estudiante de la base de datos
        public static bool Eliminar(int id)
        {
            bool flag = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Asistencia.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                flag = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return flag;
        }

        //este metodo busca el estudiante de la base de datos
        public static Asistencia Buscar(int id)
        {
            Asistencia asistencia = new Asistencia();
            Contexto db = new Contexto();

            try
            {
                asistencia = db.Asistencia.Find(id);
                asistencia.Presentes.Count();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }

            return asistencia;
        }

        public static List<Asistencia> GetList(Expression<Func<Asistencia, bool>> asistencia)
        {
            List<Asistencia> Lista = new List<Asistencia>();

            Contexto db = new Contexto();
            try
            {
                Lista = db.Asistencia.Where(asistencia).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Lista;
        }



    }
}
