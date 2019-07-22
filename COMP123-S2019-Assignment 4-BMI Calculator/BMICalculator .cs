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
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void ImperialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ImperialGroupbox.Visible = true;
            MetricGroupBox.Visible = false;
        }

        private void MetricRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MetricGroupBox.Visible = true;
            ImperialGroupbox.Visible = false;
        }
    }
}
