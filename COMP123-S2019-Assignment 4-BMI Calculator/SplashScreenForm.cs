using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* COMP123 - S2019 - Assignment4 - BMI Calculator
 * Author: Mohammad S Hossain
 * ID# 300763479
 * Version: 1.1 
 * Last modified: July 26, 2019
 */
namespace COMP123_S2019_Assignment_4_BMI_Calculator
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
        }
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = true;
        }
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            Program.bmiCalculator.Show();
            this.Hide();
            Program.splashScreenForm.Close();
            

        }
    }
}
