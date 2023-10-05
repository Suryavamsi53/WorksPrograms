using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class TripleSum
    {
        static void Main(string[] args)
        {
            // 9)Write a C# program to compute the sum of two given integers, if two values are equal then return the triple of their sum. 


            Console.WriteLine("Enter the first integer:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                Console.WriteLine($"The sum of {num1} and {num2} is {sum * 3}");
            }
            else
            {
                Console.WriteLine($"The sum of {num1} and {num2} is {sum}");



            }
        }
    }
}