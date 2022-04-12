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
    public partial class SquareRoot : Form
    {
        public SquareRoot()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to find the square root
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            string num = numberInput.Text;
            double result = Convert.ToDouble(num);

            numberOutput.Text = string.Format("Square root of {0} is {1}.", num, Math.Sqrt(result));

        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            numberInput.Text = "";
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
