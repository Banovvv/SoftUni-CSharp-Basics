using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main()
        {
            var deposit = int.Parse(Console.ReadLine());
            var duration = int.Parse(Console.ReadLine());
            var interest = double.Parse(Console.ReadLine()) / 100;
            var sum = deposit + duration * ((deposit * interest) / 12);

            Console.WriteLine(sum);
        }
    }
}