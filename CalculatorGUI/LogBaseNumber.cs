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
    public partial class LogBaseNumber : Form
    {
        public LogBaseNumber()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to find the log of a number with specific log base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            string numInput = numberInput.Text;
            string basInput = baseInput.Text;
            double result = Convert.ToDouble(numInput);
            double result2 = Convert.ToDouble(basInput);

            logOutput.Text = String.Format("Log({0}) to the base {1} is {2}.", result, result2, Math.Log(result, result2));
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInput.Text = "";
            baseInput.Text = "";
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
