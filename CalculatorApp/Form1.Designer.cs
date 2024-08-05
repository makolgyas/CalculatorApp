
namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num1 = new Button();
            num2 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            num3 = new Button();
            zeroButton = new Button();
            num9 = new Button();
            clearButton = new Button();
            equalButton = new Button();
            plusButton = new Button();
            devideButton = new Button();
            minusButton = new Button();
            multiplyButton = new Button();
            calculatorDisplay = new Label();
            decimalButton = new Button();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num1.Location = new Point(12, 368);
            num1.Name = "num1";
            num1.Size = new Size(80, 70);
            num1.TabIndex = 6;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += num1_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num2.Location = new Point(98, 368);
            num2.Name = "num2";
            num2.Size = new Size(80, 70);
            num2.TabIndex = 7;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += num2_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num8.Location = new Point(98, 216);
            num8.Name = "num8";
            num8.Size = new Size(80, 70);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num7.Location = new Point(12, 216);
            num7.Name = "num7";
            num7.Size = new Size(80, 70);
            num7.TabIndex = 9;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num6.Location = new Point(184, 292);
            num6.Name = "num6";
            num6.Size = new Size(80, 70);
            num6.TabIndex = 10;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num5.Location = new Point(98, 292);
            num5.Name = "num5";
            num5.Size = new Size(80, 70);
            num5.TabIndex = 11;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num4.Location = new Point(12, 292);
            num4.Name = "num4";
            num4.Size = new Size(80, 70);
            num4.TabIndex = 12;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += num4_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num3.Location = new Point(184, 368);
            num3.Name = "num3";
            num3.Size = new Size(80, 70);
            num3.TabIndex = 13;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += num3_Click;
            // 
            // zeroButton
            // 
            zeroButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            zeroButton.Location = new Point(12, 444);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(166, 70);
            zeroButton.TabIndex = 14;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += zeroButton_Click;
            // 
            // num9
            // 
            num9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            num9.Location = new Point(184, 216);
            num9.Name = "num9";
            num9.Size = new Size(80, 70);
            num9.TabIndex = 15;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += num9_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            clearButton.Location = new Point(12, 140);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(252, 70);
            clearButton.TabIndex = 16;
            clearButton.Text = "C";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // equalButton
            // 
            equalButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            equalButton.Location = new Point(270, 444);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(80, 70);
            equalButton.TabIndex = 17;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = true;
            equalButton.Click += equalButton_Click;
            // 
            // plusButton
            // 
            plusButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            plusButton.Location = new Point(270, 368);
            plusButton.Name = "plusButton";
            plusButton.Size = new Size(80, 70);
            plusButton.TabIndex = 21;
            plusButton.Text = "+";
            plusButton.UseVisualStyleBackColor = true;
            plusButton.Click += plusButton_Click;
            // 
            // devideButton
            // 
            devideButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            devideButton.Location = new Point(270, 140);
            devideButton.Name = "devideButton";
            devideButton.Size = new Size(80, 70);
            devideButton.TabIndex = 20;
            devideButton.Text = "/";
            devideButton.UseVisualStyleBackColor = true;
            devideButton.Click += devideButton_Click;
            // 
            // minusButton
            // 
            minusButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            minusButton.Location = new Point(270, 292);
            minusButton.Name = "minusButton";
            minusButton.Size = new Size(80, 70);
            minusButton.TabIndex = 19;
            minusButton.Text = "-";
            minusButton.UseVisualStyleBackColor = true;
            minusButton.Click += minusButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            multiplyButton.Location = new Point(270, 216);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(80, 70);
            multiplyButton.TabIndex = 18;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // calculatorDisplay
            // 
            calculatorDisplay.BackColor = SystemColors.ControlLight;
            calculatorDisplay.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            calculatorDisplay.Location = new Point(12, 25);
            calculatorDisplay.Name = "calculatorDisplay";
            calculatorDisplay.Size = new Size(335, 93);
            calculatorDisplay.TabIndex = 22;
            calculatorDisplay.Text = "0";
            // 
            // decimalButton
            // 
            decimalButton.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            decimalButton.Location = new Point(184, 444);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(80, 70);
            decimalButton.TabIndex = 23;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = true;
            decimalButton.Click += decimalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 524);
            Controls.Add(decimalButton);
            Controls.Add(calculatorDisplay);
            Controls.Add(plusButton);
            Controls.Add(devideButton);
            Controls.Add(minusButton);
            Controls.Add(multiplyButton);
            Controls.Add(equalButton);
            Controls.Add(clearButton);
            Controls.Add(num9);
            Controls.Add(zeroButton);
            Controls.Add(num3);
            Controls.Add(num4);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button num1;
        private Button num2;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button num3;
        private Button zeroButton;
        private Button num9;
        private Button clearButton;
        private Button equalButton;
        private Button plusButton;
        private Button devideButton;
        private Button minusButton;
        private Button multiplyButton;
        private Label calculatorDisplay;
        private Button decimalButton;
    }
}
