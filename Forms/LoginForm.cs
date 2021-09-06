using InternetProvider.Entities;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            NewClientForm form = new NewClientForm();
            form.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (chckBxGuest.Checked)
            {
                TariffsForm form = new TariffsForm();
                form.ShowDialog();
            }
            else
            {
                string login = txtBxLogin.Text;
                string password = Helper.GetHash(txtBxPassword.Text);

                Client client = DBController.Instance.Clients.FirstOrDefault(t => t.Login == login && t.Password == password);
                if (client != null)
                {
                    ApplicationHelper.Instance.CurrentUser = client;

                    ContractsForm contractsForm = new ContractsForm();
                    contractsForm.ShowDialog();
                }
                else
                {
                    Administrator administrator = DBController.Instance.Administrators.FirstOrDefault(t => t.Login == login && t.Password == password);
                    ApplicationHelper.Instance.CurrentUser = administrator;
                    if (administrator != null)
                    {
                        AdminForm form = new AdminForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                    }
                }
            }
        }

        private void chckBxGuest_CheckedChanged(object sender, EventArgs e)
        {
            txtBxLogin.Enabled = !chckBxGuest.Checked;
            txtBxPassword.Enabled = !chckBxGuest.Checked;
        }
    }
}
