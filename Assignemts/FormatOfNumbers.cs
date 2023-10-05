using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class FormatOfNumbers
    {
        static void Main(string[] args)
        {

            //5)Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}.
            Console.WriteLine("Enter a digit:");
            int number = int.Parse(Console.ReadLine());


            Console.WriteLine("Using Console.Write:");
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{number} {number} {number} {number} ");
                Console.WriteLine();
                Console.Write($"{number}{number}{number}{number}");
                Console.WriteLine();
            }


            Console.WriteLine("\nUsing {0} String Formatting:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(string.Format("{0} {0} {0} {0}", number));
                Console.WriteLine(string.Format("{0}{0}{0}{0}", number));
            }
        }
    }
}