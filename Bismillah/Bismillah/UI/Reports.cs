using Bismillah.BL;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Bismillah.UI
{
    public partial class Reports : Form
    {
        private readonly ReportsBL reportsBL;

        public Reports()
        {
            InitializeComponent();
            reportsBL = new ReportsBL();
            InitializeReportComboBox();
        }

        private void InitializeReportComboBox()
        {
            cmbreport.Items.Clear();
            cmbreport.Items.AddRange(reportsBL.GetAvailableReportTypes());
            cmbreport.SelectedIndex = 0;
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgreport.DataSource == null || dvgreport.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Excel File",
                    FileName = $"{cmbreport.SelectedItem}_Report_{DateTime.Now:yyyyMMdd}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel((DataTable)dvgreport.DataSource, saveFileDialog.FileName);
                    MessageBox.Show("Data exported to Excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(DataTable dataTable, string filePath)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add(dataTable, "Report");

                // Style the header row
                var headerRow = worksheet.Row(1);
                headerRow.Style.Font.Bold = true;
                headerRow.Style.Fill.BackgroundColor = XLColor.FromArgb(10, 35, 66);
                headerRow.Style.Font.FontColor = XLColor.White;

                // Auto-adjust columns to content
                worksheet.Columns().AdjustToContents();

                workbook.SaveAs(filePath);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgreport.DataSource == null || dvgreport.Rows.Count == 0)
                {
                    MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF Files|*.pdf",
                    Title = "Save PDF File",
                    FileName = $"{cmbreport.SelectedItem}_Report_{DateTime.Now:yyyyMMdd}.pdf"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF((DataTable)dvgreport.DataSource, saveFileDialog.FileName);
                    MessageBox.Show("Data exported to PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPDF(DataTable dataTable, string filePath)
        {
            // Use fully qualified names to avoid ambiguity
            iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
            iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(
                document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Add title
            iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont(
                iTextSharp.text.FontFactory.HELVETICA_BOLD, 16, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Paragraph title = new iTextSharp.text.Paragraph(
                $"{cmbreport.SelectedItem} Report", titleFont);
            title.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            document.Add(title);

            // Add date
            iTextSharp.text.Font dateFont = iTextSharp.text.FontFactory.GetFont(
                iTextSharp.text.FontFactory.HELVETICA, 10, iTextSharp.text.BaseColor.BLACK);
            iTextSharp.text.Paragraph date = new iTextSharp.text.Paragraph(
                $"Generated on: {DateTime.Now:yyyy-MM-dd HH:mm}", dateFont);
            date.Alignment = iTextSharp.text.Element.ALIGN_RIGHT;
            date.SpacingAfter = 15f;
            document.Add(date);

            // Create PDF table
            iTextSharp.text.pdf.PdfPTable pdfTable = new iTextSharp.text.pdf.PdfPTable(dataTable.Columns.Count);
            pdfTable.WidthPercentage = 100;
            pdfTable.SpacingBefore = 10f;
            pdfTable.SpacingAfter = 10f;

            // Set column widths
            float[] columnWidths = new float[dataTable.Columns.Count];
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                columnWidths[i] = 4f; // Adjust as needed
            }
            pdfTable.SetWidths(columnWidths);

            // Add headers
            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont(
                iTextSharp.text.FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.WHITE);
            foreach (DataColumn column in dataTable.Columns)
            {
                iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(
                    new iTextSharp.text.Phrase(column.ColumnName, headerFont));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(10, 35, 66);
                cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                cell.Padding = 5;
                pdfTable.AddCell(cell);
            }

            // Add data rows
            iTextSharp.text.Font dataFont = iTextSharp.text.FontFactory.GetFont(
                iTextSharp.text.FontFactory.HELVETICA, 9, iTextSharp.text.BaseColor.BLACK);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(
                        new iTextSharp.text.Phrase(row[column].ToString(), dataFont));
                    cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                    cell.Padding = 5;
                    pdfTable.AddCell(cell);
                }
            }

            document.Add(pdfTable);
            document.Close();
        }
        private void cmbreport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedReport = cmbreport.SelectedItem.ToString();
                DataTable reportData = reportsBL.GenerateReport(selectedReport);
                dvgreport.DataSource = reportData;
                dvgreport.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            cmbreport_SelectedIndexChanged(sender, e);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AdminDashboard addStaff = new AdminDashboard();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }
    }
}