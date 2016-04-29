using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Exponentiation : Operator, ICalculator
    {
        public Exponentiation()
        {

        }
        public void calculate(List<string> inputList)
        {
            string firstNumber = inputList[0];
            string secondNumber = inputList[2];
            double firstDouble = Convert.ToDouble(firstNumber);
            double secondDouble = Convert.ToDouble(secondNumber);
            result = Math.Pow(firstDouble, secondDouble);
            Console.WriteLine(result);
        }
    }
}
