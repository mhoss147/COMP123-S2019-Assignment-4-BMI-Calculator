using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* COMP123 - S2019 - Assignment4 - BMI Calculator
 * Author: Mohammad S Hossain
 * ID# 300763479
 * Version: 3.3 
 * Last modified: July 26, 2019
 */
namespace COMP123_S2019_Assignment_4_BMI_Calculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static BMICalculator bmiCalculator;

        public static SplashScreenForm splashScreenForm;

        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashScreenForm = new SplashScreenForm();
            bmiCalculator = new BMICalculator();
            Application.Run(new SplashScreenForm());
        }
    }
}
