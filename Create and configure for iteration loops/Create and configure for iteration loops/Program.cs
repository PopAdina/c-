using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_and_configure_for_iteration_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alex", "Eddie", "David", "Michael" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
