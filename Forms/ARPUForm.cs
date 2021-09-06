using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetProvider.Forms
{
    public partial class ARPUForm : Form
    { 
        public ARPUForm()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            decimal result = ProgramHelper.ARPUCounter(monthCalendar1.SelectionStart.Date);

            txtBxResult.Text = "ARPU = " + result.ToString("c");
        }
    }
}
