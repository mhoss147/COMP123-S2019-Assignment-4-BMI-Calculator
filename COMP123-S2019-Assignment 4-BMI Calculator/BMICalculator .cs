using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment_4_BMI_Calculator
{
    public partial class BMICalculator : Form
    {
        public string outputString { get; set; }
        public float outputValue { get; set; }
        public TextBox ActiveTextBox { get; set; }
        public double Result { get; set; }

        public BMICalculator()
        {
            InitializeComponent();

        }


        private void BMICalculator_Load(object sender, EventArgs e)
        {
            clearKeypad();
            ActiveTextBox = heightTextBox;
            heightUnitLabel.Text = "cm";
            weightUnitLabel.Text = "kg";
        }

        private void clearKeypad()
        {
            ResultTextBox.Text = "";
            outputString = "";
            outputValue = 0;
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            ConditionTextBox.Text = "";
            ActiveTextBox = heightTextBox;

        }

        private void CalculatorTableLayoutPanel_Click(object sender, EventArgs e)
        {
            Button TheButton = sender as Button;
            var tag = TheButton.Tag.ToString();
            int numericValue = 0;
            bool numericResult = int.TryParse(tag, out numericValue);
            if (numericResult)
            {
                //outputString += tag;
                //ActiveTextBox.Text = outputString;
                ActiveTextBox.Text += tag;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        outputString = outputString.Remove(outputString.Length - 1);
                        ActiveTextBox.Text = outputString;
                        break;
                    case "clear":
                        clearKeypad();
                        ProgressBar.Value = 0;
                        break;
                    case "calculate":
                        ProgressBar.Value = 0;
                        BMIResult();
                        outputValue = 0;
                        break;
                }
            }

        }

        private void BMIResult()
        {
            if (int.TryParse(heightTextBox.Text, out int myHeight) && int.TryParse(weightTextBox.Text, out int myWeight))
            {
                var height = Convert.ToDouble(heightTextBox.Text);
                var weight = Convert.ToDouble(weightTextBox.Text);
                if (height != 0 && weight != 0)
                {
                    if (metricButton.Checked == true)
                    {
                        Result = (weight / height / height) * 10000;
                        ResultTextBox.Text = string.Format($"{Result:F1}").ToString();

                        DisplayCondition();
                    }
                    else if (ImperialButton.Checked == true)
                    {
                        Result = weight * 703 / (height * height);
                        ResultTextBox.Text = string.Format($"{Result:F1}").ToString();
                        DisplayCondition();
                    }
                }

                else
                {
                    ResultTextBox.Text = "Please enter all values";
                    ResultTextBox.ForeColor = Color.Red;
                }
            }
            else
            {
                ResultTextBox.Text = "Please enter all values";
                ResultTextBox.ForeColor = Color.Red;
            }
        }

        private void DisplayCondition()
        {
            ProgressBar.Maximum = 4;
            if (Result < 18.5)
            {
                ConditionTextBox.Text = "Underweight";
                ConditionTextBox.ForeColor = Color.SaddleBrown;
                ProgressBar.Value += 1;
                ProgressBar.ForeColor = Color.SaddleBrown;
            }
            else if (Result >= 18.5 && Result <= 24.9)
            {
                ConditionTextBox.Text = "Normal";
                ConditionTextBox.ForeColor = Color.Green;
                ProgressBar.Value += 2;
                ProgressBar.ForeColor = Color.Green;
            }
            else if (Result >= 25 && Result <= 29.9)
            {
                ConditionTextBox.Text = "Overweight";
                ConditionTextBox.ForeColor = Color.Orange;
                ProgressBar.Value += 3;
                ProgressBar.ForeColor = Color.Orange;
            }
            else if (Result >= 30)
            {
                ConditionTextBox.Text = "Obese";
                ConditionTextBox.ForeColor = Color.Red;
                ProgressBar.Value += 4;
                ProgressBar.ForeColor = Color.Red;
            }
        }

        private void ActiveTextBox_click(object sender, EventArgs e)
        {
            outputValue = 0;
            outputString = "";
            ActiveTextBox = sender as TextBox;
        }





        //private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
