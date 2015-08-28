using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorWebApp
{
    public class Calculator
    {
        
        public double GetAdd(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double GetSubtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double GetMultiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double GetDivision(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}