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
    public partial class NewClientForm : Form
    {
        private Client client;
        private bool changePassword = false;

        public NewClientForm(Client client = null)
        {
            InitializeComponent();

            if (client != null)
            {
                txtBxFIO.Text = client.FIO;
                txtBxEmail.Text = client.Email;
                txtBxLogin.Text = client.Login;
                txtBxPassword.Text = client.Password;
                txtBxPhone.Text = client.Phone;
                txtBxPassport.Text = client.Passport;
                dateTimePickerBTH.Value = client.Birthday;

                this.client = client;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBxFIO.Text) || 
                string.IsNullOrWhiteSpace(txtBxLogin.Text) || 
                string.IsNullOrWhiteSpace(txtBxPassword.Text))
            {
                MessageBox.Show("Заполните обязательные поля");
                return;
            }

            if (client == null)
            {
                if (DBController.Instance.Clients.Any(t=>t.Login == txtBxLogin.Text))
                {
                    MessageBox.Show("Данный логин уже занят!");
                    return;
                }
                client = new Client();
            }

            client.FIO = txtBxFIO.Text;
            client.Birthday = dateTimePickerBTH.Value;
            client.Email = txtBxEmail.Text;
            client.Login = txtBxLogin.Text;
            if (changePassword)
                client.Password = Helper.GetHash(txtBxPassword.Text);
            client.Phone = txtBxPhone.Text;
            client.Passport = txtBxPassport.Text;

            DBController.Instance.Update(client);

            DialogResult = DialogResult.OK;
        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            changePassword = true;
        }
    }
}
