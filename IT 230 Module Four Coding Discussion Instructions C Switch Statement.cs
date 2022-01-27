using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSwitchStatement
{
    class Program
    {


        static void Main(string[] args)
        {
            (new Program()).run();

        }

        void run()
        {
            int choice = 0;


            WritePrompt();
            choice = ReadChoice();
            ChoiceToCourse(choice);

            WriteChoice(choice);



        }

        void WritePrompt()
        {
            Console.WriteLine("Teacher's Copy");
            Console.Write("Enter a number : ");
        }

        int ReadChoice()
        {
            string s = "";
            s = Console.ReadLine();
            return Convert.ToInt32(s);
        }


        void WriteChoice(int choice)
        {

            Console.WriteLine("Your Choice of " + choice + " is this course " + ChoiceToCourse(choice));
        }


        string ChoiceToCourse(int choice)
        {
            string course = "";
            switch (choice)
            {
                case 1:
                    course = "IT 145";
                    break;
                case 2:
                    course = "IT 200";
                    break;
                case 3:
                    course = "IT 200";
                    break;
                case 4:
                    course = "IT 200";
                    break;
                case 5:
                    course = "IT 200";
                    break;
                case 6:
                    course = "IT 200";
                    break;
                case 7:
                    course = "IT 200";
                    break;
                default:
                    break;

            }
            return course;
        }

    }
}
