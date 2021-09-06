using InternetProvider.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetProvider.Forms
{
    public partial class NewContractForm : Form
    {
        private List<Payment> payments = new List<Payment>();
        private Contract contract;

        public NewContractForm(Contract contract = null)
        {
            InitializeComponent();

            comboBoxTariff.DataSource = DBController.Instance.Tariffs;
            comboBoxClients.DataSource = DBController.Instance.Clients;

            
            
            if (contract != null)
            {
                this.contract = contract;

                txtBxBalance.Text = contract.Balance.ToString("c");
                txtBxNumber.Text = contract.Number.ToString();
                comboBoxClients.SelectedItem = contract.Client;
                comboBoxStatus.SelectedIndex = (int)contract.TypeStatus;
                comboBoxTariff.SelectedItem = contract.Tariff;
                txtBxAddress.Text = contract.Address;
                dateTimePickerCreate.Value = contract.Date;

                payments = contract.Payments;
                LoadData();
            }
        }

        public void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = payments;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (contract == null)
                contract = new Contract();
            contract.Address = txtBxAddress.Text;
            contract.Balance = ProgramHelper.Splitter(txtBxBalance.Text);
            contract.Client = comboBoxClients.SelectedItem as Client;
            contract.Date = dateTimePickerCreate.Value;
            contract.Number = int.Parse(txtBxNumber.Text);
            //payments.ForEach(t => t.Contract = contract);
            contract.Payments = payments;
            contract.Tariff = comboBoxTariff.SelectedItem as Tariff;
            contract.TypeStatus = (ContractStatus)comboBoxStatus.SelectedIndex;

            DBController.Instance.Update(contract);
            LoadData();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string card = txtBxNumberCard.Text.Trim();
            if (card.Length < 16)
            {
                MessageBox.Show("Неверный номер карты!");
                return;
            }

            decimal sum = numericUpDownSum.Value;
            if (sum <= 0)
            {
                MessageBox.Show("Введите сумму!");
                return;
            }

            Payment payment = new Payment();
            payment.Sum = sum;
            payment.Date = DateTime.Now;
            payment.Contract = contract;
            payments.Add(payment);

            

            txtBxBalance.Text = (sum + ProgramHelper.Splitter(txtBxBalance.Text)).ToString("c");
            DBController.Instance.Update(payment);

            LoadData();

            MessageBox.Show("Оплата прошла успешно!");
        }
    }
}
