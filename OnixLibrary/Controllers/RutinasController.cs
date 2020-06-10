using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixLibrary.BBDD
{
    public class RutinasController
    {
        List<Rutina> rutinas = new List<Rutina>();

        public List<Rutina> GetAllRoutines()
        {
            using (var db = new OnixDBEntities()) {
                
            }
           return rutinas;

        }
    }
}
