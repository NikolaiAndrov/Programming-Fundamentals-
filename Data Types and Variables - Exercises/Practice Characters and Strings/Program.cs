﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Characters_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char char3 = char.Parse(Console.ReadLine());
            string lastWord = Console.ReadLine();

            Console.WriteLine(firstWord);
            Console.WriteLine(char1);
            Console.WriteLine(char2);
            Console.WriteLine(char3);
            Console.WriteLine(lastWord);
        }
    }
}
