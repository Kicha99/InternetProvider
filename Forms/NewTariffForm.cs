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
    public partial class NewTariffForm : Form
    {
        private Tariff tariff;

        public NewTariffForm(Tariff tariff = null)
        {
            InitializeComponent();

            if (tariff != null)
            {
                this.tariff = tariff;

                txtBxName.Text = tariff.Name;
                numericCost.Value = tariff.Cost;
                numericCountChannel.Value = tariff.CountChannel;
                numericSpeed.Value = tariff.Speed;
                cmbBxStatus.SelectedIndex = (int)tariff.Status;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxName.Text))
            {
                MessageBox.Show("Укажите название тарифа");
                return;
            }

            if (tariff == null)
                tariff = new Tariff();
            tariff.Name = txtBxName.Text;
            tariff.Cost = numericCost.Value;
            tariff.CountChannel = (int)numericCountChannel.Value;
            tariff.Speed = (int)numericSpeed.Value;
            tariff.Status = (TariffStatus)cmbBxStatus.SelectedIndex;

            DBController.Instance.Update(tariff);

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
