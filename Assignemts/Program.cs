﻿using System;

namespace Assignemts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a C# Sharp program to swap two numbers.
            int num1, num2, temp;

            Console.WriteLine("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);
        }
    }
}
