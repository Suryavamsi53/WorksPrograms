using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
   
    internal class Equation
    {
        static void Main(string[] args)
        {
            // 4)Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. 

            Console.WriteLine("Enter the first number:");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the third number:");
        double z = double.Parse(Console.ReadLine());

        double result1 = (x + y) * z;
        double result2 = (x * y) + (y * z);

        Console.WriteLine($"Result of specified numbers {x}, {y}, and {z}, (x+y)*z is {result1} and x*y + y*z is {result2}");
    }
}
}