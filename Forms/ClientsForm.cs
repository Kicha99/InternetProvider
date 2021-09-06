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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void LoadData() 
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Clients;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClientForm form = new NewClientForm();
            if (form.ShowDialog() == DialogResult.OK)
                LoadData();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) 
            {
                Client client = dataGridView1.SelectedRows[0].DataBoundItem as Client;

                NewClientForm form = new NewClientForm(client);
                if (form.ShowDialog() == DialogResult.OK)
                    LoadData();
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) 
            {
                Client client = dataGridView1.SelectedRows[0].DataBoundItem as Client;

                if (MessageBox.Show("Вы действительно желаете удалить выделенный объект?", 
                    "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (DBController.Instance.Requests.Any(t => t.Client == client))
                    {
                        MessageBox.Show("Нельзя удалить клиента, так как он уже используется");
                        return;
                    }

                    DBController.Instance.Remove(client);
                    LoadData();
                }
            }
        }
    }
}
