using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxPerYear = double.Parse(Console.ReadLine());
            double shouesPrice = taxPerYear * 0.6;
            double outfitPrice = shouesPrice * 0.8;
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            double totalSum = taxPerYear + shouesPrice + outfitPrice + accPrice + ballPrice;
            Console.WriteLine(totalSum);

        }
    }
}
