using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularCalculator.Model
{
    class CalculatorModel
    {

        public double Number
        {get;set;
        }

        public CalculatorModel()
        {
            Number = 0;
        }

        // mathematic actions calculate here

        public double Plus(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Minus(double num1, double num2)
        {
            return num2 - num1;
        }

        public double Divide(double num1, double num2)
        {
            return num2 / num1 ;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }


    }
}
