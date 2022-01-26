using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main()
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budgetForFlowers = int.Parse(Console.ReadLine());

            double priceOfRoses = 5.00;
            double priceOfDahlias = 3.80;
            double priceOfTulips = 2.80;
            double priceOfNarcissus = 3.00;
            double priceOfGladiolus = 2.50;

            double moneyNedded = 0;

            if (typeOfFlowers == "Roses")
            {
                if (numberOfFlowers > 80)
                {
                    moneyNedded = (numberOfFlowers * priceOfRoses) * 0.90;
                }
                else
                {
                    moneyNedded = numberOfFlowers * priceOfRoses;
                }
            }
            else if (typeOfFlowers == "Dahlias")
            {
                if (numberOfFlowers > 90)
                {
                    moneyNedded = (numberOfFlowers * priceOfDahlias) * 0.85;
                }
                else
                {
                    moneyNedded = numberOfFlowers * priceOfDahlias;
                }
            }
            else if (typeOfFlowers == "Tulips")
            {
                if (numberOfFlowers > 80)
                {
                    moneyNedded = (numberOfFlowers * priceOfTulips) * 0.85;
                }
                else
                {
                    moneyNedded = numberOfFlowers * priceOfTulips;
                }
            }
            else if (typeOfFlowers == "Narcissus")
            {
                if (numberOfFlowers < 120)
                {
                    moneyNedded = (numberOfFlowers * priceOfNarcissus) * 1.15;
                }
                else
                {
                    moneyNedded = numberOfFlowers * priceOfNarcissus;
                }
            }
            else if (typeOfFlowers == "Gladiolus")
            {
                if (numberOfFlowers < 80)
                {
                    moneyNedded = (numberOfFlowers * priceOfGladiolus) * 1.20;
                }
                else
                {
                    moneyNedded = numberOfFlowers * priceOfGladiolus;
                }
            }

            if (moneyNedded > budgetForFlowers)
            {
                Console.WriteLine($"Not enough money, you need {(moneyNedded - budgetForFlowers):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {(budgetForFlowers - moneyNedded):F2} leva left.");
            }
        }
    }
}