namespace WinFormsApp1
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            textBox1 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.Location = new Point(23, 212);
            button7.Name = "button7";
            button7.Size = new Size(98, 65);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Numbers_Clicked;
            // 
            // button8
            // 
            button8.Location = new Point(127, 212);
            button8.Name = "button8";
            button8.Size = new Size(101, 65);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Numbers_Clicked;
            // 
            // button9
            // 
            button9.Location = new Point(234, 212);
            button9.Name = "button9";
            button9.Size = new Size(98, 65);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Numbers_Clicked;
            // 
            // button1
            // 
            button1.Location = new Point(23, 354);
            button1.Name = "button1";
            button1.Size = new Size(98, 65);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Numbers_Clicked;
            // 
            // button2
            // 
            button2.Location = new Point(127, 354);
            button2.Name = "button2";
            button2.Size = new Size(101, 65);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Numbers_Clicked;
            // 
            // button3
            // 
            button3.Location = new Point(234, 354);
            button3.Name = "button3";
            button3.Size = new Size(98, 65);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Numbers_Clicked;
            // 
            // button4
            // 
            button4.Location = new Point(23, 283);
            button4.Name = "button4";
            button4.Size = new Size(98, 65);
            button4.TabIndex = 14;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Numbers_Clicked;
            // 
            // button5
            // 
            button5.Location = new Point(127, 283);
            button5.Name = "button5";
            button5.Size = new Size(101, 65);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Numbers_Clicked;
            // 
            // button6
            // 
            button6.Location = new Point(234, 283);
            button6.Name = "button6";
            button6.Size = new Size(98, 65);
            button6.TabIndex = 12;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Numbers_Clicked;
            // 
            // button10
            // 
            button10.Location = new Point(339, 283);
            button10.Name = "button10";
            button10.Size = new Size(98, 65);
            button10.TabIndex = 17;
            button10.Text = "-";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Operation_Clicked;
            // 
            // button11
            // 
            button11.Location = new Point(338, 212);
            button11.Name = "button11";
            button11.Size = new Size(98, 65);
            button11.TabIndex = 16;
            button11.Text = "x";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Operation_Clicked;
            // 
            // button12
            // 
            button12.Location = new Point(339, 354);
            button12.Name = "button12";
            button12.Size = new Size(98, 65);
            button12.TabIndex = 15;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Operation_Clicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(22, 71);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(414, 35);
            textBox1.TabIndex = 18;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // button13
            // 
            button13.Location = new Point(338, 428);
            button13.Name = "button13";
            button13.Size = new Size(98, 65);
            button13.TabIndex = 21;
            button13.Text = "=";
            button13.UseVisualStyleBackColor = true;
            button13.Click += OnButtonResultClicked;
            // 
            // button14
            // 
            button14.Location = new Point(23, 428);
            button14.Name = "button14";
            button14.Size = new Size(205, 65);
            button14.TabIndex = 20;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Numbers_Clicked;
            // 
            // button15
            // 
            button15.Location = new Point(234, 428);
            button15.Name = "button15";
            button15.Size = new Size(98, 65);
            button15.TabIndex = 19;
            button15.Text = ".";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OnSeparatorClicked;
            // 
            // button16
            // 
            button16.Location = new Point(338, 141);
            button16.Name = "button16";
            button16.Size = new Size(98, 65);
            button16.TabIndex = 22;
            button16.Text = "÷";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Operation_Clicked;
            // 
            // button17
            // 
            button17.Location = new Point(23, 141);
            button17.Name = "button17";
            button17.Size = new Size(98, 65);
            button17.TabIndex = 23;
            button17.Text = "CE";
            button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(130, 141);
            button18.Name = "button18";
            button18.Size = new Size(98, 65);
            button18.TabIndex = 24;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            button18.Click += OnClearClicked;
            // 
            // button19
            // 
            button19.Location = new Point(234, 141);
            button19.Name = "button19";
            button19.Size = new Size(98, 65);
            button19.TabIndex = 25;
            button19.Text = "±";
            button19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 522);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(textBox1);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button10;
        private Button button11;
        private Button button12;
        private TextBox textBox1;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
    }
}