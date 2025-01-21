/*
 * Bottles of Pop
 * 1/21/2025
 * 
 * Instructions:
 * 1.   Before running the program, predict what it will display.
 *      Check your prediction by running the program. Also, answer
 *      any questions in the comments below.
 * 2.   Is it necessary to always use i as the loop control variable in a for loop?
 * 3.   Why did the program print "1 bottle of pop on the wall!" after
 *      the loop instead of inside?
 * 4.   This program demonstrates a way to solve an off by one error, which
 *      means that we either went too far or stopped too early by one iteration.
 *      How did the loop solve this error?
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
            for(int bottles = 99; bottles > 1; bottles--)       // What does this line of code do?
            {
                Console.WriteLine(bottles + " bottles of pop on the wall!");
            }
            Console.WriteLine("1 bottle of pop on the wall!");
            Console.WriteLine("No more bottles of pop on the wall!");
        }
    }
}
