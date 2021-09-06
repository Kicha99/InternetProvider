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
    public partial class RequestsForm : Form
    {
        public RequestsForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dataGridView1.DataSource = null;

            if (ApplicationHelper.Instance.CurrentRole == Model.Role.Client)
            {
                действияToolStripMenuItem.Visible = false;
                добавитьToolStripMenuItem.Visible = false;
                dataGridView1.DataSource = DBController.Instance.GetRequests((Client)ApplicationHelper.Instance.CurrentUser);
            }
            else
            {
                int index = toolStripComboBoxStatus.SelectedIndex;

                if (index == 0)
                    dataGridView1.DataSource = DBController.Instance.Requests;
                else if (index == 1)
                    dataGridView1.DataSource = DBController.Instance.GetNewRequests();
                else
                    dataGridView1.DataSource = DBController.Instance.GetProcessRequests();
            }
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            toolStripComboBoxStatus.Visible = ApplicationHelper.Instance.CurrentRole == Role.Admin;
            toolStripComboBoxStatus.SelectedIndex = 0;
        }

        private void отклонитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Request request = dataGridView1.SelectedRows[0].DataBoundItem as Request;
                if (request.Status == RequestStatus.Accept)
                {
                    MessageBox.Show("Нельзя отклонить одобренную заявку");
                }
                else
                {
                    request.Status = RequestStatus.Discard;

                    AnswerForm form = new AnswerForm();
                    form.ShowDialog();

                    request.Answer = form.Answer;

                    DBController.Instance.Update(request);
                    LoadData();
                }
            }
        }

        private void одобритьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Request request = dataGridView1.SelectedRows[0].DataBoundItem as Request;
                if (request.Status != RequestStatus.Accept)
                {
                    request.Status = RequestStatus.Accept;
                    request.Answer = "Заявка одобрена";

                    if (request.Contract == null)
                    {
                        Contract contract = new Contract()
                        {
                            Address = request.Address,
                            Client = request.Client,
                            Date = DateTime.Now,
                            Number = request.Number,
                            Request = request,
                            Tariff = request.Tariff,
                            TypeStatus = ContractStatus.Active
                        };
                        DBController.Instance.Update(contract);
                        LoadData();
                    }
                }
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Request request = dataGridView1.SelectedRows[0].DataBoundItem as Request;

                if (request.Status == RequestStatus.Accept)
                    MessageBox.Show("Одобренную заявку нельзя редактировать");
                else
                {
                    NewRequestForm form = new NewRequestForm(request);
                    if (form.ShowDialog() == DialogResult.OK)
                        LoadData();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Вы действительно желаете удалить выделенный объект?",
                   "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Request request = dataGridView1.SelectedRows[0].DataBoundItem as Request;

                    if (request.Status != RequestStatus.New)
                        MessageBox.Show("Обработанную заявку нельзя удалить");
                    else
                    {
                        DBController.Instance.Remove(request);
                        LoadData();
                    }
                }
            }
        }

        private void toolStripComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "StatusColumn")
            {
                RequestStatus enumValue = (RequestStatus)e.Value;
                string enumString;
                if (enumValue == RequestStatus.New)
                    enumString = "Новая";
                else if (enumValue == RequestStatus.Accept)
                    enumString = "Одобренная";
                else
                    enumString = "Отклоненная";

                e.Value = enumString;
            }
        }
    }
}
