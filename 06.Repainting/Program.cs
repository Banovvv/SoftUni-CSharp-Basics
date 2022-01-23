using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main()
        {
            var nylon = int.Parse(Console.ReadLine());
            var paint = int.Parse(Console.ReadLine());
            var diluder = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());

            double priceOfNylon = 1.50;
            double priceOfPaint = 14.50;
            double proceOfDilude = 5.00;

            var sumOfMaerials = ((nylon + 2) * priceOfNylon) + ((paint * 1.10) * priceOfPaint) + (diluder * proceOfDilude) + 0.40;
            var workersPerHour = sumOfMaerials * 0.30;
            var totalSum = sumOfMaerials + (workersPerHour * hours);

            Console.WriteLine(totalSum);
        }
    }
}