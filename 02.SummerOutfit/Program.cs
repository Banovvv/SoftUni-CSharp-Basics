using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main()
        {
            var dergees = int.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();
            string outfit = string.Empty;
            string shoes = string.Empty;

            if(dergees >= 10 && dergees <= 18)
            {
                if(timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if(timeOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (dergees > 18 && dergees <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (dergees >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {dergees} degrees, get your {outfit} and {shoes}.");
        }
    }
}