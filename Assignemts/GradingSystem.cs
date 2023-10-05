using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemts
{
    internal class GradingSystem
    {
        static void Main(string[] args) {

            Console.WriteLine("Enter marks for three subjects:");

            Console.Write("Subject 1: ");
            int subject1 = int.Parse(Console.ReadLine());

            Console.Write("Subject 2: ");
            int subject2 = int.Parse(Console.ReadLine());

            Console.Write("Subject 3: ");
            int subject3 = int.Parse(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3;

            double percentage = (double)totalMarks / 3;

            string grade = "";

            if (percentage < 35)
            {
                grade = "Fail";
            }
            else if (percentage >= 35 && percentage < 45)
            {
                grade = "Third";
            }
            else if (percentage >= 45 && percentage < 60)
            {
                grade = "Second";
            }
            else
            {
                grade = "First";
            }

            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Grade: {grade}");

        }
    }
}