﻿namespace InternetProvider.Forms
{
    partial class LoginForm
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
            this.txtBxLogin = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.chckBxGuest = new System.Windows.Forms.CheckBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxLogin
            // 
            this.txtBxLogin.Location = new System.Drawing.Point(112, 108);
            this.txtBxLogin.Name = "txtBxLogin";
            this.txtBxLogin.Size = new System.Drawing.Size(315, 30);
            this.txtBxLogin.TabIndex = 0;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(112, 285);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(143, 39);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // chckBxGuest
            // 
            this.chckBxGuest.AutoSize = true;
            this.chckBxGuest.Location = new System.Drawing.Point(197, 229);
            this.chckBxGuest.Name = "chckBxGuest";
            this.chckBxGuest.Size = new System.Drawing.Size(166, 26);
            this.chckBxGuest.TabIndex = 2;
            this.chckBxGuest.Text = "Зайти как гость";
            this.chckBxGuest.UseVisualStyleBackColor = true;
            this.chckBxGuest.CheckedChanged += new System.EventHandler(this.chckBxGuest_CheckedChanged);
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(112, 177);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.Size = new System.Drawing.Size(315, 30);
            this.txtBxPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите пароль";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(284, 285);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 39);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Вход";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 405);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.chckBxGuest);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txtBxLogin);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxLogin;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.CheckBox chckBxGuest;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
    }
}