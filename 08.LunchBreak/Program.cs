using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main()
        {
            var seriesName = Console.ReadLine();
            var episodeLength = int.Parse(Console.ReadLine());
            var breakLength = int.Parse(Console.ReadLine());

            var timeForLunch = breakLength * 0.125;
            var timeForRelax = breakLength * 0.25;

            var timeLeft = breakLength - timeForLunch - timeForRelax;

            if (timeLeft - episodeLength >= 0)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeLeft - episodeLength)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeLength - timeLeft)} more minutes.");
            }
        }
    }
}