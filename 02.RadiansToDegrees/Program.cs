using System;

namespace _02.RadiansToDegrees
{
    internal class Program
    {
        static void Main()
        {
            var radian = double.Parse(Console.ReadLine());
            var angle = radian * 180 / Math.PI;

            Console.WriteLine(angle);
        }
    }
}