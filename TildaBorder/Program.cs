/*
 * Tilda Border
 * Pawelski
 * 10/8/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Before running the program, predict what it will display.
 * Check your prediction by running the program. Finally,
 * be prepared to discuss the following questions...
 * 1. Is this a definite or indefinite loop?
 * 2. Based on this example, can you use a variable to modify
 *    how many times a for loop will execute?
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
            for(int i = 0; i < times; i++)
            {
                Console.Write("~");
            }
            Console.WriteLine();
        }
    }
}
