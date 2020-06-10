using OnixLibrary;
using OnixLibrary.BBDD;
using OnixModels.Models;
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
    public partial class RutinasScreen : Form
    {
        RutinasController controlador;
        Panel parentPanel;
        List<Rutina> rutinas = new List<Rutina>();
        public RutinasScreen(Panel parentPanel)
        {
            InitializeComponent();
            this.parentPanel = parentPanel;
        }

        private void Rutinas_Load(object sender, EventArgs e)
        {
            rutinas = GetController().GetAllRoutines();


        }


        private RutinasController GetController() {
            if (controlador == null) 
                controlador = new RutinasController();

            return controlador;
                
        }

        private void nuevaRutina_Click(object sender, EventArgs e)
        {
            //Creamos nuevaRutina
            NuevaRutinaScreen nuevaRutina = new NuevaRutinaScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(nuevaRutina);
            nuevaRutina.Show();
        }
    }
}
