using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main()
        {
            var pagesInBook = int.Parse(Console.ReadLine());
            var pagesPerHour = int.Parse(Console.ReadLine());
            var daysPerBook = int.Parse(Console.ReadLine());

            var hoursPerDay = (pagesInBook / pagesPerHour) / daysPerBook;

            Console.WriteLine(hoursPerDay);
        }
    }
}