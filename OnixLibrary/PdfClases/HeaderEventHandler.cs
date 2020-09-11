using iText.Kernel.Colors;
using iText.Kernel.Events;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image = iText.Layout.Element.Image;

namespace OnixLibrary.PdfClases
{
    public class HeaderEventHandler : IEventHandler
    {
        Image Img;
        public HeaderEventHandler(Image img)
        {
            Img = img;
        }
        public void HandleEvent(Event @event)
        {
            PdfDocumentEvent docEvent = (PdfDocumentEvent)@event;
            PdfDocument pdfDoc = docEvent.GetDocument();
            PdfPage page = docEvent.GetPage();

            Rectangle rootArea = new Rectangle(35, page.GetPageSize().GetTop() - 70, page.GetPageSize().GetRight() - 70,35);
            Canvas canvas = new Canvas(page, rootArea);
            canvas.Add(getTable(docEvent));
        }

        public Table getTable(PdfDocumentEvent docEvent)
        {

            Style styleText = new Style().SetTextAlignment(TextAlignment.RIGHT).SetFontSize(12).SetBold();
            Style styleDatos = new Style().SetTextAlignment(TextAlignment.RIGHT).SetFontSize(10);

            Style styleCell = new Style().SetBorder(Border.NO_BORDER);

            float[] cellWidth = { 10f, 50f, 33f };

            Table tableEvent = new Table(UnitValue.CreatePercentArray(cellWidth)).UseAllAvailableWidth().SetBorder(Border.NO_BORDER);

            Cell cell = new Cell().Add(Img.SetAutoScale(true)).AddStyle(styleCell);
            tableEvent.AddCell(cell.AddStyle(styleCell)).SetTextAlignment(TextAlignment.LEFT);

            cell = new Cell().Add(new Paragraph("CENTRE TERAPÈUTIC ONIX").AddStyle(styleText)).AddStyle(styleCell);
            tableEvent.AddCell(cell);

            cell = new Cell()
                .Add(new Paragraph("Tel.: 931 058 931\n"))
                .Add(new Paragraph("Mail: centerapeutic.onix @gmail.com")).AddStyle(styleDatos).AddStyle(styleCell);
            tableEvent.AddCell(cell);




            return tableEvent;

        }
    }
}
