using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var percentOfSand = decimal.Parse(Console.ReadLine()) / 100;

            var aquariumVolume = length * width * height;
            var volumeInLiters = aquariumVolume * 0.001m;
            var litersNeeded = volumeInLiters * (1 - percentOfSand);

            Console.WriteLine(litersNeeded);
        }
    }
}