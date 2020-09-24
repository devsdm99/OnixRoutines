using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using OnixLibrary;
using OnixLibrary.PdfClases;
using OnixModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onix.Screens
{
    public partial class MainForm : Form
    {

        List<Ejercicio> listaEjercicios = new List<Ejercicio>();
        int idEjercicio;
        int idGrupoMuscular;
        string nombre;

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

        private void insertaEjercicio()
        {
            foreach (Ejercicio ejercicio in listaEjercicios)
            {
                OnixConnection.InsertaEjercicio(ejercicio);
            }
        }

        private void CargarDatos()
        {
            var ese = OnixConnection.GetAllEjercicios();
            foreach (var item in ese)
            {
                Console.WriteLine(item.Nombre);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Create COM Objects. Create a COM object for everything that is referenced
                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                    Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                    Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                    //Read the contents of the file into a stream

                    for (int i = 2; i <= xlRange.Rows.Count; i++)
                    {
                        if (xlRange.Cells[i, 1].Value2 != null
                            && xlRange.Cells[i, 2].Value2 != null
                            && xlRange.Cells[i, 3].Value2 != null)
                        {

                            idEjercicio = int.Parse(xlRange.Cells[i, 1].Value2.ToString());
                            idGrupoMuscular = int.Parse(xlRange.Cells[i, 2].Value2.ToString());
                            nombre = xlRange.Cells[i, 3].Value2.ToString();

                            listaEjercicios.Add(new Ejercicio()
                            {
                                IdEjercicio = idEjercicio,
                                IdGrupoMuscular = idGrupoMuscular,
                                Nombre = nombre
                            });
                        }
                    }

                    insertaEjercicio();
                }
            }
        }
    }
}
