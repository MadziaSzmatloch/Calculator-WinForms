﻿namespace WinFormsApp1
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
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonPlus = new Button();
            textBox1 = new TextBox();
            buttonResult = new Button();
            button14 = new Button();
            buttonDot = new Button();
            buttonDivide = new Button();
            buttonClear = new Button();
            button18 = new Button();
            buttonChange = new Button();
            SuspendLayout();
            // 
            // button7
            // 
            button7.BackColor = Color.Thistle;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Location = new Point(23, 212);
            button7.Name = "button7";
            button7.Size = new Size(98, 65);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Numbers_Clicked;
            // 
            // button8
            // 
            button8.BackColor = Color.Thistle;
            button8.FlatStyle = FlatStyle.Popup;
            button8.Location = new Point(127, 212);
            button8.Name = "button8";
            button8.Size = new Size(101, 65);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Numbers_Clicked;
            // 
            // button9
            // 
            button9.BackColor = Color.Thistle;
            button9.FlatStyle = FlatStyle.Popup;
            button9.Location = new Point(234, 212);
            button9.Name = "button9";
            button9.Size = new Size(98, 65);
            button9.TabIndex = 6;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Numbers_Clicked;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(23, 354);
            button1.Name = "button1";
            button1.Size = new Size(98, 65);
            button1.TabIndex = 11;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Numbers_Clicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Thistle;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(127, 354);
            button2.Name = "button2";
            button2.Size = new Size(101, 65);
            button2.TabIndex = 10;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Numbers_Clicked;
            // 
            // button3
            // 
            button3.BackColor = Color.Thistle;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(234, 354);
            button3.Name = "button3";
            button3.Size = new Size(98, 65);
            button3.TabIndex = 9;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Numbers_Clicked;
            // 
            // button4
            // 
            button4.BackColor = Color.Thistle;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(23, 283);
            button4.Name = "button4";
            button4.Size = new Size(98, 65);
            button4.TabIndex = 14;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Numbers_Clicked;
            // 
            // button5
            // 
            button5.BackColor = Color.Thistle;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Location = new Point(127, 283);
            button5.Name = "button5";
            button5.Size = new Size(101, 65);
            button5.TabIndex = 13;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Numbers_Clicked;
            // 
            // button6
            // 
            button6.BackColor = Color.Thistle;
            button6.FlatStyle = FlatStyle.Popup;
            button6.Location = new Point(234, 283);
            button6.Name = "button6";
            button6.Size = new Size(98, 65);
            button6.TabIndex = 12;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Numbers_Clicked;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.Thistle;
            buttonMinus.FlatStyle = FlatStyle.Popup;
            buttonMinus.Location = new Point(339, 283);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(98, 65);
            buttonMinus.TabIndex = 17;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = false;
            buttonMinus.Click += Operation_Clicked;
            // 
            // buttonMultiply
            // 
            buttonMultiply.BackColor = Color.Thistle;
            buttonMultiply.FlatStyle = FlatStyle.Popup;
            buttonMultiply.Location = new Point(338, 212);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(98, 65);
            buttonMultiply.TabIndex = 16;
            buttonMultiply.Text = "x";
            buttonMultiply.UseVisualStyleBackColor = false;
            buttonMultiply.Click += Operation_Clicked;
            // 
            // buttonPlus
            // 
            buttonPlus.BackColor = Color.Thistle;
            buttonPlus.FlatStyle = FlatStyle.Popup;
            buttonPlus.Location = new Point(339, 354);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(98, 65);
            buttonPlus.TabIndex = 15;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = false;
            buttonPlus.Click += Operation_Clicked;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(22, 71);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(414, 29);
            textBox1.TabIndex = 18;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.Thistle;
            buttonResult.FlatStyle = FlatStyle.Popup;
            buttonResult.Location = new Point(338, 428);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(98, 65);
            buttonResult.TabIndex = 21;
            buttonResult.Text = "=";
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += OnButtonResultClicked;
            // 
            // button14
            // 
            button14.BackColor = Color.Thistle;
            button14.FlatStyle = FlatStyle.Popup;
            button14.Location = new Point(23, 428);
            button14.Name = "button14";
            button14.Size = new Size(205, 65);
            button14.TabIndex = 20;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = false;
            button14.Click += Numbers_Clicked;
            // 
            // buttonDot
            // 
            buttonDot.BackColor = Color.Thistle;
            buttonDot.FlatStyle = FlatStyle.Popup;
            buttonDot.Location = new Point(234, 428);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(98, 65);
            buttonDot.TabIndex = 19;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = false;
            buttonDot.Click += OnSeparatorClicked;
            // 
            // buttonDivide
            // 
            buttonDivide.BackColor = Color.Thistle;
            buttonDivide.FlatStyle = FlatStyle.Popup;
            buttonDivide.Location = new Point(338, 141);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(98, 65);
            buttonDivide.TabIndex = 22;
            buttonDivide.Text = "÷";
            buttonDivide.UseVisualStyleBackColor = false;
            buttonDivide.Click += Operation_Clicked;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Thistle;
            buttonClear.FlatStyle = FlatStyle.Popup;
            buttonClear.Location = new Point(127, 141);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(98, 65);
            buttonClear.TabIndex = 23;
            buttonClear.Text = "🡄";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += OnClearClicked;
            // 
            // button18
            // 
            button18.BackColor = Color.Thistle;
            button18.FlatStyle = FlatStyle.Popup;
            button18.Location = new Point(22, 141);
            button18.Name = "button18";
            button18.Size = new Size(98, 65);
            button18.TabIndex = 24;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = false;
            button18.Click += OnClearEverythingClicked;
            // 
            // buttonChange
            // 
            buttonChange.BackColor = Color.Thistle;
            buttonChange.FlatStyle = FlatStyle.Popup;
            buttonChange.ForeColor = SystemColors.ActiveCaptionText;
            buttonChange.Location = new Point(234, 141);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(98, 65);
            buttonChange.TabIndex = 25;
            buttonChange.Text = "±";
            buttonChange.UseVisualStyleBackColor = false;
            buttonChange.Click += OnPlusMinusClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(470, 522);
            Controls.Add(buttonChange);
            Controls.Add(button18);
            Controls.Add(buttonClear);
            Controls.Add(buttonDivide);
            Controls.Add(buttonResult);
            Controls.Add(button14);
            Controls.Add(buttonDot);
            Controls.Add(textBox1);
            Controls.Add(buttonMinus);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonPlus);
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
            //Load += InitTimer;
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
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonPlus;
        private TextBox textBox1;
        private Button buttonResult;
        private Button button14;
        private Button buttonDot;
        private Button buttonDivide;
        private Button buttonClear;
        private Button button18;
        private Button buttonChange;
    }
}