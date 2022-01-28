using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            Console.WriteLine("Dustin's Copy - Debug & Fix If Statements (DebugFixIFStmt)"); //Input my name and assignment here

            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);
        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (firstChoice == 0) //change from second to first. Needed to go in order. first,second,third. 
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);
            else if (secondChoice == 0) // missing a =  
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice, firstChoice);
            else if (thirdChoice == 0) // Was a extra = here
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);
            else // Line wouldn't show if it had third then thought about taking it away and making it just a else. Realized the WriteCurrentChoice only had three variables so the content had to many else if variable.
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice); //Move it over here to see how it looks
        }
    }
}


// point of code was to fix issues that were shown in the provided code. issue are shown with the // in the code.
