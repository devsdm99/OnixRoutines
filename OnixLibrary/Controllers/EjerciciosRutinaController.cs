using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixLibrary.BBDD
{
    public class EjerciciosRutinaController
    {
        private EjerciciosController controladorEjercicios;
        private GruposMuscularesController controladorGruposMusculares;


        public GruposMuscularesController GetGruposController()
        {
            if(controladorGruposMusculares == null)
            {
                controladorGruposMusculares = new GruposMuscularesController();
            }

            return controladorGruposMusculares;
        }

        public EjerciciosController GetEjerciciosController()
        {
            if (controladorEjercicios == null)
            {
                controladorEjercicios = new EjerciciosController();
            }

            return controladorEjercicios;
        }


        public List<Descanso> GetAllDescansos()
        {
            List<Descanso> lista = new List<Descanso>();

            using(var db = new OnixDBEntities())
            {
                var listaDescansos = (from b in db.Descansos
                                     select new { b.IdDescanso, b.TiempoDescanso}).ToList();

                foreach (var item in listaDescansos)
                {
                    Descanso desc = new Descanso()
                    {
                        IdDescanso = item.IdDescanso,
                        TiempoDescanso = item.TiempoDescanso
                    };

                    lista.Add(desc);
                }
            }

            return lista;

        }


        public List<Comentario> GetComentarios()
        {
            List<Comentario> lista = new List<Comentario>();

            using (var db = new OnixDBEntities())
            {
                var listaDescansos = (from b in db.Comentarios
                                      select new { b.IdComentario, b.Comentario }).ToList();

                foreach (var item in listaDescansos)
                {
                    Comentario com = new Comentario()
                    {
                        idComentario = item.IdComentario,
                        TipoComentario = item.Comentario
                    };

                    lista.Add(com);
                }
            }

            return lista;
        }
      
    }
}
