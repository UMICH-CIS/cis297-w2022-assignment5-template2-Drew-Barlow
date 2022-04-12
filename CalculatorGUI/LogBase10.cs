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
    public partial class LogBase10 : Form
    {
        public LogBase10()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to log base 10 of a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            string input = numberInput.Text;
            double result = Convert.ToDouble(input);
            logOutput.Text = String.Format("Log({0}) to the base 10 is {1}.", input, Math.Log10(result));
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInput.Text = "";
            logOutput.Text = "";
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
