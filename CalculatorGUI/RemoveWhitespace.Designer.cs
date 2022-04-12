
namespace CalculatorGUI
{
    partial class RemoveWhitespace
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
            this.label2 = new System.Windows.Forms.Label();
            this.stringModifyButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.noWhitespacesStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the string you want to modify:";
            // 
            // originalString
            // 
            this.originalString.Location = new System.Drawing.Point(270, 49);
            this.originalString.Name = "originalString";
            this.originalString.Size = new System.Drawing.Size(100, 20);
            this.originalString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modified string:";
            // 
            // stringModifyButton
            // 
            this.stringModifyButton.Location = new System.Drawing.Point(411, 49);
            this.stringModifyButton.Name = "stringModifyButton";
            this.stringModifyButton.Size = new System.Drawing.Size(75, 23);
            this.stringModifyButton.TabIndex = 7;
            this.stringModifyButton.Text = "Modify";
            this.stringModifyButton.UseVisualStyleBackColor = true;
            this.stringModifyButton.Click += new System.EventHandler(this.stringModifyButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(411, 116);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 10;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(411, 83);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // noWhitespacesStr
            // 
            this.noWhitespacesStr.AutoSize = true;
            this.noWhitespacesStr.Location = new System.Drawing.Point(176, 88);
            this.noWhitespacesStr.Name = "noWhitespacesStr";
            this.noWhitespacesStr.Size = new System.Drawing.Size(0, 13);
            this.noWhitespacesStr.TabIndex = 12;
            // 
            // RemoveWhitespace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 155);
            this.Controls.Add(this.noWhitespacesStr);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.stringModifyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.originalString);
            this.Controls.Add(this.label1);
            this.Name = "RemoveWhitespace";
            this.Text = "Remove Whitespace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox originalString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stringModifyButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label noWhitespacesStr;
    }
}