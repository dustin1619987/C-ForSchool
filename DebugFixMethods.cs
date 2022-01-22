using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int choice = 0; //change to int

            WritePrompt(); 
            choice = ReadChoice();
            WriteChoice(choice); // change Choice to choice

        }

        void WritePrompt() //change to WritePrompt instead of writeprompt
        {
            Console.WriteLine("Debug and Fix Methods (DebugFixMethods) - Dustin Price's copy");
            Console.WriteLine("Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ReadChoice() //change to int 
        {
            string s = ""; //made sure it was a string
            s = Console.ReadLine();
            return Convert.ToInt32(s); // Kept getting a error and then remember Convert.ToInt32
        }

        void WriteChoice(int choice) // added int and made sure it was lowercase c
        {
            Console.WriteLine("Your choice is {0}", choice); //lowercase c
        }

    }
}
