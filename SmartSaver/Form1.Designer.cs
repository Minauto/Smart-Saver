using System;

namespace SmartSaver
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.addADepositBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Bookman Old Style", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.name.Location = new System.Drawing.Point(400, 9);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(240, 41);
            this.name.TabIndex = 0;
            this.name.Text = "Smart Saver";
            this.name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.name.Click += new System.EventHandler(this.label1_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.balanceBtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.balanceBtn.Location = new System.Drawing.Point(407, 83);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(233, 62);
            this.balanceBtn.TabIndex = 1;
            this.balanceBtn.Text = "Balance";
            this.balanceBtn.UseVisualStyleBackColor = false;
            this.balanceBtn.Click += new System.EventHandler(this.balanceBtn_Click);
            // 
            // addADepositBtn
            // 
            this.addADepositBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addADepositBtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addADepositBtn.Location = new System.Drawing.Point(407, 151);
            this.addADepositBtn.Name = "addADepositBtn";
            this.addADepositBtn.Size = new System.Drawing.Size(233, 62);
            this.addADepositBtn.TabIndex = 2;
            this.addADepositBtn.Text = "Add a deposit";
            this.addADepositBtn.UseVisualStyleBackColor = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.settingsBtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.Location = new System.Drawing.Point(407, 219);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(233, 62);
            this.settingsBtn.TabIndex = 3;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.historyBtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyBtn.Location = new System.Drawing.Point(407, 287);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(233, 62);
            this.historyBtn.TabIndex = 4;
            this.historyBtn.Text = "History";
            this.historyBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitBtn.Font = new System.Drawing.Font("Poor Richard", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(407, 355);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(233, 62);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.addADepositBtn);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.name);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Button addADepositBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

