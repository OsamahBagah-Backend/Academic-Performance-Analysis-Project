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
    public partial class FrmStudentStatistics : Form
    {
        public FrmStudentStatistics()
        {
            InitializeComponent();
        }

        private void FrmStudentStatistics_Load(object sender, EventArgs e)
        {
            this.Size = new Size(450, 520);
        }
    }
}
