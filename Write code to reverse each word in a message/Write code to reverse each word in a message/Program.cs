﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_code_to_reverse_each_word_in_a_message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            // Step 1
            string[] message = pangram.Split(' ');

            //Step 2
            string[] newMessage = new string[message.Length];

            // Step 3
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            //Step 4
            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
