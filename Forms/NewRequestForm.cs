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
    public partial class NewRequestForm : Form
    {
        private Request request;
        public NewRequestForm(Request request = null)
        {
            InitializeComponent();

            comboBoxClient.DataSource = DBController.Instance.Clients;
            comboBoxTariff.DataSource = DBController.Instance.Tariffs;

            if (ApplicationHelper.Instance.CurrentRole == Role.Client)
            {
                comboBoxClient.SelectedItem = ApplicationHelper.Instance.CurrentUser;
                comboBoxClient.Enabled = false;
            }

            if (request != null) 
            {
                txtBxNumber.Text = request.Number.ToString();
                comboBoxClient.SelectedItem = request.Client;
                comboBoxTariff.SelectedItem = request.Tariff;
                txtBxDate.Text = request.Date.ToShortDateString();
                txtBxAddress.Text = request.Address;

                this.request = request;
            }
            else
            {
                txtBxDate.Text = DateTime.Now.ToShortDateString();
                txtBxNumber.Text = DBController.Instance.MaxNumberRequest().ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (comboBoxTariff.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtBxNumber.Text) ||
                comboBoxClient.SelectedItem == null)
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }
            if (request == null)
            {
                request = new Request();
                request.Date = DateTime.Now;
                request.Number = int.Parse(txtBxNumber.Text);
            }
           
            request.Client = comboBoxClient.SelectedItem as Client;
            request.Tariff = comboBoxTariff.SelectedItem as Tariff;
            request.Address = txtBxAddress.Text;
            request.Status = RequestStatus.New;

            DBController.Instance.Update(request);

            DialogResult = DialogResult.OK;
        }
    }
}
