﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (max - min < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int first = min; first <= max; first++)
                {
                    for (int second = min; second <= max; second++)
                    {
                        for (int third = min; third <= max; third++)
                        {
                            for (int fourth = min; fourth <= max; fourth++)
                            {
                                for (int fifth = min; fifth <= max; fifth++)
                                {
                                    if (first < second && second < third && third < fourth && fourth < fifth)
                                    {
                                        Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                    }
                                }

                            }

                        }

                    }

                }
            }
        }
    }
}
