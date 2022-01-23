using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main()
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var minutesPlusFifteen = minutes + 15;

            if (minutesPlusFifteen <= 59)
            {
                Console.WriteLine($"{hour}:{minutesPlusFifteen}");
            }
            else if (minutesPlusFifteen > 59)
            {
                hour++;
                minutesPlusFifteen -= 60;

                if (hour > 23)
                {
                    hour -= 24;
                }

                if (minutesPlusFifteen < 10)
                {
                    Console.WriteLine($"{hour}:0{minutesPlusFifteen}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutesPlusFifteen}");
                }
            }
        }
    }
}