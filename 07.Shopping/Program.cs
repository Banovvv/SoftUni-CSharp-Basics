using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var GPUs = int.Parse(Console.ReadLine());
            var CPUs = int.Parse(Console.ReadLine());
            var RAMs = int.Parse(Console.ReadLine());

            var priceOfGPU = 250.00;
            var priceOfCPU = GPUs * priceOfGPU * 0.35;
            var priceOfRAM = GPUs * priceOfGPU * 0.10;

            var totalSum = GPUs * priceOfGPU + CPUs * priceOfCPU + RAMs * priceOfRAM;

            if (GPUs > CPUs)
            {
                totalSum *= 0.85; 
            }

            if (budget - totalSum >= 0)
            {
                Console.WriteLine($"You have {(budget - totalSum):F2} leva left!");
            }
            else if (budget - totalSum < 0)
            {
                Console.WriteLine($"Not enough money! You need {(totalSum - budget):F2} leva more!");
            }
        }
    }
}