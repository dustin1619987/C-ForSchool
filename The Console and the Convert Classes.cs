using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHello
{
    class Program
    {
        static void Main(string[] args)
        {
            string number0;
            int number1;

            Console.WriteLine("Welcome to Assignment: 2-1 Coding Discussion: The Console and the Convert Classes\n");
            Console.WriteLine("Please Enter a Number: ");
            number0 = Console.ReadLine(); //converting the inputted number to number0
            Console.WriteLine("\nYou have inputted the number " + number0 + ", the data type for this is currently: " + number0.GetType());
            number1 = System.Convert.ToInt32(number0); //This is the Convert.ToXXX() that is needed for this Discussion Assignment
            Console.WriteLine("\nNow lets convert that string into a int32: " + number0 + " is now a " + number1.GetType()); 

        }
    }
}
