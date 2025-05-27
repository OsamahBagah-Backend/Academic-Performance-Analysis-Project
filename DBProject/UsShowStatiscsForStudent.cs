using System.Data;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DBProject
{
    public partial class UsShowStatiscsForStudent : UserControl
    {
        string _StudentName { get; set; }
        string _SemesterName { get; set; }
        int _SemesterYear { get; set; }
        string _LevelName { get; set; }
        string _DepartmentName { get; set; }
        DataTable _Subjectsdt { get; set; }
        int _HisOrder { get; set; } 
        int _HisPercentage { get; set; }
        int? lastPointIndex = null;

        public UsShowStatiscsForStudent(string StudentName , string SemesterName , int SemesterYear , string LevelName , string DepartmentName)
        {
            InitializeComponent();
            _StudentName = StudentName;
            _SemesterName = SemesterName;
            _SemesterYear = SemesterYear;
            _LevelName = LevelName;
            _DepartmentName = DepartmentName;
        }

        void MakeTheValuesForControls ()
        {
            lbStudentName.Text = _StudentName;
            lbSemester.Text = _SemesterName;
            lbYear.Text = _SemesterYear.ToString();
            lbLevel.Text = _LevelName;
            lbDepartment.Text = _DepartmentName;

            sataCircularProgress1.percentage = _HisPercentage;
            lbOrder.Text = _HisOrder.ToString();


            /*chart1.Series.Clear();*/ // ننظف أي بيانات سابقة

            // ممكن تغيرها لـ Pie أو Line حسب رغبتك

            int i = 0;
            foreach (DataRow row in _Subjectsdt.Rows)
            {
                string subject = row["Name"].ToString();
                int grade = Convert.ToInt32(row["Grade"]);
                int FinalGrade = Convert.ToInt32(row["FinalGrade"]);
                string Status = row["Status"].ToString();

                chart1.Series[0].Points.AddXY(subject, grade);
                chart1.Series[0].Points[i].Tag = $"الدرجة النهائية: {FinalGrade}\nحالة الطالب: {Status}\nالعلامات المنتقصة: {row["MinesMarks"]}";
                i++;
            }

            // نضيف السلسلة للتشارت

        }

        private void UsShowStatiscsForStudent_Load(object sender, EventArgs e)
        {
            int HisOrder = 0;
            int HisPercentage = 0;
            DataTable Subjectsdt = null;

            ClsDataAccessForProject.StudentStatsics(_StudentName, _SemesterName, _SemesterYear, _LevelName, _DepartmentName, ref HisOrder, ref HisPercentage, ref Subjectsdt);

            _HisOrder = HisOrder;
            _HisPercentage = HisPercentage;
            _Subjectsdt = Subjectsdt;

            MakeTheValuesForControls();
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
    }
}
