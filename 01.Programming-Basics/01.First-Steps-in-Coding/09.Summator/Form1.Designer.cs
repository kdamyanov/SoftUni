namespace _09.Summator
{
    partial class formCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.numberOne = new System.Windows.Forms.TextBox();
            this.numberTwo = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "=";
            // 
            // numberOne
            // 
            this.numberOne.Location = new System.Drawing.Point(23, 45);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(100, 22);
            this.numberOne.TabIndex = 2;
            // 
            // numberTwo
            // 
            this.numberTwo.Location = new System.Drawing.Point(169, 47);
            this.numberTwo.Name = "numberTwo";
            this.numberTwo.Size = new System.Drawing.Size(100, 22);
            this.numberTwo.TabIndex = 3;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(327, 47);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(100, 22);
            this.sum.TabIndex = 4;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(141, 127);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(166, 40);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculator";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // formCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 253);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.numberTwo);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberOne;
        private System.Windows.Forms.TextBox numberTwo;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Button calcBtn;
    }
}

