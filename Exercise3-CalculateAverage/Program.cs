using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_CalculateAverage
{
    class Program
    {
        //Write a C# Sharp program that takes four numbers as input to calculate and print the average

        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Average\n");
            double num1, num2, num3, num4;

            Console.WriteLine("Enter number 1: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 3: ");
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 4: ");
            num4 = double.Parse(Console.ReadLine());

            double average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("Average of {0}, {1}, {2} and {3} is: {4:} ", num1,num2,num3,num4, average);
            Console.ReadLine();

        }
    }
}
