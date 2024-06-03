using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_class_that_returns_the_larger_of_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);

            Console.WriteLine(largerValue);
            Console.ReadKey();
        }
    }
}
