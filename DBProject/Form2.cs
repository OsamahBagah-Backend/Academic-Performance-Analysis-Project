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
using System.Windows.Forms.DataVisualization.Charting;

namespace DBProject
{
    public partial class Form2 : Form
    { DataTable dt = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        int? lastPointIndex = null;

        private void ExportDataTableWithArabic(DataTable dt, string filePath)
        {
            // تحميل الخط
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font arabicFont = new iTextSharp.text.Font(bf, 12);

            // إنشاء PDF
            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
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



        private void Form2_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add("اسم المادة");
            dt.Columns.Add("الدرجة", typeof(int));
            dt.Columns.Add("عدد الناجحين", typeof(int));

            dt.Rows.Add("رياضيات", 90,12);
            dt.Rows.Add("علوم", 80,14);
            dt.Rows.Add("تاريخ", 70,23);

            int i = 0;

            foreach (DataRow row in dt.Rows)
            {
                string subject = row["اسم المادة"].ToString();
                int grade = Convert.ToInt32(row["الدرجة"]);

                chart1.Series[0].Points.AddXY(subject, grade);
                chart1.Series[0].Points[i].Tag = $"المادة: {subject}\nالدرجة: {grade}\nعدد الناجحين: {row["عدد الناجحين"]}";

                i++;
            }

            dgvViolations.DataSource = dt;
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = result.PointIndex;
                var point = chart1.Series[0].Points[pointIndex];

                if (lastPointIndex != pointIndex)
                {
                    lastPointIndex = pointIndex;

                    if (point.Tag != null)
                    {
                        toolTip1.Show(point.Tag.ToString(), chart1, e.X + 15, e.Y + 15);
                    }
                }
            }
            else
            {
                toolTip1.Hide(chart1);
                lastPointIndex = null;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataTableWithArabic((DataTable)dgvViolations.DataSource, saveFileDialog.FileName);
            }
        }
    }
}
