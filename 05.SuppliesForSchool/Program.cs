using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main()
        {
            var packetsOfPens = int.Parse(Console.ReadLine());
            var packetsOfMarkers = int.Parse(Console.ReadLine());
            var litersOfCleaner = int.Parse(Console.ReadLine());
            var discount = double.Parse(Console.ReadLine()) / 100;

            double priceOfPens = 5.80;
            double priceOfMarkers = 7.20;
            double priceOfCleaner = 1.20;

            var sumWithoutDiscount = packetsOfPens * priceOfPens + packetsOfMarkers * priceOfMarkers + litersOfCleaner * priceOfCleaner;
            var sumWithDiscount = sumWithoutDiscount - (sumWithoutDiscount * discount);

            Console.WriteLine(sumWithDiscount);
        }
    }
}