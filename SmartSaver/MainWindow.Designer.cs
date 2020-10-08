using System;

namespace SmartSaver
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.applicationName = new System.Windows.Forms.Label();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.addADepositBtn = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.applicationName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applicationName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.applicationName.Location = new System.Drawing.Point(-7, 9);
            this.applicationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(217, 41);
            this.applicationName.TabIndex = 0;
            this.applicationName.Text = "Smart Saver";
            this.applicationName.Click += new System.EventHandler(this.label1_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.balanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.balanceBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.balanceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.balanceBtn.Image = ((System.Drawing.Image)(resources.GetObject("balanceBtn.Image")));
            this.balanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.balanceBtn.Location = new System.Drawing.Point(0, 83);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(200, 58);
            this.balanceBtn.TabIndex = 1;
            this.balanceBtn.Text = "Balance";
            this.balanceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.balanceBtn.UseVisualStyleBackColor = false;
            this.balanceBtn.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenu.Controls.Add(this.DisplayNameLabel);
            this.panelMenu.Controls.Add(this.exitBtn);
            this.panelMenu.Controls.Add(this.applicationName);
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.historyBtn);
            this.panelMenu.Controls.Add(this.addADepositBtn);
            this.panelMenu.Controls.Add(this.balanceBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 450);
            this.panelMenu.TabIndex = 6;
            // 
            // DisplayNameLabel
            // 
            this.DisplayNameLabel.AutoSize = true;
            this.DisplayNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DisplayNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DisplayNameLabel.Location = new System.Drawing.Point(3, 50);
            this.DisplayNameLabel.MaximumSize = new System.Drawing.Size(200, 32);
            this.DisplayNameLabel.Name = "DisplayNameLabel";
            this.DisplayNameLabel.Size = new System.Drawing.Size(41, 19);
            this.DisplayNameLabel.TabIndex = 7;
            this.DisplayNameLabel.Text = "Hello";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.Location = new System.Drawing.Point(0, 392);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(200, 58);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsBtn.Location = new System.Drawing.Point(0, 275);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(200, 58);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = false;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.historyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.historyBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyBtn.Image")));
            this.historyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.historyBtn.Location = new System.Drawing.Point(0, 211);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(200, 58);
            this.historyBtn.TabIndex = 3;
            this.historyBtn.Text = "History";
            this.historyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // addADepositBtn
            // 
            this.addADepositBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addADepositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addADepositBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addADepositBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addADepositBtn.Image = ((System.Drawing.Image)(resources.GetObject("addADepositBtn.Image")));
            this.addADepositBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addADepositBtn.Location = new System.Drawing.Point(0, 147);
            this.addADepositBtn.Name = "addADepositBtn";
            this.addADepositBtn.Size = new System.Drawing.Size(200, 58);
            this.addADepositBtn.TabIndex = 2;
            this.addADepositBtn.Text = "Add a deposit";
            this.addADepositBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addADepositBtn.UseVisualStyleBackColor = false;
            this.addADepositBtn.Click += new System.EventHandler(this.addADepositBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button addADepositBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label DisplayNameLabel;
    }
}

