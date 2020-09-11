
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

namespace MainRoutinesProject.Screens
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
            //iTextSharp.text.Font boldFont = FontFactory.GetFont("Arial", 13, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));
            //iTextSharp.text.Font normalFont = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.NORMAL, new iTextSharp.text.BaseColor(0, 0, 0));
            //iTextSharp.text.Font titleFont = FontFactory.GetFont("Helvetica", 20, iTextSharp.text.Font.BOLD, new iTextSharp.text.BaseColor(0, 0, 0));


            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            //saveFileDialog1.Filter = "Pdf Files|*.pdf";
            //saveFileDialog1.Title = "Save an Image File";
            //saveFileDialog1.ShowDialog();
            //string Imagenpath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //if (saveFileDialog1.FileName != "")
            //{
            //    var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
            //    string path = saveFileDialog1.FileName;
            //    PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));

            //    pdfDoc.Open();

            //    using (FileStream fs = new FileStream(Imagenpath + "\\Resources\\Icons\\OnixLogo.png", FileMode.Open))
            //    {
            //        var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), ImageFormat.Png);
            //        png.ScalePercent(5f);
            //        png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
            //        pdfDoc.Add(png);
            //    }
            //    Paragraph title = new Paragraph("Onix Centre Terapèutic", titleFont);
            //    title.Alignment = Element.ALIGN_CENTER;
            //    pdfDoc.Add(title);



            //    var spacer = new Paragraph("")
            //    {
            //        SpacingBefore = 10f,
            //        SpacingAfter = 10f,
            //    };
            //    pdfDoc.Add(spacer);


            //    //HEADERS  PRINCIPAL
            //    var headerTable = new PdfPTable(new[] { .75f, 2f })
            //    {
            //        HorizontalAlignment = Left,
            //        WidthPercentage = 75,
            //        DefaultCell = { MinimumHeight = 22f }
            //    };

            //    Phrase firstLine = new Phrase("Nombre", boldFont);
            //    headerTable.AddCell(firstLine);
            //    headerTable.AddCell(NombreTB.Text);

            //    firstLine = new Phrase("Fecha Inicio", boldFont);
            //    headerTable.AddCell(firstLine);
            //    headerTable.AddCell(FechaTB.Text);

            //    firstLine = new Phrase("Proximo Control", boldFont);
            //    headerTable.AddCell(firstLine);
            //    headerTable.AddCell(ControlTB.Text);

            //    firstLine = new Phrase("Nº Rutina", boldFont);
            //    headerTable.AddCell(firstLine);
            //    headerTable.AddCell(RutinaNumTB.Text);

            //    pdfDoc.Add(headerTable);
            //    pdfDoc.Add(spacer);


            //    //TABLEROS EJERCICIOS
            //    var columnWidths = new[] { 0.75f, 0.75f, 2f, 0.5f, 1f };

            //    var table = new PdfPTable(columnWidths)
            //    {
            //        HorizontalAlignment = Left,
            //        WidthPercentage = 100,
            //        DefaultCell = { MinimumHeight = 22f }
            //    };


            //    //ORDER POR DIA
            //    var listaDia = ejercicios.OrderBy(x => x.Dia).ToList();
            //    //AGRUPAMOS PRO GRUPO PARA NO REPETIR LOS DIAS
            //    var grouping = listaDia.GroupBy(x => x.Dia).Select(x => new { x.Key }).ToList();
            //    int dias = grouping.Count();

            //    for (int i = 0; i < dias; i++)
            //    {

            //        var cell = new PdfPCell(new Phrase("Dia " + grouping[i].Key, boldFont))
            //        {
            //            Colspan = 5,
            //            HorizontalAlignment = 1,  //0=Left, 1=Centre, 2=Right
            //            MinimumHeight = 30f
            //        };
            //        table.AddCell(cell);
            //        pdfDoc.Add(table);
            //        pdfDoc.Add(spacer);

            //        table = new PdfPTable(6)
            //        {
            //            HorizontalAlignment = 1,
            //            WidthPercentage = 100,
            //            DefaultCell = { MinimumHeight = 22f }
            //        };


            //        //headers

            //        var pordia = listaDia.Where(x => x.Dia == grouping[i].Key).ToList();
            //        cell = new PdfPCell(new Phrase("Ejercicio", boldFont));
            //        table.AddCell(cell);
            //        cell = new PdfPCell(new Phrase("Series", boldFont));
            //        table.AddCell(cell);
            //        cell = new PdfPCell(new Phrase("Repeticiones", boldFont));
            //        table.AddCell(cell);
            //        cell = new PdfPCell(new Phrase("Descansos", boldFont));
            //        table.AddCell(cell);
            //        cell = new PdfPCell(new Phrase("Comentarios", boldFont));
            //        table.AddCell(cell);
            //        cell = new PdfPCell(new Phrase("Foto", boldFont));
            //        table.AddCell(cell);

            //        foreach (var item in pordia)
            //        {
            //            iTextSharp.text.Image img;
            //            try
            //            {
                           

            //                if (!item.ImagePath.Equals(""))
            //                {
            //                    img = iTextSharp.text.Image.GetInstance(item.ImagePath);
            //                    img.ScaleAbsolute(19f, 19f);
            //                }
            //                else
            //                    img = null;
            //                table.AddCell(new Phrase(item.Ejercicio.ToString(), normalFont));
            //                table.AddCell(new Phrase(item.Series.ToString(), normalFont));
            //                table.AddCell(new Phrase(item.Repeticiones.ToString(), normalFont));
            //                table.AddCell(new Phrase(item.Descanso, normalFont));
            //                table.AddCell(new Phrase(item.Comentario, normalFont));
            //                table.AddCell(img);
            //            }
            //            catch (Exception ex)
            //            {

            //            }

            //        }
            //        pdfDoc.Add(table);
            //        pdfDoc.Add(spacer);


            //    }
            //    pdfDoc.Close();
            //    MessageBox.Show("Se ha generado el pdf en la ruta: " + saveFileDialog1.FileName);
            //}

        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = System.Drawing.Color.Red;
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

        private void button4_Click(object sender, EventArgs e)
        {
            Style boldStyle = new Style().SetTextAlignment(TextAlignment.CENTER).SetFontSize(11).SetBold();
            Style headerMusculo = new Style().SetTextAlignment(TextAlignment.LEFT).SetBold().SetBorder(Border.NO_BORDER);

            Style styleDatos = new Style().SetBorder(Border.NO_BORDER).SetFontSize(9);

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
            doc.SetMargins(75, 15, 70, 15);

            Table table = new Table(1).UseAllAvailableWidth(); //USAR TODO EL ANCHO DE LA HOJA
            Cell cell = new Cell().Add(new Paragraph("Nom:").SetFontSize(10))
                                                            .SetTextAlignment(TextAlignment.LEFT)
                                                            .SetBorder(Border.NO_BORDER).SetBold();

            table.AddCell(cell);
            doc.Add(table);


            Table _table = new Table(7).UseAllAvailableWidth();
            Cell _cell = new Cell().Add(new Paragraph("Lorena Vicente")).SetFontSize(10);
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

            _cell = new Cell().Add(new Paragraph("003").SetTextAlignment(TextAlignment.RIGHT));
            _table.AddCell(_cell);
            doc.Add(_table);

            Table tablaPrincipal = new Table(4).SetBorder(Border.NO_BORDER);
            tablaPrincipal.SetHorizontalBorderSpacing(0.5f);
            tablaPrincipal.SetVerticalBorderSpacing(0.5f);

            for (int i = 0; i < 7; i++)
            {
                Table ejercicio = new Table(1).SetBorder(Border.NO_BORDER);
                ejercicio.SetWidth(90);


                Table musculo = new Table(1).SetBorder(Border.NO_BORDER);
                musculo.UseAllAvailableWidth();

                Cell celda = new Cell().SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT).Add(new Paragraph("Deltoides"))
                                                                                                                    .SetFontSize(10)
                                                                                                                    .AddStyle(headerMusculo);
                musculo.AddCell(celda);
                ejercicio.AddCell(musculo);


                Table nomEjercicio = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.LEFT)
                                                                                                           .Add(new Paragraph("Elevacion_frontal_alterno_de_pie")
                                                                                                           .SetFontSize(8)).SetBorder(Border.NO_BORDER);
                nomEjercicio.AddCell(celda);
                ejercicio.AddCell(nomEjercicio);

                Table datos = new Table(6).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);
                celda = new Cell().Add(new Paragraph("Dia").SetFontSize(8.5f));
                datos.AddCell(celda.AddStyle(headerMusculo));

                celda = new Cell().Add(new Paragraph("1")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Ser")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                celda = new Cell().Add(new Paragraph("15")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                celda = new Cell().Add(new Paragraph("Rep")).SetBorder(Border.NO_BORDER);
                datos.AddCell(celda.AddStyle(headerMusculo).SetFontSize(8.5f));

                celda = new Cell().Add(new Paragraph("10")).SetBorder(new SolidBorder(0.5f));
                datos.AddCell(celda.AddStyle(styleDatos));

                ejercicio.AddCell(datos);

                Table foto = new Table(6).SetBorder(Border.NO_BORDER); 
                Table descanso = new Table(1).SetBorder(Border.NO_BORDER);

                celda = new Cell().Add(new Paragraph("Descans").SetFontSize(9).SetBold()).SetBorder(Border.NO_BORDER);
                descanso.AddCell(celda);

                celda = new Cell().Add(new Paragraph("30S").SetFontSize(9)).SetBorder(new SolidBorder(ColorConstants.BLACK, 0.5f));
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

                celda = new Cell().Add(new Paragraph("Bajada lenta").AddStyle(styleDatos)).SetBorder(Border.NO_BORDER);
                otrosDatos3.AddCell(celda);
                ejercicio.AddCell(otrosDatos3);

                tablaPrincipal.AddCell(ejercicio);

            }
            doc.Add(tablaPrincipal);

            doc.Close();





        }
    }
}
