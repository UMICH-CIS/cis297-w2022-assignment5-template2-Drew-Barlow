
namespace CalculatorGUI
{
    partial class QuotientAndRemainder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.quotientResult = new System.Windows.Forms.Label();
            this.quotientSolveButton = new System.Windows.Forms.Button();
            this.divisorInputBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dividentInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetButton);
            this.panel1.Controls.Add(this.returnButton);
            this.panel1.Controls.Add(this.quotientResult);
            this.panel1.Controls.Add(this.quotientSolveButton);
            this.panel1.Controls.Add(this.divisorInputBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dividentInputBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 165);
            this.panel1.TabIndex = 35;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(427, 62);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(427, 95);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 9;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // quotientResult
            // 
            this.quotientResult.AutoSize = true;
            this.quotientResult.BackColor = System.Drawing.SystemColors.Control;
            this.quotientResult.Location = new System.Drawing.Point(63, 105);
            this.quotientResult.Name = "quotientResult";
            this.quotientResult.Size = new System.Drawing.Size(0, 13);
            this.quotientResult.TabIndex = 7;
            // 
            // quotientSolveButton
            // 
            this.quotientSolveButton.Location = new System.Drawing.Point(427, 26);
            this.quotientSolveButton.Name = "quotientSolveButton";
            this.quotientSolveButton.Size = new System.Drawing.Size(75, 23);
            this.quotientSolveButton.TabIndex = 6;
            this.quotientSolveButton.Text = "Solve";
            this.quotientSolveButton.UseVisualStyleBackColor = true;
            this.quotientSolveButton.Click += new System.EventHandler(this.quotientSolveButton_Click);
            // 
            // divisorInputBox
            // 
            this.divisorInputBox.Location = new System.Drawing.Point(169, 65);
            this.divisorInputBox.Name = "divisorInputBox";
            this.divisorInputBox.Size = new System.Drawing.Size(68, 20);
            this.divisorInputBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the divisor number:\r\n ";
            // 
            // dividentInputBox
            // 
            this.dividentInputBox.Location = new System.Drawing.Point(169, 36);
            this.dividentInputBox.Name = "dividentInputBox";
            this.dividentInputBox.Size = new System.Drawing.Size(68, 20);
            this.dividentInputBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the divident number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:";
            // 
            // QuotientAndRemainder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 164);
            this.Controls.Add(this.panel1);
            this.Name = "QuotientAndRemainder";
            this.Text = "Quotient and Remainder";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label quotientResult;
        private System.Windows.Forms.Button quotientSolveButton;
        private System.Windows.Forms.TextBox divisorInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dividentInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button resetButton;
    }
}