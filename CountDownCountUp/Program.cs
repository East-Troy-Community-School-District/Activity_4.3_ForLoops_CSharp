/*
 * Count Down Count Up
 * 1/21/2025
 * 
 * Instructions:
 * 1.   Before running the program, predict what it will display.
 *      Check your prediction by running the program. In addition,
 *      explain what the lines of code with comments do.
 * 2.   Why could we reuse i as the loop control variable
 *      in each loop?
 * 3.   How does this example demonstrate the concept of scope?
 * 4.   Modify the program so that it counts up then down.
 * 5.   Modify the program so that it starts and ends the count at 0.
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
            for(int i = 100; i > 0; i--)    // What does this line of code do?
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for (int i = 1; i <= 100; i++)  // What does this line of code do?
            {
                Console.WriteLine(i);
            }
        }
    }
}
