using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main()
        {
            string typeOfScreening = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;
            if(typeOfScreening == "Premiere")
            {
                income = 12.00 * rows * columns;
            }
            else if (typeOfScreening == "Normal")
            {
                income = 7.50 * rows * columns;
            }
            else if (typeOfScreening == "Discount")
            {
                income = 5.00 * rows * columns;
            }

            Console.WriteLine($"{income:F2} leva");
        }
    }
}
