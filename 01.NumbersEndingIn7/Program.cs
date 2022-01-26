using System;

namespace _01.NumbersEndingIn7
{
    internal class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 997; i++)
            {
                if(i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}