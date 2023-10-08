/*
 * Count Down Count Up
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Before running the program, predict what it will display.
 * Check your prediction by running the program. Finally,
 * be prepared to discuss the following questions...
 * 1. Why could we reuse i as the loop control variable
 *    in each loop?
 * 2. How does this example demonstrate the concept of scope?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownCountUp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
