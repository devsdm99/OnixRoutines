using Onix.Screens.Manteniments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onix.Screens
{
    public partial class Mantenimientos : Form
    {
        public Mantenimientos()
        {
            InitializeComponent();
        }

        private void añadirButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MusculosMantenimiento man = new MusculosMantenimiento()
            {
                TopLevel = false,
                AutoScroll = false
            };

            panel1.Controls.Add(man); 
            man.Show();
        }
    }
}
