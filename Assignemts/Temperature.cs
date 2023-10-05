using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class Temperature
    {
        static void Main(string[] args) {
            // 8)Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 

            Console.WriteLine("Enter the amount of Celsius:");
            double celsius = double.Parse(Console.ReadLine());

            // Convert Celsius to Kelvin
            double kelvin = celsius + 273.15;

            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"Kelvin = {kelvin:F0}");
            Console.WriteLine($"Fahrenheit = {fahrenheit:F0}"); 
    }
  }
}