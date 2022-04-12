
namespace CalculatorGUI
{
    partial class MinMax
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
            this.numberInputTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.numberOutputMax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberInputOne = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOutputMin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberInputTwo
            // 
            this.numberInputTwo.Location = new System.Drawing.Point(227, 65);
            this.numberInputTwo.Name = "numberInputTwo";
            this.numberInputTwo.Size = new System.Drawing.Size(100, 20);
            this.numberInputTwo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Enter the second number:";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(374, 101);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 29;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(374, 62);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 28;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(374, 25);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 27;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // numberOutputMax
            // 
            this.numberOutputMax.AutoSize = true;
            this.numberOutputMax.Location = new System.Drawing.Point(139, 101);
            this.numberOutputMax.Name = "numberOutputMax";
            this.numberOutputMax.Size = new System.Drawing.Size(0, 13);
            this.numberOutputMax.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Maximum:";
            // 
            // numberInputOne
            // 
            this.numberInputOne.Location = new System.Drawing.Point(227, 29);
            this.numberInputOne.Name = "numberInputOne";
            this.numberInputOne.Size = new System.Drawing.Size(100, 20);
            this.numberInputOne.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Enter the first number:";
            // 
            // numberOutputMin
            // 
            this.numberOutputMin.AutoSize = true;
            this.numberOutputMin.Location = new System.Drawing.Point(139, 129);
            this.numberOutputMin.Name = "numberOutputMin";
            this.numberOutputMin.Size = new System.Drawing.Size(0, 13);
            this.numberOutputMin.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Minimum:";
            // 
            // MinMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 161);
            this.Controls.Add(this.numberOutputMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberInputTwo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.numberOutputMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberInputOne);
            this.Controls.Add(this.label1);
            this.Name = "MinMax";
            this.Text = "MinMax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberInputTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label numberOutputMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberInputOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numberOutputMin;
        private System.Windows.Forms.Label label5;
    }
}