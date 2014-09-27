using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorApp
{
    public partial class CalculatorFormUI : Form
    {
        public CalculatorFormUI()
        {
            InitializeComponent();
        }
        Calculator calculator=new Calculator();
         double firstNumber = 0;
         double secondNumber = 0; 

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = calculator.add(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = calculator.subtract(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = calculator.multiply(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = calculator.divide(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

    }
}
