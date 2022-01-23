using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main()
        {
            var tripPrice = double.Parse(Console.ReadLine());
            var puzzles = int.Parse(Console.ReadLine());
            var dolls = int.Parse(Console.ReadLine());
            var bears = int.Parse(Console.ReadLine());
            var minions = int.Parse(Console.ReadLine());
            var trucks = int.Parse(Console.ReadLine());

            double puzzlePrice = 2.60;
            double dollPricce = 3.0;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.0;

            double sum = puzzles * puzzlePrice + dolls * dollPricce + bears * bearPrice + minions * minionPrice + trucks * truckPrice;

            if (puzzles + dolls + bears + minions + trucks >= 50)
            {
                sum *= 0.75;
            }

            if (sum * 0.90 - tripPrice >= 0)
            {
                Console.WriteLine($"Yes! {(sum * 0.90 - tripPrice):F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(sum * 0.90 - tripPrice):F2} lv needed.");
            }
        }
    }
}