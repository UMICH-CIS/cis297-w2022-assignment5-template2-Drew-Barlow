
namespace CalculatorGUI
{
    partial class ReverseString
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
            this.originalString = new System.Windows.Forms.TextBox();
            this.stringModifyButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reversedString = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the string you want to modify:";
            // 
            // originalString
            // 
            this.originalString.Location = new System.Drawing.Point(253, 60);
            this.originalString.Name = "originalString";
            this.originalString.Size = new System.Drawing.Size(100, 20);
            this.originalString.TabIndex = 2;
            // 
            // stringModifyButton
            // 
            this.stringModifyButton.Location = new System.Drawing.Point(387, 57);
            this.stringModifyButton.Name = "stringModifyButton";
            this.stringModifyButton.Size = new System.Drawing.Size(75, 23);
            this.stringModifyButton.TabIndex = 8;
            this.stringModifyButton.Text = "Modify";
            this.stringModifyButton.UseVisualStyleBackColor = true;
            this.stringModifyButton.Click += new System.EventHandler(this.stringModifyButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(387, 86);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 12;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(387, 115);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 13;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Modified string:";
            // 
            // reversedString
            // 
            this.reversedString.AutoSize = true;
            this.reversedString.Location = new System.Drawing.Point(160, 91);
            this.reversedString.Name = "reversedString";
            this.reversedString.Size = new System.Drawing.Size(0, 13);
            this.reversedString.TabIndex = 15;
            // 
            // ReverseString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 216);
            this.Controls.Add(this.reversedString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stringModifyButton);
            this.Controls.Add(this.originalString);
            this.Controls.Add(this.label1);
            this.Name = "ReverseString";
            this.Text = "Reverse String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalString;
        private System.Windows.Forms.Button stringModifyButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label reversedString;
    }
}