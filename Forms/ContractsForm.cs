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
    public partial class ContractsForm : Form
    {
        public ContractsForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = null;

            if (ApplicationHelper.Instance.CurrentRole == Model.Role.Admin)
            {
                dataGridView1.DataSource = DBController.Instance.Contracts;
                менюToolStripMenuItem1.Visible = false;
            }
            else
            {
                менюToolStripMenuItem.Visible = false;
                dataGridView1.DataSource = DBController.Instance.Contracts.
                    Where(t => t.Client == ApplicationHelper.Instance.CurrentUser).ToList();
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewContractForm form = new NewContractForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void ContractsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRequestForm form = new NewRequestForm();
            form.ShowDialog();
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RequestsForm form = new RequestsForm();
            form.ShowDialog();
        }

        private void тарифыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TariffsForm form = new TariffsForm();
            form.ShowDialog();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                Contract contract = dataGridView1.SelectedRows[0].DataBoundItem as Contract;

                NewContractForm form = new NewContractForm(contract);
                form.ShowDialog();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Contract contract = dataGridView1.SelectedRows[0].DataBoundItem as Contract;

                NewContractForm form = new NewContractForm(contract);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }
    }
}
