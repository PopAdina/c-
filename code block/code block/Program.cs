using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_block
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside of code block: {value}");
            }
                Console.WriteLine($"Outside of code block: {value}");
                Console.ReadKey();
            }
        }
    }


