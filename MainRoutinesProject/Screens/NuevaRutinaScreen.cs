using OnixLibrary.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainRoutinesProject.Screens
{
    public partial class NuevaRutinaScreen : Form
    {
        List<EjercicioRutina> ejercicios = new List<EjercicioRutina>();
        public NuevaRutinaScreen()
        {
            InitializeComponent();
        }

        private void flatOnix1_Click(object sender, EventArgs e)
        {
            EjercicioRutina nuevo = new EjercicioRutina() {};
            ejercicios.Add(nuevo);
            flowLayoutPanel1.Controls.Add(nuevo);
        }
    }
}
