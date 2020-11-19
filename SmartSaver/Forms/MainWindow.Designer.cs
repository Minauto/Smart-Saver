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
            this.spendingsButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.setALimitButton = new System.Windows.Forms.Button();
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
            this.SetALimitPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LimitAmountTextBox = new System.Windows.Forms.TextBox();
            this.SetLimitAmountButton = new System.Windows.Forms.Button();
            this.AmountLabel2 = new System.Windows.Forms.Label();
            this.LimitProgressBar = new CircularProgressBar.CircularProgressBar();
            this.lowerPanel = new System.Windows.Forms.Panel();
            this.MonthlyGoalLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.monthlyExpLabel = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.AddExpensePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SetALimitPanel.SuspendLayout();
            this.lowerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.applicationName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.applicationName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.applicationName.Location = new System.Drawing.Point(-7, 9);
            this.applicationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(222, 39);
            this.applicationName.TabIndex = 0;
            this.applicationName.Text = "Smart Saver";
            this.applicationName.Click += new System.EventHandler(this.label1_Click);
            // 
            // spendingsButton
            // 
            this.spendingsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.spendingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spendingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
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
            this.panelMenu.Controls.Add(this.setALimitButton);
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
            // setALimitButton
            // 
            this.setALimitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.setALimitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setALimitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.setALimitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setALimitButton.Image = ((System.Drawing.Image)(resources.GetObject("setALimitButton.Image")));
            this.setALimitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.setALimitButton.Location = new System.Drawing.Point(0, 270);
            this.setALimitButton.Name = "setALimitButton";
            this.setALimitButton.Size = new System.Drawing.Size(200, 58);
            this.setALimitButton.TabIndex = 8;
            this.setALimitButton.Text = "Set a limit";
            this.setALimitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setALimitButton.UseVisualStyleBackColor = false;
            this.setALimitButton.Click += new System.EventHandler(this.setAGoalButton_Click);
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
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
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
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
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
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // addExpensesButton
            // 
            this.addExpensesButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpensesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
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
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmountLabel.Location = new System.Drawing.Point(3, 9);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(69, 20);
            this.AmountLabel.TabIndex = 8;
            this.AmountLabel.Text = "Amount:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AmountTextBox.Location = new System.Drawing.Point(3, 33);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(124, 26);
            this.AmountTextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TypeLabel.Location = new System.Drawing.Point(3, 73);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(47, 20);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "Type:";
            // 
            // AddToExpensesButton
            // 
            this.AddToExpensesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.AddToExpensesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddToExpensesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.AddExpensePanel.Location = new System.Drawing.Point(6, 83);
            this.AddExpensePanel.Name = "AddExpensePanel";
            this.AddExpensePanel.Size = new System.Drawing.Size(140, 186);
            this.AddExpensePanel.TabIndex = 13;
            this.AddExpensePanel.Visible = false;
            // 
            // ExpensesComboBox
            // 
            this.ExpensesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpensesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExpensesComboBox.FormattingEnabled = true;
            this.ExpensesComboBox.Location = new System.Drawing.Point(3, 97);
            this.ExpensesComboBox.Name = "ExpensesComboBox";
            this.ExpensesComboBox.Size = new System.Drawing.Size(124, 28);
            this.ExpensesComboBox.TabIndex = 2;
            // 
            // ExitAddExpensesLabel
            // 
            this.ExitAddExpensesLabel.AutoSize = true;
            this.ExitAddExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExitAddExpensesLabel.Location = new System.Drawing.Point(122, 0);
            this.ExitAddExpensesLabel.Name = "ExitAddExpensesLabel";
            this.ExitAddExpensesLabel.Size = new System.Drawing.Size(17, 17);
            this.ExitAddExpensesLabel.TabIndex = 13;
            this.ExitAddExpensesLabel.Text = "X";
            this.ExitAddExpensesLabel.Click += new System.EventHandler(this.ExitAddExpensesLabel_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SetALimitPanel);
            this.MainPanel.Controls.Add(this.AddExpensePanel);
            this.MainPanel.Controls.Add(this.LimitProgressBar);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1076, 483);
            this.MainPanel.TabIndex = 14;
            // 
            // SetALimitPanel
            // 
            this.SetALimitPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SetALimitPanel.Controls.Add(this.label1);
            this.SetALimitPanel.Controls.Add(this.LimitAmountTextBox);
            this.SetALimitPanel.Controls.Add(this.SetLimitAmountButton);
            this.SetALimitPanel.Controls.Add(this.AmountLabel2);
            this.SetALimitPanel.Location = new System.Drawing.Point(6, 275);
            this.SetALimitPanel.Name = "SetALimitPanel";
            this.SetALimitPanel.Size = new System.Drawing.Size(140, 113);
            this.SetALimitPanel.TabIndex = 14;
            this.SetALimitPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(122, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.ExitSetAGoalLabel_Click);
            // 
            // LimitAmountTextBox
            // 
            this.LimitAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LimitAmountTextBox.Location = new System.Drawing.Point(3, 33);
            this.LimitAmountTextBox.Name = "LimitAmountTextBox";
            this.LimitAmountTextBox.Size = new System.Drawing.Size(124, 26);
            this.LimitAmountTextBox.TabIndex = 1;
            // 
            // SetLimitAmountButton
            // 
            this.SetLimitAmountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SetLimitAmountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLimitAmountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SetLimitAmountButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetLimitAmountButton.Location = new System.Drawing.Point(3, 66);
            this.SetLimitAmountButton.Name = "SetLimitAmountButton";
            this.SetLimitAmountButton.Size = new System.Drawing.Size(124, 29);
            this.SetLimitAmountButton.TabIndex = 8;
            this.SetLimitAmountButton.Text = "Set";
            this.SetLimitAmountButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetLimitAmountButton.UseVisualStyleBackColor = false;
            this.SetLimitAmountButton.Click += new System.EventHandler(this.SetLimitAmountButton_Click);
            // 
            // AmountLabel2
            // 
            this.AmountLabel2.AutoSize = true;
            this.AmountLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AmountLabel2.Location = new System.Drawing.Point(3, 9);
            this.AmountLabel2.Name = "AmountLabel2";
            this.AmountLabel2.Size = new System.Drawing.Size(69, 20);
            this.AmountLabel2.TabIndex = 8;
            this.AmountLabel2.Text = "Amount:";
            // 
            // LimitProgressBar
            // 
            this.LimitProgressBar.AccessibleName = "";
            this.LimitProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LimitProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.LimitProgressBar.AnimationSpeed = 500;
            this.LimitProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.LimitProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LimitProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LimitProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.LimitProgressBar.InnerMargin = 2;
            this.LimitProgressBar.InnerWidth = -1;
            this.LimitProgressBar.Location = new System.Drawing.Point(9, 341);
            this.LimitProgressBar.MarqueeAnimationSpeed = 2000;
            this.LimitProgressBar.Name = "LimitProgressBar";
            this.LimitProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.LimitProgressBar.OuterMargin = -25;
            this.LimitProgressBar.OuterWidth = 26;
            this.LimitProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LimitProgressBar.ProgressWidth = 25;
            this.LimitProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.LimitProgressBar.Size = new System.Drawing.Size(140, 136);
            this.LimitProgressBar.StartAngle = 270;
            this.LimitProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.LimitProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.LimitProgressBar.SubscriptText = "";
            this.LimitProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LimitProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.LimitProgressBar.SuperscriptText = "";
            this.LimitProgressBar.TabIndex = 15;
            this.LimitProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LimitProgressBar.Value = 68;
            // 
            // lowerPanel
            // 
            this.lowerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.lowerPanel.Controls.Add(this.MonthlyGoalLabel);
            this.lowerPanel.Controls.Add(this.logOutLabel);
            this.lowerPanel.Controls.Add(this.monthlyExpLabel);
            this.lowerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lowerPanel.Location = new System.Drawing.Point(200, 483);
            this.lowerPanel.Name = "lowerPanel";
            this.lowerPanel.Size = new System.Drawing.Size(1076, 58);
            this.lowerPanel.TabIndex = 1;
            // 
            // MonthlyGoalLabel
            // 
            this.MonthlyGoalLabel.AutoSize = true;
            this.MonthlyGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyGoalLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MonthlyGoalLabel.Location = new System.Drawing.Point(6, 20);
            this.MonthlyGoalLabel.Name = "MonthlyGoalLabel";
            this.MonthlyGoalLabel.Size = new System.Drawing.Size(35, 13);
            this.MonthlyGoalLabel.TabIndex = 4;
            this.MonthlyGoalLabel.Text = "label2";
            // 
            // logOutLabel
            // 
            this.logOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOutLabel.Location = new System.Drawing.Point(1022, 36);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(45, 13);
            this.logOutLabel.TabIndex = 3;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.logOutLabel_Click);
            // 
            // monthlyExpLabel
            // 
            this.monthlyExpLabel.AutoSize = true;
            this.monthlyExpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyExpLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.monthlyExpLabel.Location = new System.Drawing.Point(6, 36);
            this.monthlyExpLabel.Name = "monthlyExpLabel";
            this.monthlyExpLabel.Size = new System.Drawing.Size(35, 13);
            this.monthlyExpLabel.TabIndex = 2;
            this.monthlyExpLabel.Text = "label1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1276, 541);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.lowerPanel);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainWindow";
            this.Text = "Smart Saver";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.AddExpensePanel.ResumeLayout(false);
            this.AddExpensePanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.SetALimitPanel.ResumeLayout(false);
            this.SetALimitPanel.PerformLayout();
            this.lowerPanel.ResumeLayout(false);
            this.lowerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label applicationName;
        private System.Windows.Forms.Label DisplayNameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button AddToExpensesButton;
        private System.Windows.Forms.Panel AddExpensePanel;
        private System.Windows.Forms.Label ExitAddExpensesLabel;
        private System.Windows.Forms.ComboBox ExpensesComboBox;
        private System.Windows.Forms.Panel SetALimitPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LimitAmountTextBox;
        private System.Windows.Forms.Button SetLimitAmountButton;
        private System.Windows.Forms.Label AmountLabel2;
        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Panel lowerPanel;
        public System.Windows.Forms.Label monthlyExpLabel;
        public System.Windows.Forms.Label MonthlyGoalLabel;
        public CircularProgressBar.CircularProgressBar LimitProgressBar;
        public System.Windows.Forms.Panel panelMenu;
        public System.Windows.Forms.Button spendingsButton;
        public System.Windows.Forms.Button settingsBtn;
        public System.Windows.Forms.Button addExpensesButton;
        public System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Label logOutLabel;
        public System.Windows.Forms.Button setALimitButton;
    }
}

