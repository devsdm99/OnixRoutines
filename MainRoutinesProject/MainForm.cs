using MainRoutinesProject.Screens;
using OnixLibrary;
using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;       //Microsoft Excel 14 object in references-> COM tab

namespace MainRoutinesProject
{
    public partial class MainForm : Form
    {
        List<Ejercicio> listaEjercicios = new List<Ejercicio>();
        int idEjercicio;
        int idGrupoMuscular;
        string nombre;

        private RutinasScreen rutinas;
        private ClientesScreen clientes;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Coral;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void minimize_MouseEnter(object sender, EventArgs e)
        {
            minimize.BackColor = Color.FromArgb(66, 66, 66);

        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.BackColor = Color.Coral;
        }

        private void flatOnix1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();

            if(clientes == null) 
            {
                clientes = new ClientesScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                
            }
            this.panel3.Controls.Add(clientes);
            clientes.init();
        }

        private void rutinasButton_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            RutinasScreen rutinas = new RutinasScreen(panel3) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(rutinas);
            rutinas.Show();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var fileContent = string.Empty;
        //    var filePath = string.Empty;

        //    using (OpenFileDialog openFileDialog = new OpenFileDialog())
        //    {
        //        openFileDialog.InitialDirectory = "c:\\";
        //        openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        //        openFileDialog.FilterIndex = 2;
        //        openFileDialog.RestoreDirectory = true;

        //        if (openFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            //Get the path of specified file
        //            filePath = openFileDialog.FileName;

        //            //Create COM Objects. Create a COM object for everything that is referenced
        //            Excel.Application xlApp = new Excel.Application();
        //            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
        //            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //            Excel.Range xlRange = xlWorksheet.UsedRange;

        //            //Read the contents of the file into a stream

        //            for (int i = 2; i <= xlRange.Rows.Count; i++)
        //            {
        //                if (xlRange.Cells[i, 1].Value2 != null  
        //                    && xlRange.Cells[i, 2].Value2 != null 
        //                    && xlRange.Cells[i, 3].Value2 != null){

        //                    idEjercicio = int.Parse(xlRange.Cells[i, 1].Value2.ToString());
        //                    idGrupoMuscular = int.Parse(xlRange.Cells[i, 2].Value2.ToString());
        //                    nombre = xlRange.Cells[i, 3].Value2.ToString();

        //                    listaEjercicios.Add(new Ejercicio()
        //                    {
        //                        IdEjercicio = idEjercicio,
        //                        IdGrupoMuscular = idGrupoMuscular,
        //                        Nombre = nombre
        //                    });    
        //                }                           
        //             }

        //            insertaEjercicio();
        //        }
        //    }
        //}

        //private void insertaEjercicio()
        //{
        //    foreach(Ejercicio ejercicio in listaEjercicios) 
        //    {
        //        string insert = @"Insert into Ejercicios(idGrupoMuscular,Nombre) values("+ ejercicio.IdGrupoMuscular
        //                                                         +",'" + ejercicio.Nombre +"')";
        //        OnixConnection.Inserta(insert);
        //    }
        //}

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            ClientesScreen  clientes = new ClientesScreen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panel3.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
