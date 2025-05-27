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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChangeTheSliderButtonColorAndBackGround(Guna.UI2.WinForms.Guna2Button btn)
        {
            foreach (Guna.UI2.WinForms.Guna2Button c in pnSlideBar.Controls)
            {
                if (btn == c)
                {
                    c.FillColor = Color.White;
                    c.ForeColor = Color.FromArgb(20, 40, 70);
                }

                else
                {
                    c.FillColor = Color.FromArgb(20, 40, 70);
                    c.ForeColor = Color.White;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ClsUserControlManagment.Initialize(pnContainAllUserControls);
            ClsUserControlManagment.ShowUserControl(new UsEnterMarkes());
            ChangeTheSliderButtonColorAndBackGround(btnMarksManagment);
        }

        private void btnStudentStatistics_Click(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UstudentStatistics());
            ChangeTheSliderButtonColorAndBackGround(btnStudentStatistics);

        }

        private void btnMarksManagment_Click(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsEnterMarkes());
            ChangeTheSliderButtonColorAndBackGround(btnMarksManagment);
        }

        private void btnBatchStatistics_Click(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsBatchStatiSticsInfo());
            //ClsUserControlManagment.ShowUserControl(new UsCompareMaleAndFamaleStatistics());
            ChangeTheSliderButtonColorAndBackGround(btnBatchStatistics);
        }

        private void btnMarksManagment_Click_1(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsEnterMarkes());
            ChangeTheSliderButtonColorAndBackGround(btnMarksManagment);
        }

        private void btnStudentStatistics_Click_1(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UstudentStatistics());
            ChangeTheSliderButtonColorAndBackGround(btnStudentStatistics);
        }

        private void btnBatchStatistics_Click_1(object sender, EventArgs e)
        {
            ClsUserControlManagment.ShowUserControl(new UsBatchStatiSticsInfo());
            //ClsUserControlManagment.ShowUserControl(new UsCompareMaleAndFamaleStatistics());
            ChangeTheSliderButtonColorAndBackGround(btnBatchStatistics);
        }
    }
}
