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
    public partial class UsCompareMaleAndFamaleStatistics : UserControl
    {
        string _SemesterName { get; set; }
        int _SemesterYear { get; set; }
        string _LevelName { get; set; }
        string _Department { get; set; }
        int _BatchFinalGradeMale { get; set; }
        int _BatchFinalGradeFaMale { get; set; }
        int _HonorPercentageMale { get; set; }
        int _HonorPercentageFaMale { get; set; }
        int _StudentMaleCount { get; set; }
        int _StudentFamaleCount { get; set; }
        DataTable _SuccessSubjectsMaledt { get; set; }
        DataTable _SuccessSubjectsFaMaledt { get; set; }
        public UsCompareMaleAndFamaleStatistics(string SemesterName, int SemesterYear, string LevelName, string Department)
        {
            InitializeComponent();
            _SemesterName = SemesterName;
            _SemesterYear = SemesterYear;
            _LevelName = LevelName;
            _Department = Department;
        }

        void MakeSuccessSubjectsChartMale()
        {
            foreach (DataRow row in _SuccessSubjectsMaledt.Rows)
            {
                string subject = row["Name"].ToString();
                int grade = Convert.ToInt32(row["Perc"]);

                SuccessChartMale.Series[0].Points.AddXY(subject, grade);
            }
        }

        void MakeSuccessSubjectsChartFaMale()
        {
            foreach (DataRow row in _SuccessSubjectsFaMaledt.Rows)
            {
                string subject = row["Name"].ToString();
                int grade = Convert.ToInt32(row["Perc"]);

                SuccessChartFamale.Series[0].Points.AddXY(subject, grade);
            }
        }

        void MakeValueForControls()
        {
            lbMaleCount.Text = _StudentMaleCount.ToString();
            lbFamaleCount.Text = _StudentFamaleCount.ToString();
            FinalMaleProgress.percentage = _BatchFinalGradeMale;
            FinalFamaleProgress.percentage = _BatchFinalGradeFaMale;
            HonorMaleProgress.percentage = _HonorPercentageMale;
            HonorFamaleProgress.percentage = _HonorPercentageFaMale;

            MakeSuccessSubjectsChartFaMale();
            MakeSuccessSubjectsChartMale();
        }

        private void UsCompareMaleAndFamaleStatistics_Load(object sender, EventArgs e)
        {
            int GradeMale = 0;
            int GradeFaMale = 0;
            int HonorMale = 0;
            int HonorFaMale = 0;
            int MaleCount = 0;
            int FamaleCount = 0;

            DataTable successMale = new DataTable();
            DataTable successFamale = new DataTable();


            ClsDataAccessForProject.TheBatchStatisticsByGender(_SemesterName, _SemesterYear, _LevelName, _Department,
                ref GradeMale, ref GradeFaMale, ref HonorMale, ref HonorFaMale, ref MaleCount, ref FamaleCount, ref successMale, ref successFamale);

            _BatchFinalGradeMale = GradeMale;
            _BatchFinalGradeFaMale = GradeFaMale;
            _HonorPercentageMale = HonorMale;
            _HonorPercentageFaMale = HonorFaMale;
            _StudentMaleCount = MaleCount;
            _StudentFamaleCount = FamaleCount;
            _SuccessSubjectsMaledt = successMale;
            _SuccessSubjectsFaMaledt = successFamale;

            MakeValueForControls();
        }
    }
}
