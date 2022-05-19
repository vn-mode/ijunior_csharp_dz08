using System;

namespace vn_mode_csharp_dz08
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int howManyTimes;

            Console.Write("Напишите что-то приятное: ");
            userInput = Console.ReadLine();
            Console.Write($"Сколько раз вам вывести на экран '{userInput}': ");
            howManyTimes = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < howManyTimes; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(userInput);
            }
        }
    }
}
