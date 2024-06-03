﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string readResult;
            string roleName = "";
            bool validEntry = false;

            do
            {
                Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);

            Console.WriteLine($"Your input value ({roleName}) has been accepted.");
            readResult = Console.ReadLine();
        }
    }
}
