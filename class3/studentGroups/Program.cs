using System;

namespace studentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentGroup1 = { "Bob", "Joe", "Jane", "Mark", "George", "Emily" };
            string[] studentGroup2 = { "Boban", "Jovan", "Jana", "Marko", "Gjorgi", "Emilija" };

            bool isOkGroup;

            while (true)
            {
                Console.Write("Enter 1 or 2 to display users: ");
                isOkGroup = int.TryParse(Console.ReadLine(), out int groupNumber);

                if (isOkGroup)
                {
                    if (groupNumber == 1)
                    {
                        for (int i = 0; i < studentGroup1.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("The Students of group 1 are:");
                            }
                            Console.WriteLine($"{i + 1}. {studentGroup1[i]}");
                        }
                    }
                    else if (groupNumber == 2)
                    {
                        for (int i = 0; i < studentGroup2.Length; i++)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine("The Students of group 2 are:");
                            }
                            Console.WriteLine($"{i + 1}. {studentGroup2[i]}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid group number");
                        continue;
                    }
                    break;
                }
                else
                    Console.WriteLine("Invalid group number");

            }
        }
    }
}
