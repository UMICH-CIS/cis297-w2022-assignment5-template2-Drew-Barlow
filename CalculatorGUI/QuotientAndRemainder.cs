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
    public partial class QuotientAndRemainder : Form
    {
        public QuotientAndRemainder()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to find the quotient and remainder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quotientSolveButton_Click(object sender, EventArgs e)
        {
            string dividentInput;
            string divisorInput;
            long divident;
            long divisor;

            dividentInput = dividentInputBox.Text;
            divident = Convert.ToInt64(dividentInput);

            divisorInput = divisorInputBox.Text;
            divisor = Convert.ToInt64(divisorInput);
            long remainder;
            long quotient = Math.DivRem(divident, divisor, out remainder);

            quotientResult.Text = String.Format("{0} divided by {1} results in {2} as the quotient and {3} as the remainder.", divident, divisor, quotient, remainder);

        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculatorGUIForm f1 = new CalculatorGUIForm();
            f1.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Function to return to the main calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            dividentInputBox.Text = "";
            divisorInputBox.Text = "";
            quotientResult.Text = "";
        }
    }
}
