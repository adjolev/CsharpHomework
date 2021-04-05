using System;

namespace averageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int numbers = 0;
            string[] ordinals = new string[] { "", "st", "nd", "rd", "th" };
            while (i <= 4)
            {


                Console.Write($"Enter a number: ");
                bool isOkNum = int.TryParse(Console.ReadLine(), out int num);

                if (isOkNum)
                {
                    numbers = numbers + num;
                    i++;
                }
                else
                {
                    Console.WriteLine("Invalid Number");
                }
            }

            Console.WriteLine($"Average: {numbers / 4}");
        }
    }
}
