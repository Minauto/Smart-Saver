namespace SmartSaver
{
    partial class DepositWindow
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
            this.addADepositLbl = new System.Windows.Forms.Label();
            this.enterAmountLbl = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addADepositLbl
            // 
            this.addADepositLbl.AutoSize = true;
            this.addADepositLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addADepositLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addADepositLbl.Location = new System.Drawing.Point(8, 9);
            this.addADepositLbl.Name = "addADepositLbl";
            this.addADepositLbl.Size = new System.Drawing.Size(214, 36);
            this.addADepositLbl.TabIndex = 0;
            this.addADepositLbl.Text = "Add a deposit";
            this.addADepositLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterAmountLbl
            // 
            this.enterAmountLbl.AutoSize = true;
            this.enterAmountLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.enterAmountLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterAmountLbl.Location = new System.Drawing.Point(12, 79);
            this.enterAmountLbl.Name = "enterAmountLbl";
            this.enterAmountLbl.Size = new System.Drawing.Size(217, 22);
            this.enterAmountLbl.TabIndex = 1;
            this.enterAmountLbl.Text = "Enter the amount in €: ";
            this.enterAmountLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(240, 79);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(261, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.addButton.Location = new System.Drawing.Point(507, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 20);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DepositWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(641, 134);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.enterAmountLbl);
            this.Controls.Add(this.addADepositLbl);
            this.Name = "DepositWindow";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addADepositLbl;
        private System.Windows.Forms.Label enterAmountLbl;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Button addButton;
    }
}