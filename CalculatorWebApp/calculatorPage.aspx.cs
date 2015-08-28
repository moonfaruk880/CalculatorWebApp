using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApp
{
    public partial class calculatorPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        Calculator myCalculator = new Calculator();
        public double firstNumber;
        public double secondNumber;
        protected void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(myCalculator.GetAdd(firstNumber, secondNumber));
            

        }

        protected void subtractButton(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(myCalculator.GetSubtract(firstNumber, secondNumber));
            
        }

        protected void multiplyButton(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(myCalculator.GetMultiply(firstNumber, secondNumber));
            
        }

        protected void divisionButton(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            resultTextBox.Text = Convert.ToString(myCalculator.GetDivision(firstNumber, secondNumber));
            
        }
    }
}