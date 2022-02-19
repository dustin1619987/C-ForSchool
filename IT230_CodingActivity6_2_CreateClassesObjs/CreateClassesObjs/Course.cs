using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClassesObjs
{
    class Course //name of the Course choice; within the MainWindow.xaml.cs
    {
        private string name; //Course has a private string field to hold the name of the course. Name is name due to setName within MainWindow.xaml.cs section 
        public void setName(string userChoice) // Course has a method to set the name field to a given string value, setname from MainWindow.xaml.cs

        {
            name = userChoice; //picked user due to the user using the item ann choice from course choice;
        }
        public string getName() // Course had a method to retrieve the name field with get
        {
            return name; //returns the name
        }
        public override string ToString() //From Instructions to return name 
        {
            return getName();// this method should return the name field
        }
    }
}
