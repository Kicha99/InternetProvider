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
    public partial class AnswerForm : Form
    {
        public string Answer { get; private set; }

        public AnswerForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxAnswer.Text))
            {
                MessageBox.Show("Введите ответ клиенту!");
                return;
            }

            Answer = txtBxAnswer.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
