/*
 * Tilda Border
 * 1/21/2025
 * 
 * Instructions:
 * 1.   Before running the program, predict what it will display.
 *      Check your prediction by running the program. Where you
 *      see a comment, explain what the line of code does.
 * 2.   While it may seem counterintuitive, this for loop is still
 *      considered a definite loop. It is a definite loop becuase
 *      we know how many times the loop will run at the top of the
 *      loop.
 * 3.   Based on this example, can you use a variable to modify
 *      how many times a for loop will execute?
 * 4.   Based on this example, how can you display multiple things
 *      on the same line using a loop?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TildaBorder
{
    class Program
    {
        static void Main(string[] args)
        {
            int times;
            Console.Write("How long do you want the border? >> ");
            times = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < times; i++)      // What does this line of code do?
            {
                Console.Write("~");             // What is the purpose of this line of code?
            }
            Console.WriteLine();                // What is the purpose of thsi line of code?
        }
    }
}
