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
    public partial class QuadraticEquation : Form
    {
        public QuadraticEquation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to find the roots using the quadratic equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void solveButton_Click(object sender, EventArgs e)
        {
            Boolean status = true;
            double X1 = 0;
            double X2 = 0;

            string inputA = coeNumberA.Text;
            string inputB = coeNumberB.Text;
            string inputC = constNumberC.Text;

            double A = Convert.ToDouble(inputA);
            double B = Convert.ToDouble(inputB);
            double C = Convert.ToDouble(inputC);

            double Discriminant = Math.Pow(B, 2) - 4 * A * C;

            if (Discriminant == 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = -B / (2 * A);
                    X2 = X1;
                }

            }
            else if (Discriminant > 0)
            {
                if (A == 0)
                {

                    status = false;

                }
                else
                {
                    X1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                    X2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                }

            }
            else
            {
                status = false;
            }

            if (status)
            {
                if (X1 == X2)
                {
                    rootsOutput.Text = string.Format($"The equation has one root: {X1}");
                }
                else
                {
                    rootsOutput.Text = string.Format($"Root X1 = {X1}");
                    rootsOutput2.Text = string.Format($"Root X2 = {X2}");
                }
            }
            else
            {
                rootsOutput.Text = string.Format("Equation has no real roots!");
            }
        }

        /// <summary>
        /// Function to reset the function inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void resetButton_Click(object sender, EventArgs e)
        {
            coeNumberA.Text = "";
            coeNumberB.Text = "";
            constNumberC.Text = "";
            rootsOutput.Text = "";
            rootsOutput2.Text = "";
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
