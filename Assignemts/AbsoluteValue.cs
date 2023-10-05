using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class AbsoluteValue
    {

        static void Main(String[] args)
        {
            //10)Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than second number. 

            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                Console.WriteLine($"Double the absolute difference: {difference * 2}");
            }
            else
            {
                Console.WriteLine($"Absolute difference: {difference}");
            }


        }
    }
}
