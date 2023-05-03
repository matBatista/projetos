using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GemBox.Document;
using GemBox.Document.Tables;
using ZXing;
using ZXing.Common;

namespace ExcelToBarcode
{
    public partial class formExcel : Form
    {
        public formExcel()
        {
            InitializeComponent();

            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            DocumentModel document = new DocumentModel();

            Section section = new Section(document);
            document.Sections.Add(section);

            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.CODE_128, // Set the barcode format
                Options = new EncodingOptions // Set the encoding options
                {
                    Height = 100,
                    Width = 300,
                    Margin = 5
                }
            };

            List<string> codigos = new List<string>();

            int x = 0;
            while(x < 16)
            {
                codigos.Add("Item Teste " + x.ToString().PadLeft(3));
                x++;
            }
            /*
            for (int i = 0; i < codigos.Count; i++)
            {
                Paragraph paragraph = new Paragraph(document);

                //Run barcodeRun = new Run(document, codigos[i]);
                //paragraph.Inlines.Add(barcodeRun);

                Bitmap barcodeBitmap = writer.Write(codigos[i]);
                MemoryStream stream = new MemoryStream();
                barcodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                Picture barcodePicture = new Picture(document, stream);

                paragraph.Inlines.Add(barcodePicture);

                section.Blocks.Add(paragraph);
            }*/

            // Set the number of columns
            int columns = 2;

            // Calculate the number of rows needed
            int rows = (int)Math.Ceiling((double)codigos.Count / columns);

            // Create a table with the specified number of rows and columns
            Table table = new Table(document);
            for (int i = 0; i < rows; i++)
            {
                table.Rows.Add(new TableRow(document));
                for (int j = 0; j < columns; j++)
                {
                    table.Rows[i].Cells.Add(new TableCell(document));
                }
            }

            // Add a barcode to each cell of the table
            for (int i = 0; i < codigos.Count; i++)
            {
                Bitmap barcodeBitmap = writer.Write(codigos[i]);
                MemoryStream stream = new MemoryStream();
                barcodeBitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);

                Picture barcodePicture = new Picture(document, stream);

                int row = i / columns;
                int column = i % columns;

                Paragraph paragraph = new Paragraph(document, barcodePicture);
                table.Rows[row].Cells[column].Blocks.Add(paragraph);
            }

            // Add the table to the document
            section.Blocks.Add(table);


            string filePath = "D:\\Matheus\\Trabalho 2\\Barcode\\barcodes.docx";
            document.Save(filePath);

            if(MessageBox.Show("Arquivo gerado deseja abrir?", "Barcode", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Process.Start(filePath);
            }
        }
    }
}
