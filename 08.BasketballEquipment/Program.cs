using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main()
        {
            var yearlyPrice = int.Parse(Console.ReadLine());

            var sneakers = yearlyPrice * 0.60;
            var kit = sneakers * 0.80;
            var ball = kit * 0.25;
            var accessories = ball * 0.20;

            var totalSum = yearlyPrice + sneakers + kit + ball + accessories;

            Console.WriteLine(totalSum);
        }
    }
}