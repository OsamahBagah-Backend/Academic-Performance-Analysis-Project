using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class UsBatchStatistics : UserControl
    {
        string _SemesterName { get; set; }
        int _SemesterYear { get; set; }
        string _LevelName { get; set; }
        string _Department { get; set; }
        int _BatchFinalGrade { get; set; }
        int _HonorPercentage { get; set; }
        int _StudentMaleCount { get; set; }
        int _StudentFamaleCount { get; set; }
        DataTable _SuccessSubjectsdt { get; set; }
        DataTable _FaildSubjectsdt { get; set; }
        DataTable _Top10Students { get; set; }

        public UsBatchStatistics(string SemesterName , int SemesterYear, string LevelName, string Department)
        {
            InitializeComponent();
            _SemesterName = SemesterName;
            _SemesterYear = SemesterYear;
            _LevelName = LevelName;
            _Department = Department;
        }

        void MakeSuccessSubjectsChart()
        {
            foreach (DataRow row in _SuccessSubjectsdt.Rows)
            {
                string subject = row["Name"].ToString();
                int grade = Convert.ToInt32(row["Perc"]);

                SuccessChart.Series[0].Points.AddXY(subject, grade);
            }
        }

        void MakeFaildSubjectsChart()
        {
            foreach (DataRow row in _FaildSubjectsdt.Rows)
            {
                string subject = row["Name"].ToString();
                int grade = Convert.ToInt32(row["perc"]);

                FaildChart.Series[0].Points.AddXY(subject, grade);
            }
        }


        void ButTheValuesForControls()
        {
            lbMaleNumber.Text = _StudentMaleCount.ToString();
            lbFamaleNumber.Text = _StudentFamaleCount.ToString();
            HonorProgress.percentage = _HonorPercentage;
            FinalRate.percentage = _BatchFinalGrade;
            MakeSuccessSubjectsChart();
            MakeFaildSubjectsChart();

            dgvViolations.DataSource = _Top10Students;
            dgvViolations.Columns[1].Width = 250;
            dgvViolations.Columns[2].Width = 150;
            dgvViolations.Columns[0].Width = 130;

        }

        private void UsBatchStatistics_Load(object sender, EventArgs e)
        {
            int Grade = 0;
            int Honor = 0;
            int Male = 0;
            int Famale = 0;

            DataTable success = new DataTable();
            DataTable failed = new DataTable();
            DataTable top = new DataTable();

            ClsDataAccessForProject.TheBatchStatistics(_SemesterName, _SemesterYear, _LevelName, _Department,
                ref Grade, ref Honor, ref Male, ref Famale, ref success, ref failed, ref top);

            _BatchFinalGrade = Grade;
            _HonorPercentage = Honor;
            _StudentMaleCount = Male;
            _StudentFamaleCount = Famale;
            _SuccessSubjectsdt = success;
            _FaildSubjectsdt = failed;
            _Top10Students = top;

            ButTheValuesForControls();
        }
    }
}
