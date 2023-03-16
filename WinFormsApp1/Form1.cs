using System;
using System.Data;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace WinFormsApp1
{

    public partial class Form1 : Form
    {


        private string LastValue = string.Empty;
        private List<string> Values = new();
        IFormatProvider CultureUS = new System.Globalization.CultureInfo("en-US");

        private const string divisionErrorMessage = "Nie mo¿na dzieliæ przez 0";

        public Form1()
        {
            InitializeComponent();
        }

        private void DisableButtons()
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

        private void EnableButtons()
        {
            buttonChange.Enabled = true;
            buttonDivide.Enabled = true;
            buttonMultiply.Enabled = true;
            buttonMinus.Enabled = true;
            buttonPlus.Enabled = true;
            buttonDot.Enabled = true;
            buttonResult.Enabled = true;
            buttonClear.Enabled = true;
        }


        private void Numbers_Clicked(object sender, EventArgs e)
        {
            EnableButtons();
            if (textBox1.Text == divisionErrorMessage)
            {
                textBox1.Text = String.Empty;
            }
            string num = (sender as Button).Text;
            if (textBox1.Text.Equals("0"))
            {
                textBox1.Text = num;
                return;
            }
            if (LastValue.Equals("0"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                LastValue = string.Empty;
            }
            LastValue += num;
            textBox1.Text += num;
        }

        private void Operation_Clicked(object sender, EventArgs e)
        {
            var operation = (sender as Button).Text;
            if (!IsPreviousAnOperation())
            {
                if (textBox1.Text == "0." || textBox1.Text == String.Empty)
                {
                    textBox1.Text = "0";
                }
                Values.Add(LastValue);
                LastValue = string.Empty;
                textBox1.Text += operation;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                textBox1.Text += operation;
            }
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
                    DisableButtons();
                    LastValue = string.Empty;
                    return;
                }

                textBox1.Text = resultAsDouble.ToString(CultureUS);

            }
            catch (DivideByZeroException)
            {
                textBox1.Text = divisionErrorMessage;
                DisableButtons();
                LastValue = string.Empty;
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Nie mo¿na przeprowadziæ tej operacji");
                textBox1.Text = string.Empty;
            }

            LastValue = textBox1.Text;
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                if (IsPreviousAnOperation())
                {
                    if (textBox1.Text[^1] == '-' && (textBox1.Text[^2] == 'x' || textBox1.Text[^2] == '÷' || textBox1.Text[^2] == '+' || textBox1.Text[^2] == '-'))
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                        return;

                    }
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    if (!textBox1.Text.Contains('x') && !textBox1.Text.Contains('÷') && !textBox1.Text.Contains('+') && !textBox1.Text.Contains("-"))
                    {
                        LastValue = textBox1.Text;
                    }
                    else
                    {
                        LastValue = Values[^1];
                        Values.RemoveAt(Values.Count - 1);
                    }
                    return;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (LastValue != string.Empty)
                {
                    LastValue = LastValue.Remove(LastValue.Length - 1);
                }
            }
            else
            {
                Values.Clear();
            }
        }

        private void OnSeparatorClicked(object sender, EventArgs e)
        {
            if (!LastValue.Contains("."))
            {
                if (LastValue == string.Empty)
                {
                    textBox1.Text += "0";
                    LastValue += "0";
                }
                textBox1.Text += ".";
                LastValue += ".";
            }
        }

        private void OnClearEverythingClicked(object sender, EventArgs e)
        {
            EnableButtons();
            textBox1.Text = string.Empty;
            LastValue = string.Empty;
            Values.Clear();
        }

        private void OnPlusMinusClicked(object sender, EventArgs e)
        {
            if (!IsPreviousAnOperation() && LastValue != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - LastValue.Length);
                double val = double.Parse(LastValue, CultureUS) * -1;
                LastValue = val.ToString(CultureUS);
                textBox1.Text += LastValue;
            }
        }

        private bool IsPreviousAnOperation()
        {
            if (textBox1.Text != string.Empty)
            {
                char LastChar = textBox1.Text[^1];
                if (LastChar == 'x' || LastChar == '÷' || LastChar == '+' || LastChar == '-')
                {
                    return true;
                }
            }

            return false;
        }



        #region TEST
        private System.Windows.Forms.Timer timer1;

        private void InitTimer(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100; // in miliseconds
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine($"{LastValue.ToString()}: [{string.Join(", ", Values)}]");
        }
        #endregion
    }
}