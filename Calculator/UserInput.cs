using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class UserInput
    {
        public string[] inputString;
        public List<string> inputList;

        public UserInput()
        { }
        public string [] get_input()
        {
            Console.WriteLine("Enter math problem.");
            string input = Console.ReadLine();
            inputString = input.Split(default(string[]),StringSplitOptions.RemoveEmptyEntries);
            return inputString;
        }
        public void get_inputList()
        {
            inputList = new List<string>();
            foreach (string element in inputString)
            {
                inputList.Add(element);
            }
           
        }
        public void run_calculation()
        {
            switch(inputList[1])
            {
                case "+":
                    Addition addition = new Addition();
                    addition.calculate(inputList);
                    break;
                case "-":
                    Subtraction subtraction = new Subtraction();
                    subtraction.calculate(inputList);
                    break;
                case "*":
                    Multiplication multiplication = new Multiplication();
                    multiplication.calculate(inputList);
                    break;
                case "/":
                    Division division = new Division();
                    division.calculate(inputList);
                    break;
                case "^":
                    Exponentiation exponentiation = new Exponentiation();
                    exponentiation.calculate(inputList);
                    break;
                default:
                    this.get_input();
                    break;
            }
        }
        public void run_calculator()
        {
            get_input();
            get_inputList();
            run_calculation();
            Console.ReadKey();          
        }
       
    }

}
