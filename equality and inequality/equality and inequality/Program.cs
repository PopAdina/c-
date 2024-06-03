using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equality_and_inequality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value1 = " a";
            //string value2 = "A ";
            //Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            //Console.ReadKey();


            //Console.WriteLine("a" != "a");
            //Console.WriteLine("a" != "A");
            //Console.WriteLine(1 != 2);

            //string myValue = "a";
            //Console.WriteLine(myValue != "a");
            //Console.ReadKey();

            // Console.WriteLine(1 > 2);
            //Console.WriteLine(1 < 2);
            //Console.WriteLine(1 >= 1);
            //Console.WriteLine(1 <= 1);
            //Console.ReadKey();

            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(pangram.Contains("cow"));
            Console.ReadKey();

            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
            Console.ReadKey();
        }
    }
}
