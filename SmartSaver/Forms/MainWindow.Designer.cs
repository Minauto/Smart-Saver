﻿using System;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.applicationName = new System.Windows.Forms.Label();
            this.spendingsButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.setAGoalButton = new System.Windows.Forms.Button();
            this.DisplayNameLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.addExpensesButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddToExpensesButton = new System.Windows.Forms.Button();
            this.AddExpensePanel = new System.Windows.Forms.Panel();
            this.ExpensesComboBox = new System.Windows.Forms.ComboBox();
            this.ExitAddExpensesLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SetAGoalPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GoalAmountTextBox = new System.Windows.Forms.TextBox();
            this.SetGoalAmountButton = new System.Windows.Forms.Button();
            this.AmountLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MonthlyGoalLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.monthlyExpLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.AddExpensePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SetAGoalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            // spendingsButton
            // 
            this.spendingsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spendingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendingsButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.spendingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spendingsButton.Image = ((System.Drawing.Image)(resources.GetObject("spendingsButton.Image")));
            this.spendingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.spendingsButton.Location = new System.Drawing.Point(0, 83);
            this.spendingsButton.Name = "spendingsButton";
            this.spendingsButton.Size = new System.Drawing.Size(200, 58);
            this.spendingsButton.TabIndex = 1;
            this.spendingsButton.Text = "Spendings";
            this.spendingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spendingsButton.UseVisualStyleBackColor = false;
            this.spendingsButton.Click += new System.EventHandler(this.SpendingsButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMenu.Controls.Add(this.setAGoalButton);
            this.panelMenu.Controls.Add(this.DisplayNameLabel);
            this.panelMenu.Controls.Add(this.exitBtn);
            this.panelMenu.Controls.Add(this.applicationName);
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.addExpensesButton);
            this.panelMenu.Controls.Add(this.spendingsButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 541);
            this.panelMenu.TabIndex = 6;
            // 
            // setAGoalButton
            // 
            this.setAGoalButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setAGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setAGoalButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.setAGoalButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setAGoalButton.Image = ((System.Drawing.Image)(resources.GetObject("setAGoalButton.Image")));
            this.setAGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setAGoalButton.Location = new System.Drawing.Point(0, 270);
            this.setAGoalButton.Name = "setAGoalButton";
            this.setAGoalButton.Size = new System.Drawing.Size(200, 58);
            this.setAGoalButton.TabIndex = 8;
            this.setAGoalButton.Text = "Set a goal";
            this.setAGoalButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setAGoalButton.UseVisualStyleBackColor = false;
            this.setAGoalButton.Click += new System.EventHandler(this.setAGoalButton_Click);
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
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exitBtn.Location = new System.Drawing.Point(0, 483);
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
            this.settingsBtn.Location = new System.Drawing.Point(0, 419);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(200, 58);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.UseVisualStyleBackColor = false;
            // 
            // addExpensesButton
            // 
            this.addExpensesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpensesButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addExpensesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addExpensesButton.Image = ((System.Drawing.Image)(resources.GetObject("addExpensesButton.Image")));
            this.addExpensesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addExpensesButton.Location = new System.Drawing.Point(0, 175);
            this.addExpensesButton.Name = "addExpensesButton";
            this.addExpensesButton.Size = new System.Drawing.Size(200, 58);
            this.addExpensesButton.TabIndex = 2;
            this.addExpensesButton.Text = "Add expenses";
            this.addExpensesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addExpensesButton.UseVisualStyleBackColor = false;
            this.addExpensesButton.Click += new System.EventHandler(this.AddExpensesButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmountLabel.Location = new System.Drawing.Point(3, 9);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(79, 21);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.AmountTextBox.Location = new System.Drawing.Point(3, 33);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(124, 27);
            this.AmountTextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TypeLabel.Location = new System.Drawing.Point(3, 73);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(51, 21);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type:";
            // 
            // AddToExpensesButton
            // 
            this.AddToExpensesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AddToExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToExpensesButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddToExpensesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddToExpensesButton.Location = new System.Drawing.Point(3, 130);
            this.AddToExpensesButton.Name = "AddToExpensesButton";
            this.AddToExpensesButton.Size = new System.Drawing.Size(124, 29);
            this.AddToExpensesButton.TabIndex = 8;
            this.AddToExpensesButton.Text = "Add";
            this.AddToExpensesButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddToExpensesButton.UseVisualStyleBackColor = false;
            this.AddToExpensesButton.Click += new System.EventHandler(this.AddToExpensesButton_Click);
            // 
            // AddExpensePanel
            // 
            this.AddExpensePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddExpensePanel.Controls.Add(this.ExpensesComboBox);
            this.AddExpensePanel.Controls.Add(this.ExitAddExpensesLabel);
            this.AddExpensePanel.Controls.Add(this.AmountTextBox);
            this.AddExpensePanel.Controls.Add(this.AddToExpensesButton);
            this.AddExpensePanel.Controls.Add(this.AmountLabel);
            this.AddExpensePanel.Controls.Add(this.TypeLabel);
            this.AddExpensePanel.Location = new System.Drawing.Point(206, 78);
            this.AddExpensePanel.Name = "AddExpensePanel";
            this.AddExpensePanel.Size = new System.Drawing.Size(140, 186);
            this.AddExpensePanel.TabIndex = 13;
            this.AddExpensePanel.Visible = false;
            // 
            // ExpensesComboBox
            // 
            this.ExpensesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpensesComboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ExpensesComboBox.FormattingEnabled = true;
            this.ExpensesComboBox.Items.AddRange(new object[] {
            "Groceries",
            "Leisure",
            "Fuel",
            "CarService",
            "New Stuff"});
            this.ExpensesComboBox.Location = new System.Drawing.Point(3, 97);
            this.ExpensesComboBox.Name = "ExpensesComboBox";
            this.ExpensesComboBox.Size = new System.Drawing.Size(124, 29);
            this.ExpensesComboBox.TabIndex = 2;
            // 
            // ExitAddExpensesLabel
            // 
            this.ExitAddExpensesLabel.AutoSize = true;
            this.ExitAddExpensesLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ExitAddExpensesLabel.Location = new System.Drawing.Point(122, 0);
            this.ExitAddExpensesLabel.Name = "ExitAddExpensesLabel";
            this.ExitAddExpensesLabel.Size = new System.Drawing.Size(18, 19);
            this.ExitAddExpensesLabel.TabIndex = 13;
            this.ExitAddExpensesLabel.Text = "X";
            this.ExitAddExpensesLabel.Click += new System.EventHandler(this.ExitAddExpensesLabel_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SetAGoalPanel);
            this.MainPanel.Controls.Add(this.AddExpensePanel);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1276, 541);
            this.MainPanel.TabIndex = 14;
            // 
            // SetAGoalPanel
            // 
            this.SetAGoalPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SetAGoalPanel.Controls.Add(this.label1);
            this.SetAGoalPanel.Controls.Add(this.GoalAmountTextBox);
            this.SetAGoalPanel.Controls.Add(this.SetGoalAmountButton);
            this.SetAGoalPanel.Controls.Add(this.AmountLabel2);
            this.SetAGoalPanel.Location = new System.Drawing.Point(206, 270);
            this.SetAGoalPanel.Name = "SetAGoalPanel";
            this.SetAGoalPanel.Size = new System.Drawing.Size(140, 113);
            this.SetAGoalPanel.TabIndex = 14;
            this.SetAGoalPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(122, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.ExitSetAGoalLabel_Click);
            // 
            // GoalAmountTextBox
            // 
            this.GoalAmountTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.GoalAmountTextBox.Location = new System.Drawing.Point(3, 33);
            this.GoalAmountTextBox.Name = "GoalAmountTextBox";
            this.GoalAmountTextBox.Size = new System.Drawing.Size(124, 27);
            this.GoalAmountTextBox.TabIndex = 1;
            // 
            // SetGoalAmountButton
            // 
            this.SetGoalAmountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SetGoalAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetGoalAmountButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SetGoalAmountButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetGoalAmountButton.Location = new System.Drawing.Point(3, 66);
            this.SetGoalAmountButton.Name = "SetGoalAmountButton";
            this.SetGoalAmountButton.Size = new System.Drawing.Size(124, 29);
            this.SetGoalAmountButton.TabIndex = 8;
            this.SetGoalAmountButton.Text = "Set";
            this.SetGoalAmountButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetGoalAmountButton.UseVisualStyleBackColor = false;
            this.SetGoalAmountButton.Click += new System.EventHandler(this.SetGoalAmountButton_Click);
            // 
            // AmountLabel2
            // 
            this.AmountLabel2.AutoSize = true;
            this.AmountLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmountLabel2.Location = new System.Drawing.Point(3, 9);
            this.AmountLabel2.Name = "AmountLabel2";
            this.AmountLabel2.Size = new System.Drawing.Size(79, 21);
            this.AmountLabel2.TabIndex = 8;
            this.AmountLabel2.Text = "Amount:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(911, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 483);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.MonthlyGoalLabel);
            this.panel1.Controls.Add(this.logOutLabel);
            this.panel1.Controls.Add(this.monthlyExpLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 58);
            this.panel1.TabIndex = 1;
            // 
            // MonthlyGoalLabel
            // 
            this.MonthlyGoalLabel.AutoSize = true;
            this.MonthlyGoalLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyGoalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MonthlyGoalLabel.Location = new System.Drawing.Point(210, 20);
            this.MonthlyGoalLabel.Name = "MonthlyGoalLabel";
            this.MonthlyGoalLabel.Size = new System.Drawing.Size(41, 16);
            this.MonthlyGoalLabel.TabIndex = 4;
            this.MonthlyGoalLabel.Text = "label2";
            // 
            // logOutLabel
            // 
            this.logOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOutLabel.Location = new System.Drawing.Point(1222, 36);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(51, 16);
            this.logOutLabel.TabIndex = 3;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // monthlyExpLabel
            // 
            this.monthlyExpLabel.AutoSize = true;
            this.monthlyExpLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyExpLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.monthlyExpLabel.Location = new System.Drawing.Point(210, 36);
            this.monthlyExpLabel.Name = "monthlyExpLabel";
            this.monthlyExpLabel.Size = new System.Drawing.Size(41, 16);
            this.monthlyExpLabel.TabIndex = 2;
            this.monthlyExpLabel.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1276, 541);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.AddExpensePanel.ResumeLayout(false);
            this.AddExpensePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.SetAGoalPanel.ResumeLayout(false);
            this.SetAGoalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.Button spendingsButton;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button addExpensesButton;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button AddToExpensesButton;
        private System.Windows.Forms.Panel AddExpensePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label ExitAddExpensesLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ExpensesComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label monthlyExpLabel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Button setAGoalButton;
        private System.Windows.Forms.Panel SetAGoalPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GoalAmountTextBox;
        private System.Windows.Forms.Button SetGoalAmountButton;
        private System.Windows.Forms.Label AmountLabel2;
        private System.Windows.Forms.Label MonthlyGoalLabel;
    }
}

