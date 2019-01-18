using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ProgramUI
    {

        CalculatorRepository _calculatorRepo = new CalculatorRepository();


        public void Run()
        {

            Console.WriteLine("Hello and welcome to the most comprehensive calculator programmed in today's world! Please press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            bool continueRunning = true;
            while (continueRunning)
            {

                Console.WriteLine("Please enter a number...");
                string firstNumberAsString = Console.ReadLine();
                int parsedNumber = int.Parse(firstNumberAsString);

                Console.WriteLine("Please enter a second number...");
                string secondNumberAsString = Console.ReadLine();
                int parsedSecondNumber = int.Parse(secondNumberAsString);

                int nameWhatever = _calculatorRepo.MultiplyTwoNumbers(parsedNumber, parsedSecondNumber);

                Console.WriteLine(nameWhatever);
                Console.ReadKey();

                Console.WriteLine("What would you like to do now?\n" +
                    "1. Add\n" +
                    "2. Subtract\n" +
                    "3. Divide\n" +
                    "4. Multiply\n");

                string response = Console.ReadLine();
                int input = int.Parse(response);

                int answer = 0;

                switch (input)
                {
                    case 1:
                        answer = _calculatorRepo.AddTwoNumbers(parsedNumber, parsedSecondNumber);
                        break;
                    case 2:
                        answer = _calculatorRepo.SubtractTwoNumbers(parsedNumber, parsedSecondNumber);
                        break;
                    case 3:
                        answer = _calculatorRepo.DivideTwoNumbers(parsedNumber, parsedSecondNumber);
                        break;
                    case 4:
                        answer = _calculatorRepo.MultiplyTwoNumbers(parsedNumber, parsedSecondNumber);
                        break;
                    case 5:
                        continueRunning = false;
                        break;
                    default:
                        break;
                }

                Console.WriteLine($"After spending time running around the back here, your answer is {answer}. Please ");
            }
        }
    }
}