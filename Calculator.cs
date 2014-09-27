using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApp
{
    class Calculator
    {
  

        public double add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public double subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double divide(double firstNumber, double secondNumber)
        {
            return  firstNumber / secondNumber;
        }


    }



}
