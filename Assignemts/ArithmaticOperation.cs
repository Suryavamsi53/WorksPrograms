using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class ArithmaticOperation
    {
        static void Main(string[] args)
        {

            //3) Write a C Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user. 

            int a, b, result, res, resu, resul, re;
            Console.WriteLine("Input the first number to Multiply:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to Multiply:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to Multiply:");

            result = a + b;
            res = a - b;
            resu = a * b;
            resul = a / b;
            re = a % b;

            Console.WriteLine($" {a} + {b} = " + result);
            Console.WriteLine($" {a} - {b} = " + res);
            Console.WriteLine($" {a} x {b} = " + resu);
            Console.WriteLine($" {a} / {b} = " + resul);
            Console.WriteLine($" {a} mod {b} = " + re);


        }
    }
}
