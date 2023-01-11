using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double prcent = double.Parse(Console.ReadLine())/100;

            double volume = lenght * width * height;
            double volumeInLiters = volume / 1000;

            double liters = volumeInLiters * (1 - prcent);
            Console.WriteLine(liters);
        }
    }
}
