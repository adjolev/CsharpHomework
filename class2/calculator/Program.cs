using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            bool isOkNum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter second number: ");
            bool isOkNum2 = int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("What operation do you want to use? Write: + - * / to get your answer");
            string operation = Console.ReadLine();

            if (isOkNum1 && isOkNum2)
            {
                switch (operation)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    default:
                        Console.WriteLine("Incorrect operation");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Enter valid number");
            }
        }
    }
}
