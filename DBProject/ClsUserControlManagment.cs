using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;
namespace DBProject
{
    internal class ClsUserControlManagment
    {
        static private Panel _Panel;

        public static void Initialize(Panel panel)
        {
            _Panel = panel ?? throw new ArgumentNullException(nameof(panel), "Panel cannot be null!");
        }

        public static void ShowUserControl(UserControl control)
        {
            if (_Panel == null)
                throw new InvalidOperationException("Manager not initialized!");

            if (control == null)
                throw new ArgumentNullException(nameof(control), "UserControl cannot be null!");

            // تنظيف الحاوية أولاً
            _Panel.Controls.Clear();

            // ضبط خصائص اليوزر كنترول
            control.Dock = DockStyle.Fill;
            _Panel.Controls.Add(control);
        }
    }
}
