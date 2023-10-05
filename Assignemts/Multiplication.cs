using System;

namespace Assignments
{
    internal class Multiplication
    {
         static void Main()
        {
            int a, b, c, result;

            Console.WriteLine("Input the first number to Multiply:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number to Multiply:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the third number to Multiply:");
            c = int.Parse(Console.ReadLine());

            result = a * b * c;
            Console.WriteLine($" {a} x {b} x {c} = " + result);
        }
    }
}
