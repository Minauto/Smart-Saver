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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelMenu.SuspendLayout();
            this.AddExpensePanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panelMenu.Controls.Add(this.DisplayNameLabel);
            this.panelMenu.Controls.Add(this.exitBtn);
            this.panelMenu.Controls.Add(this.applicationName);
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.addExpensesButton);
            this.panelMenu.Controls.Add(this.spendingsButton);
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
            this.settingsBtn.Location = new System.Drawing.Point(0, 211);
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
            this.addExpensesButton.Location = new System.Drawing.Point(0, 147);
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
            this.AddExpensePanel.Location = new System.Drawing.Point(206, 83);
            this.AddExpensePanel.Name = "AddExpensePanel";
            this.AddExpensePanel.Size = new System.Drawing.Size(140, 186);
            this.AddExpensePanel.TabIndex = 13;
            this.AddExpensePanel.Visible = false;
            // 
            // ExpensesComboBox
            // 
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
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Location = new System.Drawing.Point(206, 12);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(847, 426);
            this.MainPanel.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(479, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(365, 420);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.AddExpensePanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ExpensesComboBox;
    }
}

