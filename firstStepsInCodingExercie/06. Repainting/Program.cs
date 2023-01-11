using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylonQuantiity = int.Parse(Console.ReadLine());
            double painQuantity = int.Parse(Console.ReadLine());
            int thirnnrtLitters = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            painQuantity = painQuantity + painQuantity * 0.10;
            naylonQuantiity = naylonQuantiity + 2;

            double naylonPrice = naylonQuantiity * 1.5;
            double painPrice = painQuantity * 14.50;
            double thinnerPrice = thirnnrtLitters * 5.00;

            double materialSum = naylonPrice + painPrice + thinnerPrice + 0.40;

            double pricePerHours = 0.30 * materialSum;
            double workSum = workHours * pricePerHours;
            double totalSum = workSum + materialSum;
            Console.WriteLine(totalSum);
        }
    }
}
