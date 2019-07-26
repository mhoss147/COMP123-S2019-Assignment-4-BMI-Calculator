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
            WeightUnitLabel.Text = "kg";
        }

        /// <summary>
        /// This is the Event Handler for the MetricRadioButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MetricRadioButton_Click(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "cm";
            WeightUnitLabel.Text = "kg";
        }
        /// <summary>
        /// This is the Event Handler for the ImperialRadioButton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImperialRadioButton_Click(object sender, EventArgs e)
        {
            heightUnitLabel.Text = "in";
            WeightUnitLabel.Text = "lb";
        }
        private void clearKeypad()
        {
            ResultTextBox.Text = "";
            outputString = " ";
            outputValue = 0;
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            ConditionTextBox.Text = "";
            ActiveTextBox = heightTextBox;

        }



        private void CalculatorTableLayoutPanel_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            var tag = button.Tag.ToString();
            int numericValue = 0;
            bool numericResult = int.TryParse(tag, out numericValue);
            if (numericResult)
            {
                outputString += tag;
               ActiveTextBox.Text = outputString;
                //ActiveTextBox.Text += tag;
            }
            else
            {
                switch (tag)
                {
                    case "backspace":
                        try
                        {
                            outputString = outputString.Remove(outputString.Length - 1);
                            ActiveTextBox.Text = outputString;
                        } catch
                        {
                            MessageBox.Show("To erase, Click inside the cell and use Keyboard backspace");
                        }
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
                    ResultTextBox.Text = "Please fill out form";
                    ResultTextBox.ForeColor = Color.Red;
                }
            }
            else
            {
                ResultTextBox.Text = "Please fill out form";
                ResultTextBox.ForeColor = Color.Red;
            }
        }

        private void DisplayCondition()
        {
            ProgressBar.Maximum = 4;
            if (Result < 18.5)
            {
                ConditionTextBox.Text = "Under Weight";
                ConditionTextBox.ForeColor = Color.Yellow;
                ProgressBar.Value += 1;
                ProgressBar.ForeColor = Color.Yellow;
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
                ConditionTextBox.Text = "Over Weight";
                ConditionTextBox.ForeColor = Color.DeepPink;
                ProgressBar.Value += 3;
                ProgressBar.ForeColor = Color.DeepPink;
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
            outputString = "0";
            ActiveTextBox = sender as TextBox;
        }
        
    }
}
