
namespace CalculatorGUI
{
    partial class SquareRoot
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberInput = new System.Windows.Forms.TextBox();
            this.returnButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number:";
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(203, 33);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(100, 20);
            this.numberInput.TabIndex = 1;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(369, 109);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 23;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(369, 70);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(369, 33);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 21;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Result:";
            // 
            // numberOutput
            // 
            this.numberOutput.AutoSize = true;
            this.numberOutput.Location = new System.Drawing.Point(151, 68);
            this.numberOutput.Name = "numberOutput";
            this.numberOutput.Size = new System.Drawing.Size(0, 13);
            this.numberOutput.TabIndex = 25;
            // 
            // SquareRoot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 161);
            this.Controls.Add(this.numberOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.label1);
            this.Name = "SquareRoot";
            this.Text = "SquareRoot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numberOutput;
    }
}