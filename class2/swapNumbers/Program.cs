using System;

namespace swapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please your first number: ");

            bool isOkNum1 = int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Please enter your second number: ");
            bool isOkNum2 = int.TryParse(Console.ReadLine(), out int num2);

            if (isOkNum1 && isOkNum2)
            {
                Console.WriteLine($"Number 1: {num1}, Number 2: {num2}");

                int takePlace = 0;
                takePlace = num2;
                num2 = num1;
                num1 = num2;

                Console.WriteLine($"Number 1: {num1}, Number 2: {num2}");
            }
        }
    }
}
