using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnixModels.Models
{
    public class Descanso
    {
        private int idDescanso;

        public int IdDescanso
        {
            get { return idDescanso; }
            set { idDescanso = value; }
        }


        private string tiempoDescanso;

        public string TiempoDescanso
        {
            get { return tiempoDescanso; }
            set { tiempoDescanso = value; }
        }

    }
}
