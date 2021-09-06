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
    public partial class NewAdminForm : Form
    {
        private Administrator administrator;
        private bool changePassword = false;

        public NewAdminForm(Administrator administrator = null)
        {
            InitializeComponent();

            if (administrator != null) 
            {
                txtBxFIO.Text = administrator.FIO;
                txtBxLogin.Text = administrator.Login;
                txtBxPassword.Text = administrator.Password;
                txtBxPhone.Text = administrator.Phone;

                this.administrator = administrator;
            }
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

            if (administrator == null)
            {
                if (DBController.Instance.Administrators.Any(t => t.Login == txtBxLogin.Text))
                {
                    MessageBox.Show("Данный логин уже занят!");
                    return;
                }
                administrator = new Administrator();
            }

            administrator.FIO = txtBxFIO.Text;
            administrator.Login = txtBxLogin.Text;
            if (changePassword)
                administrator.Password = Helper.GetHash(txtBxPassword.Text);
            administrator.Phone = txtBxPhone.Text;

            DBController.Instance.Update(administrator);

            DialogResult = DialogResult.OK;
        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            changePassword = true;
        }
    }
}
