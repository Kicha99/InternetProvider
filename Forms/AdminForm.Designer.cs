namespace InternetProvider.Forms
{
    partial class AdminForm
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
            this.btnTariffs = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnARPU = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTariffs
            // 
            this.btnTariffs.Location = new System.Drawing.Point(446, 206);
            this.btnTariffs.Name = "btnTariffs";
            this.btnTariffs.Size = new System.Drawing.Size(185, 51);
            this.btnTariffs.TabIndex = 0;
            this.btnTariffs.Text = "Тарифы";
            this.btnTariffs.UseVisualStyleBackColor = true;
            this.btnTariffs.Click += new System.EventHandler(this.btnTariffs_Click);
            // 
            // btnClients
            // 
            this.btnClients.Location = new System.Drawing.Point(446, 130);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(185, 51);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "Клиенты";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnAdmins
            // 
            this.btnAdmins.Location = new System.Drawing.Point(446, 59);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(185, 50);
            this.btnAdmins.TabIndex = 2;
            this.btnAdmins.Text = "Администраторы";
            this.btnAdmins.UseVisualStyleBackColor = true;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // btnRequests
            // 
            this.btnRequests.Location = new System.Drawing.Point(62, 58);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(185, 51);
            this.btnRequests.TabIndex = 3;
            this.btnRequests.Text = "Заявки";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.btnRequests_Click);
            // 
            // btnContracts
            // 
            this.btnContracts.Location = new System.Drawing.Point(62, 130);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Size = new System.Drawing.Size(185, 51);
            this.btnContracts.TabIndex = 4;
            this.btnContracts.Text = "Договоры";
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.btnContracts_Click);
            // 
            // btnARPU
            // 
            this.btnARPU.Location = new System.Drawing.Point(62, 206);
            this.btnARPU.Name = "btnARPU";
            this.btnARPU.Size = new System.Drawing.Size(185, 51);
            this.btnARPU.TabIndex = 5;
            this.btnARPU.Text = "Отчет ARPU";
            this.btnARPU.UseVisualStyleBackColor = true;
            this.btnARPU.Click += new System.EventHandler(this.btnARPU_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 395);
            this.Controls.Add(this.btnARPU);
            this.Controls.Add(this.btnContracts);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.btnClients);
            this.Controls.Add(this.btnTariffs);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTariffs;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnARPU;
    }
}

