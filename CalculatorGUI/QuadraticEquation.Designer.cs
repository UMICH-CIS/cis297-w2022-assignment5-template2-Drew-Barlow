
namespace CalculatorGUI
{
    partial class QuadraticEquation
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
            this.coeNumberA = new System.Windows.Forms.TextBox();
            this.coeNumberB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.constNumberC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rootsOutput = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.solveButton = new System.Windows.Forms.Button();
            this.rootsOutput2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the coefficient number a:";
            // 
            // coeNumberA
            // 
            this.coeNumberA.Location = new System.Drawing.Point(246, 30);
            this.coeNumberA.Name = "coeNumberA";
            this.coeNumberA.Size = new System.Drawing.Size(100, 20);
            this.coeNumberA.TabIndex = 1;
            // 
            // coeNumberB
            // 
            this.coeNumberB.Location = new System.Drawing.Point(246, 53);
            this.coeNumberB.Name = "coeNumberB";
            this.coeNumberB.Size = new System.Drawing.Size(100, 20);
            this.coeNumberB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the coefficient number b:";
            // 
            // constNumberC
            // 
            this.constNumberC.Location = new System.Drawing.Point(246, 76);
            this.constNumberC.Name = "constNumberC";
            this.constNumberC.Size = new System.Drawing.Size(100, 20);
            this.constNumberC.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter the constant number c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result: ";
            // 
            // rootsOutput
            // 
            this.rootsOutput.AutoSize = true;
            this.rootsOutput.Location = new System.Drawing.Point(140, 110);
            this.rootsOutput.Name = "rootsOutput";
            this.rootsOutput.Size = new System.Drawing.Size(0, 13);
            this.rootsOutput.TabIndex = 7;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(370, 105);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 23;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(370, 66);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 22;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(370, 29);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 23);
            this.solveButton.TabIndex = 21;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // rootsOutput2
            // 
            this.rootsOutput2.AutoSize = true;
            this.rootsOutput2.Location = new System.Drawing.Point(140, 123);
            this.rootsOutput2.Name = "rootsOutput2";
            this.rootsOutput2.Size = new System.Drawing.Size(0, 13);
            this.rootsOutput2.TabIndex = 24;
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 161);
            this.Controls.Add(this.rootsOutput2);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.rootsOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.constNumberC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coeNumberB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.coeNumberA);
            this.Controls.Add(this.label1);
            this.Name = "QuadraticEquation";
            this.Text = "QuadraticEquation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coeNumberA;
        private System.Windows.Forms.TextBox coeNumberB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox constNumberC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rootsOutput;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label rootsOutput2;
    }
}