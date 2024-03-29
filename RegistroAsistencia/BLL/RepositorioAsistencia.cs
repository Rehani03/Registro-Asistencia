﻿using System;
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
    public class RepositorioAsistencia : RepositorioBase<Asistencia>
    {
        public override bool Guardar(Asistencia asistencia)
        {
            bool flag = false;
            Contexto db = new Contexto();
           
            try
            {

                foreach (var item in asistencia.Presentes)
                {
                    var estudiante = db.Estudiante.Find(item.EstudianteID);
                    if(item.Presente)
                      estudiante.Presente += 1;
                    else
                        estudiante.Ausente += 1;
                }

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

        public override bool Modificar(Asistencia asistencia)
        {
            bool flag = false;
            Contexto db = new Contexto();
            RepositorioBase<Asistencia> repositorio = new RepositorioBase<Asistencia>();

            try
            {
                //aqui elimino los estudiantes que tal vez removieron del detalle y lo disminuyo en la tabla estudiante
                var Anterior = repositorio.Buscar(asistencia.AsistenciaID);
                foreach (var item in Anterior.Presentes)
                {
                    var estudiante = db.Estudiante.Find(item.EstudianteID);
                    if (!asistencia.Presentes.Exists(d => d.DetalleAsistenciaID == item.DetalleAsistenciaID))
                    {
                        if (item.Presente)
                            estudiante.Presente -= 1;
                        else
                            estudiante.Ausente -= 1;

                        db.Entry(item).State = EntityState.Deleted;
                    }
                       
                }

                //aqui verifico si un estudiante le cambiaron de presente a ausente o viceversa
                foreach (var item in Anterior.Presentes)
                {
                    var estudiante = db.Estudiante.Find(item.EstudianteID);
                    foreach (var listaDetalle in asistencia.Presentes)
                    {
                        if(item.EstudianteID == listaDetalle.EstudianteID)
                        {
                            if(item.Presente == true && listaDetalle.Presente == false)
                            {
                                estudiante.Presente -= 1;
                                estudiante.Ausente += 1;
                                db.Entry(listaDetalle).State = EntityState.Modified;
                            }
                            if (item.Presente == false && listaDetalle.Presente == true)
                            {
                                estudiante.Presente += 1;
                                estudiante.Ausente -= 1;
                                db.Entry(listaDetalle).State = EntityState.Modified;
                            }

                        }
                    }
                }

                //agregar nuevos detalles o modificarlo
                foreach (var item in asistencia.Presentes)
                {
                    if (item.DetalleAsistenciaID == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                        db.Entry(item).State = EntityState.Modified;
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
        /*public static bool Eliminar(int id)
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
        }*/

        //este metodo busca el estudiante de la base de datos
        public override Asistencia Buscar(int id)
        {
            Asistencia asistencia = new Asistencia();
            Contexto db = new Contexto();

            try
            {
                asistencia = db.Asistencia.Find(id);
                if (asistencia != null)
                {
                    asistencia.Presentes.Count();
                }
                else
                {
                    db.Dispose();
                    return asistencia;
                }
                    
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

       /* public static List<Asistencia> GetList(Expression<Func<Asistencia, bool>> asistencia)
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
        }*/



    }
}
