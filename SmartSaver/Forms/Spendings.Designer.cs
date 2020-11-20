namespace SmartSaver.Forms
{
    partial class Spendings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SpendingsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LimitProgressBar = new CircularProgressBar.CircularProgressBar();
            this.DollarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpendingsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView.Location = new System.Drawing.Point(696, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(380, 483);
            this.dataGridView.TabIndex = 17;
            // 
            // SpendingsChart
            // 
            this.SpendingsChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.Name = "ChartArea1";
            this.SpendingsChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.SpendingsChart.Legends.Add(legend4);
            this.SpendingsChart.Location = new System.Drawing.Point(259, 12);
            this.SpendingsChart.Name = "SpendingsChart";
            this.SpendingsChart.Size = new System.Drawing.Size(431, 470);
            this.SpendingsChart.TabIndex = 18;
            this.SpendingsChart.Text = "chart1";
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
            this.LimitProgressBar.Location = new System.Drawing.Point(12, 335);
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
            this.LimitProgressBar.TabIndex = 19;
            this.LimitProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.LimitProgressBar.Value = 68;
            // 
            // DollarLabel
            // 
            this.DollarLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DollarLabel.AutoSize = true;
            this.DollarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.DollarLabel.ForeColor = System.Drawing.Color.Green;
            this.DollarLabel.Location = new System.Drawing.Point(56, 376);
            this.DollarLabel.Name = "DollarLabel";
            this.DollarLabel.Size = new System.Drawing.Size(52, 55);
            this.DollarLabel.TabIndex = 20;
            this.DollarLabel.Text = "€";
            // 
            // Spendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1076, 483);
            this.Controls.Add(this.DollarLabel);
            this.Controls.Add(this.LimitProgressBar);
            this.Controls.Add(this.SpendingsChart);
            this.Controls.Add(this.dataGridView);
            this.Name = "Spendings";
            this.Text = "Spendings";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpendingsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.DataVisualization.Charting.Chart SpendingsChart;
        private CircularProgressBar.CircularProgressBar LimitProgressBar;
        private System.Windows.Forms.Label DollarLabel;
    }
}