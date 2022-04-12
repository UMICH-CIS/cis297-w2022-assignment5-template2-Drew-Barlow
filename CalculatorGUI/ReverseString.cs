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
    public partial class ReverseString : Form
    {
        public ReverseString()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to reverse a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stringModifyButton_Click(object sender, EventArgs e)
        {
            char[] charArray = originalString.Text.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);
            reversedString.Text = reverse;
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            originalString.Text = "";
            reversedString.Text = "";
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
