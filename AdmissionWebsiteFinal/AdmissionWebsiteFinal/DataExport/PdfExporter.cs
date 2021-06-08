using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Drawing;
using System.IO;
using AdmissionWebsiteFinal.Models;
using Syncfusion.Pdf.Grid;
using System.Data;

namespace AdmissionWebsiteFinal.DataExport
{
    public class PdfExporter
    {
        public void CreatePdfTable(ref PdfDocument doc,string tableName, IEnumerable<AdmissionEntryViewModel> entries)
        {
            PdfPage page = doc.Pages.Add();
            PdfGrid pdfGrid = new PdfGrid();
            DataTable dataTable = new DataTable();
            PdfGraphics graphics = page.Graphics;

            PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);
            graphics.DrawString(tableName, font, PdfBrushes.Black, new PointF(0, 0));

            dataTable.Columns.Add("Rank");
            dataTable.Columns.Add("Id");
            dataTable.Columns.Add("Score");
            dataTable.Columns.Add("CNP");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");

            int rankNumber = 1;
            foreach(var entry in entries)
            {
                dataTable.Rows.Add(new object[] 
                {
                  rankNumber,
                  entry.Id, 
                  entry.EntryScore, 
                  entry.ContestantId, 
                  entry.Contestant.FirstName, 
                  entry.Contestant.LastName });
                rankNumber++;
            }
            pdfGrid.DataSource = dataTable;
            pdfGrid.Draw(page, new Syncfusion.Drawing.PointF(10, 30));
        }
    }
}
