using System;

namespace WinFormsApp1
{

    public enum Operation
    {
        None,
        Multiplication,
        Addition,
        Subtraction,
        Division,
    }

    public partial class Form1 : Form
    {
        private string FirstValue;
        private string SecondValue;
        IFormatProvider CultureUS = new System.Globalization.CultureInfo("en-US");

        private Operation CurrentOperation = Operation.None;

        public Form1()
        {
            InitializeComponent();
        }




        private void Numbers_Clicked(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            if (CurrentOperation != Operation.None)
            {
                SecondValue += num;

            }
            textBox1.Text += num;
        }

        private void Operation_Clicked(object sender, EventArgs e)
        {
            FirstValue = textBox1.Text;
            var operation = (sender as Button).Text;
            CurrentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Subtraction,
                "÷" => Operation.Division,
                "x" => Operation.Multiplication,
                _ => Operation.None
            };
            textBox1.Text += operation;

        }

        private double Calculate(string value1, string value2)
        {
            double num1, num2 = 0;
            num1 = double.Parse(value1, CultureUS);
            num2 = double.Parse(value2, CultureUS);
            switch (CurrentOperation)
            {
                case Operation.None: return num1;
                case Operation.Addition: return num1 + num2;
                case Operation.Subtraction: return num1 - num2;
                case Operation.Multiplication: return num1 * num2;
                case Operation.Division:

                    if (num2 == 0)
                    {
                        MessageBox.Show("Nie mo¿na dzieliæ przez 0");
                        return 0;
                    }
                    return num1 / num2;

            }


            return 0;
        }

        private void OnButtonResultClicked(object sender, EventArgs e)
        {
            textBox1.Text = Calculate(FirstValue, SecondValue).ToString().Replace(",", ".");

            FirstValue = textBox1.Text;
            SecondValue = string.Empty;
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            FirstValue = string.Empty;
            SecondValue = string.Empty;
            CurrentOperation = Operation.None;
        }

        private void OnSeparatorClicked(object sender, EventArgs e)
        {
            textBox1.Text += ".";
            if (CurrentOperation != Operation.None)
            {
                SecondValue += ".";
            }
        }
    }
}