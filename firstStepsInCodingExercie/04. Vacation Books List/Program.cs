﻿using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int page = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int totalHour = page / pagesPerHour;

            int hoursPerDay = totalHour/ days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
