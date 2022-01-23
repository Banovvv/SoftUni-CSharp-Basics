using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main()
        {
            var record = double.Parse(Console.ReadLine());
            var meters = double.Parse(Console.ReadLine());
            var timePerMeter = double.Parse(Console.ReadLine());

            int slowed = (int)(meters / 15);

            var totalTime = meters * timePerMeter + slowed * 12.5;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - record):F2} seconds slower.");
            }
        }
    }
}