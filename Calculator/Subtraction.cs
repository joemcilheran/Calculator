using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Subtraction : Operator, ICalculator
    {
        public Subtraction()
        {

        }
        public void calculate(List<string> inputList)
        {
            string firstNumber = inputList[0];
            string secondNumber = inputList[2];
            double firstDouble = Convert.ToDouble(firstNumber);
            double secondDouble = Convert.ToDouble(secondNumber);
            result = (firstDouble - secondDouble);
            Console.WriteLine(result);
        }
    }
}
