using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixLibrary.BBDD
{
    public  class GruposMuscularesController
    {
        public  List<GrupoMuscular> GetAllGruposMusculaes()
        {
            List<GrupoMuscular> gruposMusculares = new List<GrupoMuscular>();
            using (var grupos = new OnixDBEntities())
            {
                var gruposMusculaes = (from b in grupos.GruposMusculares
                                  select new { b.IdGrupoMuscular, b.Nombre }).ToList();

                if (gruposMusculaes.Count > 0)
                {
                    foreach (var x in gruposMusculaes)
                    {
                        GrupoMuscular ex = new GrupoMuscular()
                        {
                           IdGrupoMuscular = x.IdGrupoMuscular,
                           Nombre = x.Nombre
                        };
                        gruposMusculares.Add(ex);
                    }
                }
            }
            return gruposMusculares;

        }
    }
}
