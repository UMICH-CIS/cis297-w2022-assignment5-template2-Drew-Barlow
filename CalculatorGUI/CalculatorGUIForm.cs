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
    /// <summary>
    /// This program implements some arithmetic functions as a calculator and uses a windows forms GUI
    /// </summary>
    /// <Student>Drew Barlow</Student>
    /// <Class>CIS297</Class>
    /// <Semester>Winter 2022</Semester>
    public partial class CalculatorGUIForm : Form
   {
        public CalculatorGUIForm()
      {
         InitializeComponent();
      }

        /// <summary>
        /// Button 1. Remove whitespace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveWhitespace f1 = new RemoveWhitespace();
            f1.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 2. Reverse String
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReverseString f2 = new ReverseString();
            f2.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 3.  Display the quotient and the remainder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuotientAndRemainder f3 = new QuotientAndRemainder();
            f3.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 4. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogBase10 f4 = new LogBase10();
            f4.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 5. Find the logarithm of a specified number to a specified base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogBaseNumber f5 = new LogBaseNumber();
            f5.ShowDialog();
            this.Close();
        }
        /// <summary>
        /// Button 6. Display the minimum and maximum of the two numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MinMax f6 = new MinMax();
            f6.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 7. Find the specified number to the specified power
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NumberToPower f7 = new NumberToPower();
            f7.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 8. Find the roots of a quadratic equation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuadraticEquation f8 = new QuadraticEquation();
            f8.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// Button 9. Find the square root of the given number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SquareRoot f9 = new SquareRoot();
            f9.ShowDialog();
            this.Close();
        } 
        
        /// <summary>
        /// Button 10. Exit program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/