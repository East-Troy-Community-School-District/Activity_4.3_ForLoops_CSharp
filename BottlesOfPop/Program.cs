/*
 * Bottles of Pop
 * 1/17/2023
 * C#.NET I
 * 
 * Instructions:
 * Before running the program, predict what it will display.
 * Check your prediction by running the program. Finally,
 * be prepared to discuss the following questions...
 * 1. Is it necessary to always use i as the loop control variable
 *    in a for loop?
 * 2. Why did the program print "1 bottle of pop on the wall!" after
 *    the loop instead of inside?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlesOfPop
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int bottles = 99; bottles > 1; bottles--)
            {
                Console.WriteLine(bottles + " bottles of pop on the wall!");
            }
            Console.WriteLine("1 bottle of pop on the wall!");
            Console.WriteLine("No more bottles of pop on the wall!");
        }
    }
}
