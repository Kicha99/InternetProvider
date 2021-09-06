namespace InternetProvider.Forms
{
    partial class NewClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFIO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBTH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxPassport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBxFIO
            // 
            this.txtBxFIO.Location = new System.Drawing.Point(230, 56);
            this.txtBxFIO.Name = "txtBxFIO";
            this.txtBxFIO.Size = new System.Drawing.Size(454, 30);
            this.txtBxFIO.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // dateTimePickerBTH
            // 
            this.dateTimePickerBTH.Location = new System.Drawing.Point(230, 106);
            this.dateTimePickerBTH.Name = "dateTimePickerBTH";
            this.dateTimePickerBTH.Size = new System.Drawing.Size(454, 30);
            this.dateTimePickerBTH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Телефон";
            // 
            // txtBxPhone
            // 
            this.txtBxPhone.Location = new System.Drawing.Point(230, 160);
            this.txtBxPhone.Mask = "(999) 000-0000";
            this.txtBxPhone.Name = "txtBxPhone";
            this.txtBxPhone.Size = new System.Drawing.Size(454, 30);
            this.txtBxPhone.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(230, 209);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(454, 30);
            this.txtBxEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Логин*";
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.Location = new System.Drawing.Point(230, 259);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(454, 30);
            this.txtBxLogin.TabIndex = 9;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(230, 308);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(454, 30);
            this.txtBxPassword.TabIndex = 11;
            this.txtBxPassword.TextChanged += new System.EventHandler(this.txtBxPassword_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пароль*";
            // 
            // txtBxPassport
            // 
            this.txtBxPassport.Location = new System.Drawing.Point(230, 364);
            this.txtBxPassport.Multiline = true;
            this.txtBxPassport.Name = "txtBxPassport";
            this.txtBxPassport.Size = new System.Drawing.Size(454, 115);
            this.txtBxPassport.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(69, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 54);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пасспортные данные";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(470, 530);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 30);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(580, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 30);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // NewClientForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(734, 590);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBxPassport);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBxLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBxPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerBTH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBxFIO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFIO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBTH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtBxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxLogin;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxPassport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}