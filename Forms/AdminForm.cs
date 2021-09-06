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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnTariffs_Click(object sender, EventArgs e)
        {
            TariffsForm form = new TariffsForm();
            form.ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ClientsForm form = new ClientsForm();
            form.ShowDialog();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            AdminsForm form = new AdminsForm();
            form.ShowDialog();
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            RequestsForm form = new RequestsForm();
            form.ShowDialog();
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            ContractsForm form = new ContractsForm();
            form.ShowDialog();
        }

        private void btnARPU_Click(object sender, EventArgs e)
        {
            ARPUForm form = new ARPUForm();
            form.ShowDialog();
        }
    }
}
