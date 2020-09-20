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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            NuevaRutinaScreen screen = new NuevaRutinaScreen()
            {
                TopLevel = false,
                AutoScroll = false
            };

            panel1.Controls.Add(screen);
            screen.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Mantenimientos mant = new Mantenimientos()
            {
                TopLevel = false,
                AutoScroll = false
            };

            panel1.Controls.Add(mant);
            mant.Show();
        }

        private void añadirButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            NuevaRutinaScreen screen = new NuevaRutinaScreen()
            {
                TopLevel = false,
                AutoScroll = false
            };

            panel1.Controls.Add(screen);
            screen.Show();
        }
    }
}
