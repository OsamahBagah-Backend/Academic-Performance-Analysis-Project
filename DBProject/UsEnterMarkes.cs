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
    public partial class UsEnterMarkes : UserControl
    {
        DataTable Table = new DataTable();
        int StudentID;
        int SubjectID;
        int SemeterID;
        int LevelID;

        public UsEnterMarkes()
        {
            InitializeComponent();
        }

        bool CheckFromControlsIFFillItOrNot()
        {
            return txtStudentName.Text == "" || txtGrade.Text == "" || cmbSemster.Text.ToString() == "" || cmbSubjects.Text.ToString() == "" || cmbYearStudy.Text.ToString() == "";
        }

        void MakeBtnSaveEnabledFalseOrTrue()
        {
            if (CheckFromControlsIFFillItOrNot())
            {
                btnSave.Enabled = false;
            }

            else
            {
                btnSave.Enabled = true;
            }
        }

        void FillLocalVaribles()
        {
            StudentID = ClsDataAccessForProject.GetStudentID(txtStudentName.Text);
            SubjectID = ClsDataAccessForProject.GetSubjectsID(cmbSubjects.SelectedItem.ToString());
            SemeterID = ClsDataAccessForProject.GetSemesterID(cmbSemster.SelectedItem.ToString(),Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()));
            LevelID = ClsDataAccessForProject.GetLevelID(cmbLevels.SelectedItem.ToString().ToUpper());
        }

        void LoadDataToSubjectsCombobox()
        {
            Table = ClsDataAccessForProject.LoadAllSubjects(cmbMajors.SelectedItem.ToString(),cmbLevels.SelectedItem.ToString() ,cmbPeriods.SelectedItem.ToString());

            foreach (DataRow dr in Table.Rows)
            {
                cmbSubjects.Items.Add(dr["Name"]);
            }
        }

        void CheckFromPnInformation()
        {
            if (cmbLevels.Text == "" || cmbMajors.Text == "" || cmbPeriods.Text == "")
            {
                pnMarkInformation.Enabled = false;
                btnSave.Enabled = false;
            }

            else
            {
                pnMarkInformation.Enabled = true;
                pnAcademic.Enabled = false;
                LoadDataToSubjectsCombobox();
                FillTextStudentWithNames();
            }
        }

        void FillTextStudentWithNames()
        {
            AutoCompleteStringCollection autoCompleate = new AutoCompleteStringCollection();

            ClsDataAccessForProject.GetStudentsNamesForTextBoxe(ref autoCompleate);

            txtStudentName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtStudentName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtStudentName.AutoCompleteCustomSource = autoCompleate;
        }

        bool CheckFromGrade()
        {
            foreach(DataRow dr in Table.Rows)
            {
                if ((string)dr["Name"] == cmbSubjects.SelectedItem.ToString())
                {
                    if (dr["FinalGrade"] != DBNull.Value && float.TryParse(dr["FinalGrade"].ToString(),out float Grade))
                    {
                        if (Grade < Convert.ToInt32(txtGrade.Text) || Convert.ToInt32(txtGrade.Text) < 0)
                        {
                            MessageBox.Show("Please Enter Coreect Grade", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private void UsEnterMarkes_Load(object sender, EventArgs e)
        {
            CheckFromPnInformation();
        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            MakeBtnSaveEnabledFalseOrTrue();
        }

        private void cmbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeBtnSaveEnabledFalseOrTrue();
        }

        string MakeTheGradeStatus()
        {
            string Status = "";

            foreach (DataRow dr in Table.Rows)
            {
                if ((string)dr["Name"] == cmbSubjects.SelectedItem.ToString())
                {
                    if (dr["FinalGrade"] != DBNull.Value && float.TryParse(dr["FinalGrade"].ToString(), out float Grade))
                    {
                        if (Grade - 10 < Convert.ToInt32(txtGrade.Text))
                        {
                            Status =  "ممتاز";
                            break;
                        }

                        if (Grade - 20 < Convert.ToInt32(txtGrade.Text))
                        {
                            Status = "جيد جيدا";
                            break;
                        }

                        if (Grade - 30 < Convert.ToInt32(txtGrade.Text))
                        {
                            Status = "جيد";
                            break;
                        }

                        if (Grade - 40 < Convert.ToInt32(txtGrade.Text))
                        {
                            Status = "مقبول";
                            break;
                        }

                        else
                        {
                            Status = "ضعيف";
                            break;
                        }
                    }
                }
            }

            return Status;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ClsDataAccessForProject.CheckFromStudentNameIfThereOrNot(txtStudentName.Text))
            {
                MessageBox.Show("this student is not in our database", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(CheckFromGrade())
            {
                txtGrade.Clear();
                return;
            }

            FillLocalVaribles();

            if(ClsDataAccessForProject.CheckFromThisRecordIfAlreadtEntring(StudentID,SubjectID))
            {
                MessageBox.Show("You Alraedy Enter this Grade For the Same Student And Same Subject", "wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string GradeStatus = MakeTheGradeStatus();

            if (ClsDataAccessForProject.AddMarksForStudent(StudentID, SubjectID, SemeterID, Convert.ToInt32(txtGrade.Text), GradeStatus , LevelID) != -1)
            {
                MessageBox.Show("Added Successsfuly");
            }

            else
            {
                MessageBox.Show("Added Wrong");
            }
        }

        private void cmbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckFromPnInformation();
        }

        private void txtGrade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MakeBtnSaveEnabledFalseOrTrue();
        }
    }
}
