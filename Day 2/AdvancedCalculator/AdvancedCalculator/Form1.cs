using System;
using System.Globalization;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        bool isOperationPressed = false;

        public Form1()
        {
            InitializeComponent();

            // Ensure display is a valid number (only set here; handlers wired in Designer)
            label2.Text = "0";
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (label2.Text == "0" || isOperationPressed)
            {
                label2.Text = "";
                isOperationPressed = false;
            }

            label2.Text += btn.Text;
        }
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            firstNumber = Convert.ToDouble(label2.Text);
            operation = btn.Text;
            isOperationPressed = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(label2.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out double secondNumber))
            {
                MessageBox.Show("Invalid number entered");
                return;
            }

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber != 0)
                        result = firstNumber / secondNumber;
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    break;
            }

            label2.Text = result.ToString();
            isOperationPressed = true;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            if (isOperationPressed)
            {
                label2.Text = "0";
                isOperationPressed = false;
            }

            // Prevent multiple decimals
            if (!label2.Text.Contains("."))
            {
                label2.Text += ".";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Operator_Click(sender, e);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            label2.Text = "0";
            firstNumber = 0;
            operation = "";
            isOperationPressed = false;
        }

    }
}
