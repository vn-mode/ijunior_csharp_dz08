using System;

namespace vn_mode_csharp_dz08
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int numberOfImpressions;

            Console.Write("Напишите что-то приятное: ");
            userInput = Console.ReadLine();
            Console.Write($"Сколько раз вам вывести на экран '{userInput}': ");
            numberOfImpressions = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            for (int i = 0; i < numberOfImpressions; i++)
            {
                Console.WriteLine(userInput);
            }
        }
    }
}
