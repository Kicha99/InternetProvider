using InternetProvider.Model;
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
    public partial class AdminsForm : Form
    {
        public AdminsForm()
        {
            InitializeComponent();
        }

        private void LoadData() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Administrators;
        }
        private void AdminsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAdminForm form = new NewAdminForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                Administrator administrator = dataGridView1.SelectedRows[0].DataBoundItem as Administrator;

                NewAdminForm form = new NewAdminForm(administrator);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                Administrator administrator = dataGridView1.SelectedRows[0].DataBoundItem as Administrator;

                if (MessageBox.Show("Вы действительно желаете удалить выделенный объект?", 
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DBController.Instance.Remove(administrator);
                    LoadData();
                }
            }
        }
    }
}
