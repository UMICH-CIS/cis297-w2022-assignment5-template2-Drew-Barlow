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
    public partial class RemoveWhitespace : Form
    {
        public RemoveWhitespace()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to remove whitespace from a string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stringModifyButton_Click(object sender, EventArgs e)
        {
            noWhitespacesStr.Text = originalString.Text.Replace(" ", "");
        }

        /// <summary>
        /// Function to reset the function inputs
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

        /// <summary>
        /// Function to return to the main calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            originalString.Text = "";
            noWhitespacesStr.Text = "";
        }
    }
}
