using iTextSharp.text;
using iTextSharp.text.pdf;
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

namespace DBProject
{
    public partial class UsFinal_payment_statement : UserControl
    {
        DataTable dt = new DataTable();
        string _SemesterName { get; set; }
        int _SemesterYear { get; set; }
        string _LevelName { get; set; }
        string _Department { get; set; }
        public UsFinal_payment_statement(string SemesterName, int SemesterYear, string LevelName, string Department)
        {
            InitializeComponent();
            _SemesterName = SemesterName;
            _SemesterYear = SemesterYear;
            _LevelName = LevelName;
            _Department = Department;
        }

        private void ExportDataTableWithArabic(DataTable dt, string filePath)
        {
            // تحميل الخط
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(bf, 12);

            // إنشاء PDF
            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4, 10f, 10f, 10f, 10f);
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));
            pdfDoc.Open();

            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            table.WidthPercentage = 100;

            // عناوين الأعمدة
            foreach (DataColumn column in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName, arabicFont));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // البيانات
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    PdfPCell dataCell = new PdfPCell(new Phrase(item?.ToString() ?? "", arabicFont));
                    dataCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    table.AddCell(dataCell);
                }
            }

            pdfDoc.Add(table);
            pdfDoc.Close();
            MessageBox.Show("✅ PDF تم حفظه بنجاح!");
        }

        private void ScrollToRightMostColumn()
        {
            if (dgvViolations.Columns.Count > 0)
            {
                int lastColumnIndex = dgvViolations.Columns.Count - 1;
                dgvViolations.FirstDisplayedScrollingColumnIndex = lastColumnIndex;

                // أو استخدم:
                dgvViolations.Columns[lastColumnIndex].Visible = true; // تأكد من أن العمود مرئي
                dgvViolations.Columns[lastColumnIndex].Selected = true; // (اختياري) تحديد العمود
            }
        }

        private void UsFinal_payment_statement_Load(object sender, EventArgs e)
        {
            dt = ClsDataAccessForProject.GetFinalPaymentStatement(_SemesterName, _SemesterYear, _LevelName, _Department);

            dgvViolations.DataSource = dt;
            ScrollToRightMostColumn();
            dgvViolations.Columns[1].Width = 250;
            dgvViolations.Columns[2].Width = 200;
            dgvViolations.Columns[3].Width = 200;
            dgvViolations.Columns[4].Width = 200;
            dgvViolations.Columns[5].Width = 200;
            dgvViolations.Columns[6].Width = 200;
            dgvViolations.Columns[7].Width = 200;
            dgvViolations.Columns[8].Width = 200;
        }

        private void btnPrintRepoert_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataTableWithArabic((DataTable)dgvViolations.DataSource, saveFileDialog.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsBatchStatiSticsInfo());
        }
    }
}
