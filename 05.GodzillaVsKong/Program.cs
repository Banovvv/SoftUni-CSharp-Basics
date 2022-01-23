using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var statits = int.Parse(Console.ReadLine());
            var priceOfClothing = double.Parse(Console.ReadLine());

            var decorPrice = budget * 0.10;

            if (statits > 150)
            {
                priceOfClothing *= 0.90;
            }

            var totalSum = statits * priceOfClothing + decorPrice;

            if (totalSum <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalSum - budget):F2} leva more.");
            }
        }
    }
}