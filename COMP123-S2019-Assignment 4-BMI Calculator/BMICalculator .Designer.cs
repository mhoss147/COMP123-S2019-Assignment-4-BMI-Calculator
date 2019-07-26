namespace COMP123_S2019_Assignment_4_BMI_Calculator
{
    partial class BMICalculator
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
            this.BMICalculatorLabel = new System.Windows.Forms.Label();
            this.metricButton = new System.Windows.Forms.RadioButton();
            this.ImperialButton = new System.Windows.Forms.RadioButton();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.calculateBMIButton = new System.Windows.Forms.Button();
            this.ConditionTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.HeightTextLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMITextLabel = new System.Windows.Forms.Label();
            this.YourConditionLabel = new System.Windows.Forms.Label();
            this.heightUnitLabel = new System.Windows.Forms.Label();
            this.WeightTextLabel = new System.Windows.Forms.Label();
            this.CalculatorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorLabel
            // 
            this.BMICalculatorLabel.AutoSize = true;
            this.BMICalculatorLabel.Location = new System.Drawing.Point(480, -55);
            this.BMICalculatorLabel.Name = "BMICalculatorLabel";
            this.BMICalculatorLabel.Size = new System.Drawing.Size(76, 13);
            this.BMICalculatorLabel.TabIndex = 17;
            this.BMICalculatorLabel.Text = "BMI Calculator";
            // 
            // metricButton
            // 
            this.metricButton.AutoSize = true;
            this.metricButton.Checked = true;
            this.metricButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metricButton.Location = new System.Drawing.Point(120, 12);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(89, 29);
            this.metricButton.TabIndex = 21;
            this.metricButton.TabStop = true;
            this.metricButton.Text = "Metric";
            this.metricButton.UseVisualStyleBackColor = true;
            this.metricButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_Click);
            this.metricButton.Click += new System.EventHandler(this.MetricRadioButton_Click);
            // 
            // ImperialButton
            // 
            this.ImperialButton.AutoSize = true;
            this.ImperialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialButton.Location = new System.Drawing.Point(8, 12);
            this.ImperialButton.Name = "ImperialButton";
            this.ImperialButton.Size = new System.Drawing.Size(106, 29);
            this.ImperialButton.TabIndex = 22;
            this.ImperialButton.TabStop = true;
            this.ImperialButton.Text = "Imperial";
            this.ImperialButton.UseVisualStyleBackColor = true;
            this.ImperialButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_Click);
            this.ImperialButton.Click += new System.EventHandler(this.ImperialRadioButton_Click);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightTextBox.Location = new System.Drawing.Point(116, 40);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(89, 29);
            this.heightTextBox.TabIndex = 24;
            this.heightTextBox.Tag = "heightTextBox";
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.heightTextBox.Click += new System.EventHandler(this.ActiveTextBox_click);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightTextBox.Location = new System.Drawing.Point(116, 80);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(89, 29);
            this.weightTextBox.TabIndex = 25;
            this.weightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.weightTextBox.Click += new System.EventHandler(this.ActiveTextBox_click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.ForeColor = System.Drawing.Color.Black;
            this.ResultTextBox.Location = new System.Drawing.Point(116, 163);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(169, 29);
            this.ResultTextBox.TabIndex = 26;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateBMIButton
            // 
            this.calculateBMIButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.calculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBMIButton.Location = new System.Drawing.Point(64, 116);
            this.calculateBMIButton.Name = "calculateBMIButton";
            this.calculateBMIButton.Size = new System.Drawing.Size(185, 35);
            this.calculateBMIButton.TabIndex = 27;
            this.calculateBMIButton.Tag = "calculate";
            this.calculateBMIButton.Text = "Calculate BMI";
            this.calculateBMIButton.UseVisualStyleBackColor = false;
            this.calculateBMIButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // ConditionTextBox
            // 
            this.ConditionTextBox.Enabled = false;
            this.ConditionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionTextBox.ForeColor = System.Drawing.Color.Black;
            this.ConditionTextBox.Location = new System.Drawing.Point(159, 205);
            this.ConditionTextBox.Multiline = true;
            this.ConditionTextBox.Name = "ConditionTextBox";
            this.ConditionTextBox.Size = new System.Drawing.Size(126, 31);
            this.ConditionTextBox.TabIndex = 29;
            // 
            // CalculatorTableLayoutPanel
            // 
            this.CalculatorTableLayoutPanel.ColumnCount = 3;
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.CalculatorTableLayoutPanel.Controls.Add(this.backspaceButton, 0, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.clearButton, 2, 3);
            this.CalculatorTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.OneButton, 0, 2);
            this.CalculatorTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.CalculatorTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.CalculatorTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 3);
            this.CalculatorTableLayoutPanel.Location = new System.Drawing.Point(8, 283);
            this.CalculatorTableLayoutPanel.Name = "CalculatorTableLayoutPanel";
            this.CalculatorTableLayoutPanel.RowCount = 4;
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CalculatorTableLayoutPanel.Size = new System.Drawing.Size(280, 144);
            this.CalculatorTableLayoutPanel.TabIndex = 30;
            this.CalculatorTableLayoutPanel.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.backspaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspaceButton.Location = new System.Drawing.Point(3, 111);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(87, 30);
            this.backspaceButton.TabIndex = 12;
            this.backspaceButton.Tag = "backspace";
            this.backspaceButton.Text = "<=";
            this.backspaceButton.UseVisualStyleBackColor = false;
            this.backspaceButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Khaki;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(189, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(87, 30);
            this.clearButton.TabIndex = 11;
            this.clearButton.Tag = "clear";
            this.clearButton.Text = "RESET";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeButton.Location = new System.Drawing.Point(189, 75);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(87, 30);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Tag = "3";
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.SteelBlue;
            this.TwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoButton.Location = new System.Drawing.Point(96, 75);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(87, 30);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Tag = "2";
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.SteelBlue;
            this.OneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneButton.Location = new System.Drawing.Point(3, 75);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(87, 30);
            this.OneButton.TabIndex = 6;
            this.OneButton.Tag = "1";
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixButton.Location = new System.Drawing.Point(189, 39);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(87, 30);
            this.SixButton.TabIndex = 5;
            this.SixButton.Tag = "6";
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveButton.Location = new System.Drawing.Point(96, 39);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(87, 30);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Tag = "5";
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.SteelBlue;
            this.FourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourButton.Location = new System.Drawing.Point(3, 39);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(87, 30);
            this.FourButton.TabIndex = 3;
            this.FourButton.Tag = "4";
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // NineButton
            // 
            this.NineButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineButton.Location = new System.Drawing.Point(189, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(87, 30);
            this.NineButton.TabIndex = 2;
            this.NineButton.Tag = "9";
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = false;
            this.NineButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.SteelBlue;
            this.EightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightButton.Location = new System.Drawing.Point(96, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(87, 30);
            this.EightButton.TabIndex = 1;
            this.EightButton.Tag = "8";
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(87, 30);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Tag = "7";
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ZeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroButton.Location = new System.Drawing.Point(96, 111);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(87, 30);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Tag = "0";
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorTableLayoutPanel_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Enabled = false;
            this.ProgressBar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.ProgressBar.Location = new System.Drawing.Point(9, 254);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(276, 23);
            this.ProgressBar.TabIndex = 31;
            // 
            // HeightTextLabel
            // 
            this.HeightTextLabel.AutoSize = true;
            this.HeightTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextLabel.Location = new System.Drawing.Point(7, 43);
            this.HeightTextLabel.Name = "HeightTextLabel";
            this.HeightTextLabel.Size = new System.Drawing.Size(77, 24);
            this.HeightTextLabel.TabIndex = 34;
            this.HeightTextLabel.Text = "Height:";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightUnitLabel.Location = new System.Drawing.Point(217, 80);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(0, 24);
            this.WeightUnitLabel.TabIndex = 34;
            // 
            // BMITextLabel
            // 
            this.BMITextLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.BMITextLabel.AutoSize = true;
            this.BMITextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextLabel.Location = new System.Drawing.Point(7, 163);
            this.BMITextLabel.Name = "BMITextLabel";
            this.BMITextLabel.Size = new System.Drawing.Size(101, 24);
            this.BMITextLabel.TabIndex = 34;
            this.BMITextLabel.Text = "Your BMI:";
            // 
            // YourConditionLabel
            // 
            this.YourConditionLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.YourConditionLabel.AutoSize = true;
            this.YourConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourConditionLabel.Location = new System.Drawing.Point(7, 205);
            this.YourConditionLabel.Name = "YourConditionLabel";
            this.YourConditionLabel.Size = new System.Drawing.Size(126, 24);
            this.YourConditionLabel.TabIndex = 34;
            this.YourConditionLabel.Text = "Your Health:";
            // 
            // heightUnitLabel
            // 
            this.heightUnitLabel.AutoSize = true;
            this.heightUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightUnitLabel.Location = new System.Drawing.Point(217, 40);
            this.heightUnitLabel.Name = "heightUnitLabel";
            this.heightUnitLabel.Size = new System.Drawing.Size(0, 24);
            this.heightUnitLabel.TabIndex = 34;
            // 
            // WeightTextLabel
            // 
            this.WeightTextLabel.AutoSize = true;
            this.WeightTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextLabel.Location = new System.Drawing.Point(7, 80);
            this.WeightTextLabel.Name = "WeightTextLabel";
            this.WeightTextLabel.Size = new System.Drawing.Size(81, 24);
            this.WeightTextLabel.TabIndex = 34;
            this.WeightTextLabel.Text = "Weight:";
            // 
            // BMICalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(300, 437);
            this.Controls.Add(this.YourConditionLabel);
            this.Controls.Add(this.BMITextLabel);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.heightUnitLabel);
            this.Controls.Add(this.WeightTextLabel);
            this.Controls.Add(this.HeightTextLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CalculatorTableLayoutPanel);
            this.Controls.Add(this.ConditionTextBox);
            this.Controls.Add(this.calculateBMIButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.ImperialButton);
            this.Controls.Add(this.metricButton);
            this.Controls.Add(this.BMICalculatorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculator_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.Click += new System.EventHandler(this.ActiveTextBox_click);
            this.CalculatorTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BMICalculatorLabel;
        private System.Windows.Forms.RadioButton metricButton;
        private System.Windows.Forms.RadioButton ImperialButton;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button calculateBMIButton;
        private System.Windows.Forms.TextBox ConditionTextBox;
        private System.Windows.Forms.TableLayoutPanel CalculatorTableLayoutPanel;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label HeightTextLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.Label BMITextLabel;
        private System.Windows.Forms.Label YourConditionLabel;
        private System.Windows.Forms.Label heightUnitLabel;
        private System.Windows.Forms.Label WeightTextLabel;
    }
}

