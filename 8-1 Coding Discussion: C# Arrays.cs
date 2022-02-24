using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] Course = new string[7] { "IT 145", "IT 200", "IT 201", "IT 270", "IT 315", "IT 328", "IT 330" };

            Console.WriteLine("Dustin's Copy - 8-1 Coding Discussion: C# Arrays");
            Console.WriteLine("List of courses:");
            // Iterating over Array Elements with the for Loop
            foreach (string i in Course) { Console.WriteLine(i); }
        
        }
         
        
        class Course
        {
            private string name = "";

            public Course(string name)
            {
                this.name = name;
            }
            public string getName()
            {
                return name;
            }
        }
    }
}
