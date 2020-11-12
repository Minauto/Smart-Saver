namespace SmartSaver.Forms
{
    partial class Settings
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
            this.CustomizeComboBox = new System.Windows.Forms.ComboBox();
            this.AddNewChoiceButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CustomizeLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.ChangeNamePanel = new System.Windows.Forms.Panel();
            this.ExitChangeNamePanel = new System.Windows.Forms.Label();
            this.ChangeNameTextBox = new System.Windows.Forms.TextBox();
            this.SetNewNameButton = new System.Windows.Forms.Button();
            this.DesiredNameLabel = new System.Windows.Forms.Label();
            this.ChangeNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomizeComboBox
            // 
            this.CustomizeComboBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CustomizeComboBox.FormattingEnabled = true;
            this.CustomizeComboBox.Location = new System.Drawing.Point(12, 34);
            this.CustomizeComboBox.Name = "CustomizeComboBox";
            this.CustomizeComboBox.Size = new System.Drawing.Size(124, 29);
            this.CustomizeComboBox.TabIndex = 0;
            // 
            // AddNewChoiceButton
            // 
            this.AddNewChoiceButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddNewChoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewChoiceButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddNewChoiceButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewChoiceButton.Location = new System.Drawing.Point(12, 69);
            this.AddNewChoiceButton.Name = "AddNewChoiceButton";
            this.AddNewChoiceButton.Size = new System.Drawing.Size(124, 29);
            this.AddNewChoiceButton.TabIndex = 1;
            this.AddNewChoiceButton.Text = "Add New";
            this.AddNewChoiceButton.UseVisualStyleBackColor = false;
            this.AddNewChoiceButton.Click += new System.EventHandler(this.AddNewChoiceButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.RemoveButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveButton.Location = new System.Drawing.Point(12, 104);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(124, 29);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CustomizeLabel
            // 
            this.CustomizeLabel.AutoSize = true;
            this.CustomizeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.CustomizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.CustomizeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CustomizeLabel.Location = new System.Drawing.Point(12, 9);
            this.CustomizeLabel.Name = "CustomizeLabel";
            this.CustomizeLabel.Size = new System.Drawing.Size(95, 21);
            this.CustomizeLabel.TabIndex = 3;
            this.CustomizeLabel.Text = "Customize:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(9, 461);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 16);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "username";
            // 
            // changeNameButton
            // 
            this.changeNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeNameButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.changeNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeNameButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.changeNameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.changeNameButton.Location = new System.Drawing.Point(12, 429);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(124, 29);
            this.changeNameButton.TabIndex = 8;
            this.changeNameButton.Text = "Change name";
            this.changeNameButton.UseVisualStyleBackColor = false;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // ChangeNamePanel
            // 
            this.ChangeNamePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChangeNamePanel.Controls.Add(this.ExitChangeNamePanel);
            this.ChangeNamePanel.Controls.Add(this.ChangeNameTextBox);
            this.ChangeNamePanel.Controls.Add(this.SetNewNameButton);
            this.ChangeNamePanel.Controls.Add(this.DesiredNameLabel);
            this.ChangeNamePanel.Location = new System.Drawing.Point(12, 320);
            this.ChangeNamePanel.Name = "ChangeNamePanel";
            this.ChangeNamePanel.Size = new System.Drawing.Size(203, 103);
            this.ChangeNamePanel.TabIndex = 15;
            this.ChangeNamePanel.Visible = false;
            // 
            // ExitChangeNamePanel
            // 
            this.ExitChangeNamePanel.AutoSize = true;
            this.ExitChangeNamePanel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ExitChangeNamePanel.Location = new System.Drawing.Point(182, 0);
            this.ExitChangeNamePanel.Name = "ExitChangeNamePanel";
            this.ExitChangeNamePanel.Size = new System.Drawing.Size(18, 19);
            this.ExitChangeNamePanel.TabIndex = 13;
            this.ExitChangeNamePanel.Text = "X";
            this.ExitChangeNamePanel.Click += new System.EventHandler(this.ExitChangeNamePanel_Click);
            // 
            // ChangeNameTextBox
            // 
            this.ChangeNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ChangeNameTextBox.Location = new System.Drawing.Point(3, 33);
            this.ChangeNameTextBox.Name = "ChangeNameTextBox";
            this.ChangeNameTextBox.Size = new System.Drawing.Size(197, 27);
            this.ChangeNameTextBox.TabIndex = 1;
            // 
            // SetNewNameButton
            // 
            this.SetNewNameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SetNewNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetNewNameButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SetNewNameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SetNewNameButton.Location = new System.Drawing.Point(3, 66);
            this.SetNewNameButton.Name = "SetNewNameButton";
            this.SetNewNameButton.Size = new System.Drawing.Size(197, 29);
            this.SetNewNameButton.TabIndex = 8;
            this.SetNewNameButton.Text = "Set";
            this.SetNewNameButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetNewNameButton.UseVisualStyleBackColor = false;
            this.SetNewNameButton.Click += new System.EventHandler(this.SetNewNameButton_Click);
            // 
            // DesiredNameLabel
            // 
            this.DesiredNameLabel.AutoSize = true;
            this.DesiredNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredNameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DesiredNameLabel.Location = new System.Drawing.Point(3, 9);
            this.DesiredNameLabel.Name = "DesiredNameLabel";
            this.DesiredNameLabel.Size = new System.Drawing.Size(121, 21);
            this.DesiredNameLabel.TabIndex = 8;
            this.DesiredNameLabel.Text = "Desired name:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1076, 483);
            this.Controls.Add(this.ChangeNamePanel);
            this.Controls.Add(this.changeNameButton);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.CustomizeLabel);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddNewChoiceButton);
            this.Controls.Add(this.CustomizeComboBox);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ChangeNamePanel.ResumeLayout(false);
            this.ChangeNamePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustomizeComboBox;
        private System.Windows.Forms.Button AddNewChoiceButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label CustomizeLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.Panel ChangeNamePanel;
        private System.Windows.Forms.Label ExitChangeNamePanel;
        private System.Windows.Forms.TextBox ChangeNameTextBox;
        private System.Windows.Forms.Button SetNewNameButton;
        private System.Windows.Forms.Label DesiredNameLabel;
    }
}