using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main()
        {
            var chickenMenus = int.Parse(Console.ReadLine());
            var fishMenus = int.Parse(Console.ReadLine());
            var vegetarianMenus = int.Parse(Console.ReadLine());

            var chickenMenuPrice = 10.35;
            var fishMenuPrice = 12.40;
            var vegeterianMenuPrice = 8.15;

            var sum = chickenMenus * chickenMenuPrice + fishMenus * fishMenuPrice + vegetarianMenus * vegeterianMenuPrice;
            var desertSum = sum * 0.20;
            var delivery = 2.50;

            var totalSum = sum + desertSum + delivery;

            Console.WriteLine(totalSum);
        }
    }
}