using System;

namespace basicLottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number from 1 to 3: ");
            string number1 = Console.ReadLine();
            int number;
            bool isSucess = int.TryParse(number1, out number);
           
            /*int number = int.Parse(number1);*/
            if (isSucess == true)
            {
                if (number == 1)
                {
                    Console.WriteLine("You got a new car!");
                }
                else if (number == 2)
                {
                    Console.WriteLine("You got a new plane!");
                }
                else if (number == 3)
                {
                    Console.WriteLine("You got a new bike!");
                }
                else
                {
                    Console.WriteLine("You entered wrong number");
                }
            } else
            {
                Console.WriteLine("Please enter a number, it only works with numbers");
            }
            
        }
    }
}
