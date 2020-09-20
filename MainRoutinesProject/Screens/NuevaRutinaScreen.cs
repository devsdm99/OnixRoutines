
using OnixLibrary.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;
using OnixModels.Models;
using OnixLibrary;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using iText.IO.Image;
using Image = iText.Layout.Element.Image;
using iText.Kernel.Events;
using OnixLibrary.PdfClases;

namespace Onix.Screens
{
    public partial class NuevaRutinaScreen : Form
    {
        private List<EjercicioRutina> ejercicios = new List<EjercicioRutina>();
        List<Ejercicio> listaEjercicios = new List<Ejercicio>();
        int idEjercicio;
        int idGrupoMuscular;
        string nombre;
        public NuevaRutinaScreen()
        {
            InitializeComponent();
        }

        private void newRutina_Click(object sender, EventArgs e)
        {
            EjercicioRutina nuevo = new EjercicioRutina()
            {
            };
            flowLayoutPanel1.Controls.Add(nuevo);
            ejercicios.Add(nuevo);
        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            ejercicios.Clear();
            if (ComprobarCampos())
            {
                if (flowLayoutPanel1.Controls.Count > 0)
                {
                    foreach (var item in flowLayoutPanel1.Controls)
                    {
                        if (item is EjercicioRutina)
                        {
                            ejercicios.Add(((EjercicioRutina)item));

                        }
                    }
                    // GetController().GenerarRutina(ejercicios, NombreTB.Text);

                    GeneratePDF();

                }
                else
                {
                    MessageBox.Show("No hay ejercios añadidos.");
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por rellenar");
            }
        }

        private bool ComprobarCampos()
        {
            bool ese = !string.IsNullOrEmpty(NombreTB.Text) && !string.IsNullOrEmpty(FechaFinTB.Text) && !string.IsNullOrEmpty(RutinaNumTB.Text);
            return ese;
        }

        private void DibujarEjercicios()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in ejercicios)
            {
                flowLayoutPanel1.Controls.Add(item);
            }
        }
        protected void GeneratePDF()
        {
            Style boldStyle = new Style().SetTextAlignment(TextAlignment.CENTER).SetFontSize(11).SetBold();
            Style headerMusculo = new Style().SetTextAlignment(TextAlignment.LEFT).SetBold();

            Style styleDatos = new Style().SetFontSize(9);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pdf Files|*.pdf";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            string Imagenpath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Image logo = new Image(ImageDataFactory.Create(Imagenpath + "\\Resources\\Icons\\OnixLogo.png"));

            string path = saveFileDialog1.FileName;
            try
            {

                PdfWriter pw = new PdfWriter(path);
                PdfDocument pdfDocument = new PdfDocument(pw);

                pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(logo));
                Document doc = new Document(pdfDocument, PageSize.LETTER);
                doc.SetMargins(75, 15, 15, 15);

                Table table = new Table(1).UseAllAvailableWidth(); //USAR TODO EL ANCHO DE LA HOJA

                table.AddCell(new Cell().Add(new Paragraph("Nom:").SetFontSize(10))
                                                                .SetTextAlignment(TextAlignment.LEFT)
                                                                .SetBold().SetBorder(Border.NO_BORDER));

                doc.Add(table);


                Table _table = new Table(7).UseAllAvailableWidth();
                Cell _cell = new Cell().Add(new Paragraph(NombreTB.Text)).SetFontSize(10);
                _table.AddCell(_cell);

                _cell = new Cell().Add(new Paragraph("Data inici rutina")).SetBorder(Border.NO_BORDER);
                _table.AddCell(_cell.AddStyle(boldStyle));

                _cell = new Cell().Add(new Paragraph(FechaTB.Text)).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER);
                _table.AddCell(_cell);

                _cell = new Cell().Add(new Paragraph("Data final rutina")).SetBorder(Border.NO_BORDER);
                _table.AddCell(_cell.AddStyle(boldStyle));

                _cell = new Cell().Add(new Paragraph(FechaFinTB.Text)).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER);
                _table.AddCell(_cell);

                _cell = new Cell().Add(new Paragraph("Rutina")).SetBorder(Border.NO_BORDER);
                _table.AddCell(_cell.AddStyle(boldStyle));

                _cell = new Cell().Add(new Paragraph(RutinaNumTB.Text).SetTextAlignment(TextAlignment.RIGHT));
                _table.AddCell(_cell);
                _table.SetMarginBottom(2f);
                doc.Add(_table);


                Table tablaPrincipal = new Table(4).SetBorder(new SolidBorder(ColorConstants.RED, 2));
                tablaPrincipal.SetHorizontalBorderSpacing(0f);
                tablaPrincipal.SetVerticalBorderSpacing(0f);
                var listaDia = ejercicios.OrderBy(x => x.Dia).ToList();


                foreach (var item in listaDia)
                {
                    Table ejercicio = new Table(1);
                    ejercicio.SetWidth(90);

                    Table musculo = new Table(1);
                    musculo.UseAllAvailableWidth();

                    Cell celda = new Cell();

                    musculo.AddCell(new Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph(item.Musculo))
                                              .SetBorder(Border.NO_BORDER)
                                              .SetFontSize(10).SetBold()
                                              .SetTextAlignment(TextAlignment.LEFT));

                    ejercicio.SetBorder(Border.NO_BORDER).AddCell(musculo);

                    Table nomEjercicio = new Table(1).SetBorder(Border.NO_BORDER);

                    celda = new Cell().SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                                                                                               .Add(new Paragraph(item.Ejercicio)
                                                                                                                 .SetFontSize(8)).SetBorder(Border.NO_BORDER);

                    nomEjercicio.AddCell(celda);

                    ejercicio.AddCell(nomEjercicio);

                    Table datos = new Table(6).UseAllAvailableWidth();
                    celda = new Cell().Add(new Paragraph("Dia").SetFontSize(8.5f)).SetBorder(Border.NO_BORDER);
                    datos.AddCell(celda.AddStyle(headerMusculo));

                    celda = new Cell().Add(new Paragraph(item.Dia.ToString())).SetBorder(new SolidBorder(0.5f));
                    datos.AddCell(celda.AddStyle(styleDatos));

                    celda = new Cell().Add(new Paragraph("Ser")).SetBorder(Border.NO_BORDER);
                    datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                    celda = new Cell().Add(new Paragraph(item.Series.ToString())).SetBorder(new SolidBorder(0.5f));
                    datos.AddCell(celda.AddStyle(styleDatos));

                    celda = new Cell().Add(new Paragraph("Rep")).SetBorder(Border.NO_BORDER);
                    datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                    celda = new Cell().Add(new Paragraph(item.Repeticiones.ToString())).SetBorder(new SolidBorder(0.5f));
                    datos.AddCell(celda.AddStyle(styleDatos));

                    ejercicio.AddCell(datos);

                    Table foto = new Table(6).SetBorder(Border.NO_BORDER);
                    Table descanso = new Table(1).SetBorder(Border.NO_BORDER);

                    celda = new Cell().Add(new Paragraph("Descans").SetFontSize(9).SetBold()).SetBorder(Border.NO_BORDER);
                    descanso.AddCell(celda);

                    celda = new Cell().Add(new Paragraph(item.Descanso).SetTextAlignment(TextAlignment.CENTER).SetFontSize(9)).SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));
                    descanso.AddCell(celda);
                    foto.AddCell(descanso);



                    if (string.IsNullOrWhiteSpace(item.ImagePath)){
                        MessageBox.Show("Algun ejercicio no tiene asignada ninguna foto");
                        return;
                    }
                    Image imgEjercicio = new Image(ImageDataFactory.Create(item.ImagePath));

                    celda = new Cell(2, 5).Add(imgEjercicio.SetHeight(87f).SetWidth(87f)).SetBorder(Border.NO_BORDER);
                    foto.AddCell(celda);

                    ejercicio.AddCell(foto);

                    Table otrosDatos2 = new Table(1).UseAllAvailableWidth();

                    celda = new Cell().Add(new Paragraph("Notes").AddStyle(headerMusculo).SetFontSize(10f)).SetBorder(Border.NO_BORDER);
                    otrosDatos2.AddCell(celda);
                    ejercicio.AddCell(otrosDatos2);


                    Table otrosDatos3 = new Table(1).UseAllAvailableWidth();

                    celda = new Cell().Add(new Paragraph(item.Comentario).AddStyle(styleDatos)).SetBorder(Border.NO_BORDER);
                    otrosDatos3.AddCell(celda);
                    ejercicio.AddCell(otrosDatos3);

                    tablaPrincipal.AddCell(ejercicio).SetBorder(Border.NO_BORDER);
                }


                doc.Add(tablaPrincipal);

                doc.Close();

                MessageBox.Show("Se ha generado el pdf en la ruta: " + path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la creacion de la rutina");
                return;

            }



        }



        private void Ordenar()
        {
            if (flowLayoutPanel1.Controls.Count > 1)
            {
                var tmpOrdenados = ejercicios.OrderBy(x => x.Dia).ToList();
                ejercicios = tmpOrdenados;
            }
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            var eliminados = ejercicios.Where(x => x.IsElimianar).ToList();

            if (eliminados.Count > 0)
            {
                foreach (var item in eliminados)
                {
                    ejercicios.Remove(item);
                }
                Ordenar();
                DibujarEjercicios();
            }
            else
            {
                MessageBox.Show("No hay ejercicios por eliminar");
            }

        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            Ordenar();
            DibujarEjercicios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private static void RemoveBorder(Table table)
        {
            foreach(IElement iElement in table.GetChildren())
            {
                ((Cell)iElement).SetBorder(Border.NO_BORDER);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Style boldStyle = new Style().SetTextAlignment(TextAlignment.CENTER).SetFontSize(6).SetBold();
            Style headerMusculo = new Style().SetTextAlignment(TextAlignment.LEFT).SetBold();

            Style styleDatos = new Style().SetFontSize(9);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pdf Files|*.pdf";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            string Imagenpath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Image imgEjercicio = new Image(ImageDataFactory.Create(Imagenpath + "\\Resources\\Ejercicios_Fotos\\Dominadas.jpg"));
            Image logo = new Image(ImageDataFactory.Create(Imagenpath + "\\Resources\\Icons\\OnixLogo.png"));

            string path = saveFileDialog1.FileName;


            PdfWriter pw = new PdfWriter(path);
            PdfDocument pdfDocument = new PdfDocument(pw);

            pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(logo));
            Document doc = new Document(pdfDocument, PageSize.LETTER);
            doc.SetMargins(65, 15, 15, 15);

            Table table = new Table(1).UseAllAvailableWidth(); //USAR TODO EL ANCHO DE LA HOJA

            table.AddCell(new Cell().Add(new Paragraph("Nom:").SetFontSize(7))
                                                            .SetTextAlignment(TextAlignment.LEFT)
                                                            .SetBold().SetBorder(Border.NO_BORDER));

            doc.Add(table);


            Table _table = new Table(7).UseAllAvailableWidth();
            Cell _cell = new Cell().Add(new Paragraph("Lorena Vicente")).SetFontSize(6);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Data inici rutina")).SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph(FechaTB.Text)).SetFontSize(6).SetTextAlignment(TextAlignment.CENTER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Data final rutina")).SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph(FechaFinTB.Text)).SetFontSize(6).SetTextAlignment(TextAlignment.CENTER);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Rutina")).SetBorder(Border.NO_BORDER);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph("003").SetTextAlignment(TextAlignment.RIGHT));
            _table.AddCell(_cell);
            _table.SetMarginBottom(2f);
            doc.Add(_table);


            Table tablaPrincipal = new Table(4).SetBorder(new SolidBorder(ColorConstants.RED,2));
            tablaPrincipal.SetHorizontalBorderSpacing(2f);
            tablaPrincipal.SetVerticalBorderSpacing(0.5f);
            var listaDia = ejercicios.OrderBy(x => x.Dia).ToList();


            foreach (var item in listaDia)
            {
                Table ejercicio = new Table(1);
                ejercicio.SetWidth(90);

                Table musculo = new Table(1);
                musculo.UseAllAvailableWidth();

                Cell celda = new Cell();

                musculo.AddCell(new Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph(item.Musculo))
                                          .SetBorder(Border.NO_BORDER)
                                          .SetFontSize(10).SetBold()
                                          .SetTextAlignment(TextAlignment.LEFT));

                ejercicio.SetBorder(Border.NO_BORDER).AddCell(musculo);

                Table nomEjercicio = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                                                                                           .Add(new Paragraph(item.Ejercicio)
                                                                                                             .SetFontSize(8)).SetBorder(Border.NO_BORDER);

                nomEjercicio.AddCell(celda);

                ejercicio.AddCell(nomEjercicio);

                Table datos = new Table(6).UseAllAvailableWidth();
                celda = new Cell().Add(new Paragraph("Dia").SetFontSize(8.5f)).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo));

                celda = new Cell().Add(new Paragraph(item.Dia.ToString())).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Ser")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                celda = new Cell().Add(new Paragraph(item.Series.ToString())).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Rep")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                celda = new Cell().Add(new Paragraph(item.Repeticiones.ToString())).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                ejercicio.AddCell(datos);

                Table foto = new Table(6).SetBorder(Border.NO_BORDER);
                Table descanso = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().Add(new Paragraph("Descans").SetFontSize(9).SetBold()).SetBorder(Border.NO_BORDER);
                descanso.AddCell(celda);

                celda = new Cell().Add(new Paragraph(item.Descanso).SetTextAlignment(TextAlignment.CENTER).SetFontSize(9)).SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));
                descanso.AddCell(celda);
                foto.AddCell(descanso);

                celda = new Cell(2, 5).Add(imgEjercicio.SetHeight(87f).SetWidth(87f)).SetBorder(Border.NO_BORDER);
                foto.AddCell(celda);

                ejercicio.AddCell(foto);

                Table otrosDatos2 = new Table(1).UseAllAvailableWidth();

                celda = new Cell().Add(new Paragraph("Notes").AddStyle(headerMusculo).SetFontSize(10f)).SetBorder(Border.NO_BORDER);
                otrosDatos2.AddCell(celda);
                ejercicio.AddCell(otrosDatos2);


                Table otrosDatos3 = new Table(1).UseAllAvailableWidth();

                celda = new Cell().Add(new Paragraph(item.Comentario).AddStyle(styleDatos)).SetBorder(Border.NO_BORDER);
                otrosDatos3.AddCell(celda);
                ejercicio.AddCell(otrosDatos3);

                tablaPrincipal.AddCell(ejercicio).SetBorder(Border.NO_BORDER);
            }



            doc.Add(tablaPrincipal);

            doc.Close();





        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Style boldStyle = new Style().SetTextAlignment(TextAlignment.CENTER).SetFontSize(8).SetBold();
            Style headerMusculo = new Style().SetTextAlignment(TextAlignment.LEFT).SetBold();

            Style styleDatos = new Style().SetFontSize(7);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pdf Files|*.pdf";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            string Imagenpath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            Image imgEjercicio = new Image(ImageDataFactory.Create(Imagenpath + "\\Resources\\Ejercicios_Fotos\\Dominadas.jpg"));
            Image logo = new Image(ImageDataFactory.Create(Imagenpath + "\\Resources\\Icons\\OnixLogo.png"));

            string path = saveFileDialog1.FileName;


            PdfWriter pw = new PdfWriter(path);
            PdfDocument pdfDocument = new PdfDocument(pw);

            pdfDocument.AddEventHandler(PdfDocumentEvent.START_PAGE, new HeaderEventHandler(logo));
            Document doc = new Document(pdfDocument, PageSize.A4);
            doc.SetMargins(55, 15, 15, 15);

            Table table = new Table(1).UseAllAvailableWidth(); //USAR TODO EL ANCHO DE LA HOJA

            table.AddCell(new Cell().Add(new Paragraph("Nom:").SetFontSize(8))
                                                            .SetTextAlignment(TextAlignment.LEFT)
                                                            .SetBold().SetBorder(Border.NO_BORDER));

            doc.Add(table);


            Table _table = new Table(7).UseAllAvailableWidth();
            Cell _cell = new Cell().Add(new Paragraph("Lorena Vicente").AddStyle(styleDatos)).SetMaxHeight(20f).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Data inici rutina")).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph(FechaTB.Text)).AddStyle(styleDatos).SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Data final rutina")).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph(FechaFinTB.Text)).AddStyle(styleDatos).SetTextAlignment(TextAlignment.CENTER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell);

            _cell = new Cell().Add(new Paragraph("Rutina")).SetBorder(Border.NO_BORDER).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell.AddStyle(boldStyle));

            _cell = new Cell().Add(new Paragraph("003").AddStyle(styleDatos).SetTextAlignment(TextAlignment.RIGHT)).SetVerticalAlignment(VerticalAlignment.MIDDLE);
            _table.AddCell(_cell);
            doc.Add(_table);


            Table tablaPrincipal = new Table(4);
            tablaPrincipal.SetHorizontalBorderSpacing(0);
            tablaPrincipal.SetVerticalBorderSpacing(0);
            var listaDia = ejercicios.OrderBy(x => x.Dia).ToList();


            for (int i = 0; i < 20; i++)
            {
                Table ejercicio = new Table(1);
                ejercicio.SetWidth(100);

                Table musculo = new Table(1);
                musculo.UseAllAvailableWidth();

                Cell celda = new Cell();
                musculo.AddCell(new Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY).Add(new Paragraph("DELTOIDES"))
                                          .SetBorder(Border.NO_BORDER)
                                          .SetFontSize(7).SetBold()
                                          .SetTextAlignment(TextAlignment.LEFT));

                ejercicio.SetBorder(Border.NO_BORDER).AddCell(musculo);

                Table nomEjercicio = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                                                                                .Add(new Paragraph("Sentadilla_bulgara_con_mancuernas")
                                                                                                    .SetFontSize(7)).SetBorder(Border.NO_BORDER);

                nomEjercicio.AddCell(celda);

                ejercicio.AddCell(nomEjercicio);

                Table datos = new Table(6).UseAllAvailableWidth();
                celda = new Cell().Add(new Paragraph("Dia").SetFontSize(7f)).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo));

                celda = new Cell().Add(new Paragraph("A")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Ser")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(7f));

                celda = new Cell().Add(new Paragraph("2")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Rep")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(7f));

                celda = new Cell().Add(new Paragraph("3")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                ejercicio.AddCell(datos);

                Table foto = new Table(6).SetBorder(Border.NO_BORDER);
                Table descanso = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().Add(new Paragraph("Descans").SetFontSize(8).SetBold()).SetBorder(Border.NO_BORDER);
                descanso.AddCell(celda);

                celda = new Cell().Add(new Paragraph("30s").AddStyle(styleDatos).SetTextAlignment(TextAlignment.LEFT)).SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));
                descanso.AddCell(celda);
                foto.AddCell(descanso);

                celda = new Cell(2, 5).Add(imgEjercicio.SetHeight(70f).SetWidth(77f)).SetBorder(Border.NO_BORDER);
                foto.AddCell(celda);

                ejercicio.AddCell(foto);

                Table otrosDatos2 = new Table(1).UseAllAvailableWidth();

                celda = new Cell().Add(new Paragraph("Notes").AddStyle(headerMusculo).SetFontSize(7f)).SetBorder(Border.NO_BORDER);
                otrosDatos2.AddCell(celda);

                celda = new Cell().Add(new Paragraph("Baja lento contrae arriba").AddStyle(headerMusculo).SetFontSize(7f)).SetBorder(new SolidBorder(ColorConstants.BLUE,0.5f));
                otrosDatos2.AddCell(celda);
                ejercicio.AddCell(otrosDatos2);

                tablaPrincipal.AddCell(ejercicio.SetBorder(Border.NO_BORDER)).SetBorder(Border.NO_BORDER);
               
            }



            doc.Add(tablaPrincipal);

            doc.Close();
        }
    }
}
