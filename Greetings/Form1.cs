/*
 * Greetings
 * 1/21/2025
 * 
 * Instrucitons:
 * 1.   Run the program to see what it does. Where there is a comment, 
 *      explain what the line of code does.
 * 2.   What specific piece of code allows the for loop to adjust 
 *      the amount of times it repeats?
 * 3.   GUI programs typically eliminate many loops. Why?
 * 4.   You could use a while loop to write this program, but I used
 *      a for loop instead. Why? What are the benefits of using a for
 *      loop over a while loop?
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetings
{
    public partial class GreetingsForm : Form
    {
        public GreetingsForm()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            const string GREETING = "Hello, there...";
            int times;
            string greetings = "";

            times = Convert.ToInt32(timesTextBox.Text);
            for (int i = 0; i < times; i++)                 // What does this line of code do?
            {
                greetings += GREETING + "\n";               // What does this line of code do?
            }
            greetingsLabel.Text = greetings;
        }
    }
}
