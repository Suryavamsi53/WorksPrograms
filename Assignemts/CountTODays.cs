using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class CountTODays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days:");
            int totalDays = int.Parse(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;

            Console.WriteLine($"{totalDays} days is equal to:");
            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {days}");
        }
    }
}