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
    public partial class UsBatchStatiSticsInfo : UserControl
    {
        public UsBatchStatiSticsInfo()
        {
            InitializeComponent();
        }

        bool CheckIfUserEnterDataToControlsOrNot()
        {
            return  cmbSemster.Text.ToString() == "" || cmbLevels.Text.ToString() == "" || cmbYearStudy.Text.ToString() == "" || cmbMajors.Text.ToString() == "" || cmbKind.Text.ToString() == "";
        }

        void MakeBthShowEnabledWithTrueOrFalse()
        {
            if (CheckIfUserEnterDataToControlsOrNot())
            {
                btnShow.Enabled = false;
            }

            else
            {
                btnShow.Enabled = true;
            }
        }

        private void UsBatchStatiSticsInfo_Load(object sender, EventArgs e)
        {
            btnShow.Enabled = false;
        }

        private void cmbMajors_SelectedIndexChanged(object sender, EventArgs e)
        {
            MakeBthShowEnabledWithTrueOrFalse();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if(!ClsDataAccessForProject.CheckFromBatchSataisics(cmbSemster.SelectedItem.ToString(),
               Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()),cmbLevels.SelectedItem.ToString(),cmbMajors.SelectedItem.ToString()))
            {
                MessageBox.Show("لا يوجد درجات كافيه لهذه الدفعه", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if(cmbKind.SelectedIndex == 0)
                {
                    ClsUserControlManagment.ShowUserControl(new UsBatchStatistics(cmbSemster.SelectedItem.ToString(),
                   Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()), cmbLevels.SelectedItem.ToString(), cmbMajors.SelectedItem.ToString()));
                }

                else if(cmbKind.SelectedIndex == 1)
                {
                    ClsUserControlManagment.ShowUserControl(new UsCompareMaleAndFamaleStatistics(cmbSemster.SelectedItem.ToString(),
                   Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()), cmbLevels.SelectedItem.ToString(), cmbMajors.SelectedItem.ToString()));
                }

                else
                {
                    ClsUserControlManagment.ShowUserControl(new UsFinal_payment_statement(cmbSemster.SelectedItem.ToString(),
                   Convert.ToInt32(cmbYearStudy.SelectedItem.ToString()), cmbLevels.SelectedItem.ToString(), cmbMajors.SelectedItem.ToString()));
                }
            }
        }
    }
}
