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
    public partial class UstudentStatistics : UserControl
    {
        public UstudentStatistics()
        {
            InitializeComponent();
        }

        private void UstudentStatistics_Load(object sender, EventArgs e)
        {
            btnShow.Enabled = false;
            FillTextStudentWithNames();
        }

        bool CheckIfUserEnterDataToControlsOrNot()
        {
            return txtStudentName.Text == "" ||  cmbSemster.Text.ToString() == "" || cmbLevels.Text.ToString() == "" || cmbYearStudy.Text.ToString() == "" || cmbMajors.Text.ToString() == "";
        }

        void FillTextStudentWithNames()
        {
            AutoCompleteStringCollection autoCompleate = new AutoCompleteStringCollection();

            ClsDataAccessForProject.GetStudentsNamesForTextBoxe(ref autoCompleate);

            txtStudentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtStudentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStudentName.AutoCompleteCustomSource = autoCompleate;
        }

        void MakeBthShowEnabledWithTrueOrFalse()
        {
            if(CheckIfUserEnterDataToControlsOrNot())
            {
                btnShow.Enabled = false;
            }

            else
            {
                btnShow.Enabled = true;
            }
        }

        void FillCmbMajorsWithValue(int StudentID)
        {

            DataTable dt = ClsDataAccessForProject.GetDepartmentsForStudents(StudentID); 

            cmbMajors.Items.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                cmbMajors.Items.Add(dr["Name"]);
            }
        }

        void FillCmbSemestersWithValue(int StudentID)
        {
            DataTable dt = ClsDataAccessForProject.GetSemestersForStudents(StudentID);

            cmbSemster.Items.Clear();
            cmbYearStudy.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                cmbYearStudy.Items.Add(dr["year"]);
                cmbSemster.Items.Add(dr["Name"]);
            }
        }

        void FillCmbLevelsWithValue(int StudentID)
        {
            DataTable dt = ClsDataAccessForProject.GetLevelsForStudents(StudentID);

            cmbLevels.Items.Clear();

            foreach(DataRow dr in dt.Rows)
            {
                cmbLevels.Items.Add(dr["Name"]);
            }
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            int StudentID = ClsDataAccessForProject.GetStudentID(txtStudentName.Text);

            MakeBthShowEnabledWithTrueOrFalse();
            FillCmbMajorsWithValue(StudentID);
            FillCmbSemestersWithValue(StudentID);
            FillCmbLevelsWithValue(StudentID);
        }

        private void cmbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeBthShowEnabledWithTrueOrFalse();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsShowStatiscsForStudent(txtStudentName.Text,cmbSemster.SelectedItem.ToString(),Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()),cmbLevels.SelectedItem.ToString(),cmbMajors.SelectedItem.ToString()));
        }
    }
}
