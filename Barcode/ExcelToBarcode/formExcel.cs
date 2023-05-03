using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Drawing.Imaging;
using A = DocumentFormat.OpenXml.Drawing;
using DW = DocumentFormat.OpenXml.Drawing.Wordprocessing;
using PIC = DocumentFormat.OpenXml.Drawing.Pictures;
using Microsoft.Office.Interop.Excel;
using Drawing = DocumentFormat.OpenXml.Wordprocessing.Drawing;
using Application = Microsoft.Office.Interop.Excel.Application;
using BarcodeLib;
using Font = System.Drawing.Font;
using Color = System.Drawing.Color;

namespace ExcelToBarcode
{
    public partial class formExcel : Form
    {
        public string pathInitial = "";
        public string pathDest = "";
        public formExcel()
        {
            InitializeComponent();

            //ComponentInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            if (ofd.FileName != "")
            {
                pathInitial = ofd.FileName;
            }
            else
            {
                pathInitial = "";
            }

            txtFileSource.Text = pathInitial;
        }
        private void btnSelectDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            if (fbd.SelectedPath.ToString() != "")
            {
                pathDest = fbd.SelectedPath.ToString();
            }
            else
            {
                pathDest = "";
            }

            txtFileDestiny.Text = pathDest;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string filedestiny = txtFileDestiny.Text;
            string fileorigin = txtFileSource.Text;

            if (fileorigin != "")
            {
                if (!File.Exists(fileorigin))
                {
                    MessageBox.Show("Erro na leitura do arquivo selecionado.");
                    return;
                }
            }

            if (filedestiny != "")
            {
                if (!Directory.Exists(filedestiny))
                {
                    Directory.CreateDirectory(filedestiny);
                }
            }
            else
            {
                MessageBox.Show("Selecionar um diretório de destino.");
                return;
            }

            List<Produto> listProdutos = new List<Produto>();


            // Open Excel application and workbook
            Application excel = new Application();
            Workbook workbook = excel.Workbooks.Open(fileorigin);

            // Select the worksheet you want to read data from
            Worksheet worksheet = (Worksheet)workbook.Worksheets["Planilha1"];

            // Get the range of data in columns A and B
            Range range = worksheet.UsedRange.Columns["A:B"];

            // Iterate through each cell in the column and print its value
            foreach (Range row in range.Rows)
            {
                Produto prod = new Produto();
                prod.codigo = row.Cells[1,1].Value2.ToString();
                prod.descricao = row.Cells[1,2].Value2.ToString();

                listProdutos.Add(prod);
            }

            // Close workbook and Excel application
            workbook.Close();
            excel.Quit();
        
            string result = ProcessDocument(filedestiny + "\\barcorde.docx", listProdutos);

            if (File.Exists(result))
            {
                if (MessageBox.Show("Arquivo gerado deseja abrir?", "Barcode", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Process.Start(result);
                }
            }
            else
            {
                MessageBox.Show("Error ao gerar arquivo" + Environment.NewLine + result, "Barcode", MessageBoxButtons.OK);
            }
        }

        public string ProcessDocument(string file, List<Produto> listProdutos)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(file, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Set up three columns and adjust the bottom margin
                SectionProperties sectionProperties = new SectionProperties();
                
                PageSize pageSize = new PageSize() { Width = (UInt32Value)12240U, Height = (UInt32Value)15840U }; // Page size (in twips)
                PageMargin pageMargin = new PageMargin() { Top = 1440,
                    Right = (UInt32Value)720U, 
                    Bottom = 780,
                    Left = (UInt32Value)720U, 
                    Header = (UInt32Value)720U, 
                    Footer = (UInt32Value)720U, 
                    Gutter = (UInt32Value)0U }; // Page margins (in twips)

                sectionProperties.Append(pageSize);
                sectionProperties.Append(pageMargin);
                
                body.Append(sectionProperties);

                // Set the number of columns
                int columns = 4;

                // Calculate the number of rows needed
                int rows = (int)Math.Ceiling((double)listProdutos.Count / columns);

                int prods = 0;
                // Create a table with the specified number of rows and columns
                Table table = new Table();

                //Table table = new Table(new TableProperties(
                //    new marg,
                //    new TableWidth() { Type = TableWidthUnitValues.Pct, Width = "100" },
                //    new TableLayout() { Type = TableLayoutValues.Fixed }));

                for (int i = 0; i < rows; i++)
                {
                    TableRow row = new TableRow();
                    for (int j = 0; j < columns; j++)
                    {
                        TableCell cell = new TableCell(
                            new TableCellProperties(new TableCellWidth() { Type = TableWidthUnitValues.Auto }));

                        // Set the margins for the cell
                        TableCellMargin margin = new TableCellMargin();
                        margin.TopMargin = new TopMargin() { Width = "0.1in" };
                        margin.BottomMargin = new BottomMargin() { Width = "0.2in" };
                        margin.LeftMargin = new LeftMargin() { Width = "0.3in" };
                        margin.RightMargin = new RightMargin() { Width = "0.3in" };

                        cell.Append(new TableCellProperties(margin));

                        Paragraph paragraph = new Paragraph();
                        Run run = new Run();
                        paragraph.Append(run);

                        Produto prod = listProdutos[prods];
                        DW.Inline inline = DrawInlineObject(mainPart, prod);

                        run.Append(new Drawing(inline));

                        Run line = new Run(new Break());
                        paragraph.Append(line);

                        Run runtext = new Run(new Text(prod.descricao.ToUpper()));
                        runtext.RunProperties = new RunProperties(
                            new RunFonts() { Ascii = "Arial" },
                            new FontSize() { Val = "14" },
                            new Justification() { Val = JustificationValues.Left });

                        paragraph.Append(runtext);

                        prods++;

                        row.Append(cell);
                        cell.Append(paragraph);
                    }
                    table.Append(row);
                }
                // Add the table to the body of the document
                body.Append(table);
                mainPart.Document.Save();
            }

            return file;
        }

        public DW.Inline DrawInlineObject(MainDocumentPart mainPart, Produto prod)
        {
            string barcodeValue = prod.codigo ;
            string description = prod.descricao;

            Barcode b = new Barcode();
            Image barcodeImage = b.Encode(BarcodeLib.TYPE.CODE128, barcodeValue, Color.Black, Color.White, 300, 100);

            Graphics graphics = Graphics.FromImage(barcodeImage);
            graphics.DrawString(description, new Font("Arial", 10), Brushes.Black, new PointF(0, 100));

            MemoryStream stream = new MemoryStream();
            barcodeImage.Save(stream, ImageFormat.Png);
            byte[] imageBytes = stream.ToArray();

            ImagePart imagePart = mainPart.AddImagePart(ImagePartType.Jpeg);
            stream.Position = 0;
            imagePart.FeedData(stream);

            string imageId = mainPart.GetIdOfPart(imagePart);

            DW.Inline inline = new DW.Inline(
                new DW.Extent() { Cx = 990000L, Cy = 792000L },
                new DW.EffectExtent() { LeftEdge = 0L, TopEdge = 0L, RightEdge = 0L, BottomEdge = 0L },
                new DW.DocProperties() { Id = (UInt32Value)1U, Name = "Picture 1" },
                new DW.NonVisualGraphicFrameDrawingProperties(new A.GraphicFrameLocks() { NoChangeAspect = true }),
                new A.Graphic(new A.GraphicData(new PIC.Picture(
                    new PIC.NonVisualPictureProperties(
                        new PIC.NonVisualDrawingProperties() { Id = (UInt32Value)0U, Name = "New Bitmap Image.jpg" },
                        new PIC.NonVisualPictureDrawingProperties()),
                    new PIC.BlipFill(
                        new A.Blip(new A.BlipExtensionList(new A.BlipExtension() { Uri = "{28A0092B-C50C-407E-A947-70E740481C1C}" })) { Embed = imageId, CompressionState = A.BlipCompressionValues.Print },
                        new A.Stretch(new A.FillRectangle())),
                    new PIC.ShapeProperties(
                        new A.Transform2D(new A.Offset() { X = 0L, Y = 0L },
                            new A.Extents() { Cx = 990000L, Cy = 792000L }),
                        new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle }))
                )
                { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" })
            );


            return inline;
        }
        public class Produto
        {
            public string codigo { get; set; }
            public string descricao { get; set; }
        }
    }
}
