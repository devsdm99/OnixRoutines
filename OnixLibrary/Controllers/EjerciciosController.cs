using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixLibrary.BBDD
{
    public  class EjerciciosController
    {

        public  List<Ejercicio> GetAllExercices()
        {

            List<Ejercicio> ejerciciosList = new List<Ejercicio>();


            using (var grupos = new OnixDBEntities())
            {
                var ejercicios = (from b in grupos.Ejercicios
                                  select new { b.IdEjercicio, b.idGrupoMuscular, b.Nombre }).ToList();

                if (ejercicios.Count > 0)
                {
                    foreach (var x in ejercicios)
                    {
                        Ejercicio ex = new Ejercicio()
                        {
                            IdEjercicio = x.IdEjercicio,
                            IdGrupoMuscular =  x.idGrupoMuscular,
                            Nombre = x.Nombre
                        };
                        ejerciciosList.Add(ex);
                    }
                }
            }
            return ejerciciosList;

        }

        public  List<Ejercicio> GetExercicesByGroupId(int id)
        {
            List<Ejercicio> ejerciciosList = new List<Ejercicio>();
            using (var ejercicio = new OnixDBEntities())
            {
                var ejercicios = (from b in ejercicio.Ejercicios
                                  where b.idGrupoMuscular == id
                                  select new { b.IdEjercicio, b.idGrupoMuscular, b.Nombre }).ToList();

                foreach (var item in ejercicios)
                {
                    Ejercicio bean = new Ejercicio()
                    {
                        IdEjercicio = item.IdEjercicio,
                        IdGrupoMuscular = item.idGrupoMuscular,
                        Nombre = item.Nombre
                    };

                    ejerciciosList.Add(bean);
                }
            }
            return ejerciciosList;
        }
    }
}
