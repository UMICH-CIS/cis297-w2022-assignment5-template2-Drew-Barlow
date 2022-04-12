using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorGUI
{
    public partial class MinMax : Form
    {
        public MinMax()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to find minimum and maximum of two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            string input = numberInputOne.Text;
            string input2 = numberInputTwo.Text;

            double num1 = Convert.ToDouble(input);
            double num2 = Convert.ToDouble(input2);

            numberOutputMax.Text = string.Format("Maximum of {0} and {1} is {2}.", num1, num2, Math.Max(num1, num2));
            numberOutputMin.Text = string.Format("Minimum of {0} and {1} is {2}.", num1, num2, Math.Min(num1, num2));
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInputOne.Text = "";
            numberInputTwo.Text = "";
            numberOutputMax.Text = "";
            numberOutputMin.Text = "";
        }
        /// <summary>
        /// Function to return to the main calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorGUIForm f1 = new CalculatorGUIForm();
            f1.ShowDialog();
            this.Close();
        }
    }
}
