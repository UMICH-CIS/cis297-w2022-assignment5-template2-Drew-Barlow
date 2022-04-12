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
    public partial class NumberToPower : Form
    {
        public NumberToPower()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to raise a number to a specific power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            string numInput = numberInput.Text;
            string powInput = powerInput.Text;
            double result = Convert.ToDouble(numInput);
            double result2 = Convert.ToDouble(powInput);

            numberOutput.Text = string.Format("{0} to the power {1} is {2}.", result, result2, Math.Pow(result, result2));
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInput.Text = "";
            powerInput.Text = "";
            numberOutput.Text = "";
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
