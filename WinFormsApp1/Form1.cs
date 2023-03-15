using System;
using System.Data;
using System.Reflection.Metadata;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        private string LastValue = string.Empty;
        private bool OperationClicked = false;
        IFormatProvider CultureUS = new System.Globalization.CultureInfo("en-US");

        private const string divisionErrorMessage = "Nie mo¿na dzieliæ przez 0";

        public Form1()
        {
            InitializeComponent();
        }

        private void DisableButtons(object sender, EventArgs e)
        {
            buttonChange.Enabled = false;
            buttonDivide.Enabled = false;
            buttonMultiply.Enabled = false;
            buttonMinus.Enabled = false;
            buttonPlus.Enabled = false;
            buttonDot.Enabled = false;
            buttonResult.Enabled = false;
            buttonClear.Enabled = false;
        }


        private void Numbers_Clicked(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            if (textBox1.Text.Equals(divisionErrorMessage))
            {
                textBox1.Text = num;
                return;
            }
            LastValue += num;
            textBox1.Text += num;
        }

        private void Operation_Clicked(object sender, EventArgs e)
        {
            OperationClicked = true;
            LastValue = string.Empty;
            var operation = (sender as Button).Text;
            textBox1.Text += operation;
        }


        private void OnButtonResultClicked(object sender, EventArgs e)
        {
            string formula = textBox1.Text.Replace('÷', '/').Replace('x', '*');
            try
            {
                DataTable dataTable = new();
                var result = dataTable.Compute(formula, "").ToString();
                double resultAsDouble = Convert.ToDouble(result);
                if (result.Equals("NaN") || double.IsInfinity(resultAsDouble))
                {
                    textBox1.Text = divisionErrorMessage;
                    DisableButtons(sender, e);
                    return;
                }

                textBox1.Text = result;

            }
            catch (DivideByZeroException)
            {
                textBox1.Text = divisionErrorMessage;
                DisableButtons(sender, e);   
            }
            LastValue = textBox1.Text;
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            LastValue = LastValue.Remove(LastValue.Length - 1);
        }

        private void OnSeparatorClicked(object sender, EventArgs e)
        {
            if (!LastValue.Contains("."))
            {
                textBox1.Text += ".";
                LastValue += ".";
            }
        }

        private void OnClearEverythingClicked(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }

        private void OnPlusMinusClicked(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - LastValue.Length);
            double val = Double.Parse(LastValue) * -1;
            LastValue = val.ToString();
            textBox1.Text += LastValue;
        }


    }
}