using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    public class Program
    {    
        /// <summary>
        /// Basic method Main is used to test simple features of the program including info input and basic operations.
        /// </summary>
        /// <exception cref="FormatException">If you try to enter info different from value type, it will throw an exception.</exception>
        static void Main(string[] args)
        {            
            Calculator calc = new Calculator();
            double num1, num2;
            char oper;

            while (true)
            {
                Console.WriteLine("Enter number one:");                     // gets user input for the first number
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter number two:");                     // gets user input for the second number
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Choose an operation (+ - / *):");        // gets user input for the operation
                oper = char.Parse(Console.ReadLine());

                try
                {
                    calc.ResultingOperation(num1, num2, oper);              // throws an exception in case of dividing by zero
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Exception caught: " + ex.Message);   // shows an exception message
                }
            }

        }
    }

    public class Calculator
    {
        private double numberOne;                                           // value of the first number
        private double numberTwo;                                           // value of the second number
        private double total;                                               // total value
        private char operation;                                             // chosen operation

        public double Total { get => total; }
        public double NumberOne { get => numberOne; set => numberOne = value; }
        public double NumberTwo { get => numberTwo; set => numberTwo = value; }
        public char Operation { get => operation; set => operation = value; }
        
        /// <summary>
        /// This method is used to perform basic operations of the calculator. It involves adding, substracting, multiplying and dividing.
        /// </summary>
        /// <param name="numberOne">Is used to parse an input of the first value.</param>
        /// <param name="numberTwo">Is used to parse an input of the second value.</param>
        /// <param name="operation">Allows to choose an operation to perform.</param>
        /// <exception cref="DivideByZeroException">While trying to divide by zero it will throw an exception.</exception>
        public void ResultingOperation(double numberOne, double numberTwo, char operation)
        {
            switch (operation)
            {
                case '+':                                                   // action to perform adding
                    total = numberOne + numberTwo;
                    break;
                case '-':                                                   // action to perform substracting
                    total = numberOne - numberTwo;
                    break;
                case '*':                                                   // acrion to perform multiplying
                    total = numberOne * numberTwo;
                    break;
                case '/':                                                   // action to perform dividing
                    if (numberTwo == 0)
                        throw new System.DivideByZeroException();
                    total = numberOne / numberTwo;
                    break;
                default:                                                    // if the operation wasn't chosen correctly
                    Console.WriteLine("Choose a correct operation!");
                    break;
                    
            }

            Console.WriteLine(total);
            }
    }
}
