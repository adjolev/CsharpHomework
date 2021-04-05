using System;

namespace twoVariablesEvenOddLargeSmall
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Please enter second number:");
            string number2 = Console.ReadLine();

            int convertNumber1 = int.Parse(number1);
            int convertNumber2 = int.Parse(number2);

            if (convertNumber1 > convertNumber2)
            {
                Console.WriteLine($"{convertNumber1} is larger than {convertNumber2}");
                if (convertNumber1 % 2 == 0)
                {
                    Console.WriteLine($"{convertNumber1} is even number");
                } else
                {
                    Console.WriteLine($"{convertNumber1} is odd number");
                }
            } else if(convertNumber2 > convertNumber1)
            {
                Console.WriteLine($"{convertNumber2} is larger than {convertNumber1}");
                if (convertNumber2 % 2 == 0)
                {
                    Console.WriteLine($"{convertNumber2} is even number");
                }
                else
                {
                    Console.WriteLine($"{convertNumber2} is odd number");
                }
            }


        }
    }
}
