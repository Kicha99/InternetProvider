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
    public partial class TariffsForm : Form
    {
        public TariffsForm()
        {
            InitializeComponent();
        }

        private void TariffsForm_Load(object sender, EventArgs e)
        {
            LoadData();

            toolStripCmbBxStatusFilter.SelectedIndex = 0;

            менюToolStripMenuItem.Visible = ApplicationHelper.Instance.CurrentRole == Role.Admin;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Tariffs;
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTariffForm form = new NewTariffForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Tariff tariff = (Tariff)dataGridView1.SelectedRows[0].DataBoundItem;

                NewTariffForm form = new NewTariffForm(tariff);
                if (form.ShowDialog() == DialogResult.OK)
                {
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
                    Tariff tariff = (Tariff)dataGridView1.SelectedRows[0].DataBoundItem;

                    if (DBController.Instance.Requests.Any(t => t.Tariff == tariff))
                    {
                        MessageBox.Show("Нельзя удалить тариф, так как он уже используется");
                        return;
                    }

                    DBController.Instance.Remove(tariff);
                    LoadData();
                }
            }
        }

        private void toolStripCmbBxStatusFilter_Click(object sender, EventArgs e)
        {

        }

        private void toolStripCmbBxStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            if (toolStripCmbBxStatusFilter.SelectedIndex == 0)
                LoadData();
            else if (toolStripCmbBxStatusFilter.SelectedIndex == 1)
            {
                dataGridView1.DataSource = DBController.Instance.Tariffs
                    .Where(t=>t.Status == TariffStatus.Active || t.Status == TariffStatus.New).ToList();
            }
            else
            {
                dataGridView1.DataSource = DBController.Instance.Tariffs
                    .Where(t => t.Status == TariffStatus.Archive).ToList();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "StatusColumn")
            {
                TariffStatus enumValue = (TariffStatus)e.Value;
                string enumString;
                if (enumValue == TariffStatus.Active)
                    enumString = "Активный";
                else if (enumValue == TariffStatus.Archive)
                    enumString = "Архивный";
                else
                    enumString = "Новый";

                e.Value = enumString;
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.ColumnIndex;
            List<Tariff> tariffs = dataGridView1.DataSource as List<Tariff>;

            dataGridView1.DataSource = null;
            if (index == 0)
                tariffs = tariffs.OrderBy(t => t.Name).ToList();
            else if (index == 1)
                tariffs = tariffs.OrderBy(t => t.Cost).ToList();
            else if (index == 2)
                tariffs = tariffs.OrderBy(t => t.Speed).ToList();
            else if (index == 3)
                tariffs = tariffs.OrderBy(t => t.CountChannel).ToList();
            else if (index == 4)
                tariffs = tariffs.OrderBy(t => t.Status).ToList();

            dataGridView1.DataSource = tariffs;
        }
    }
}
