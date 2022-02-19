using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;
        private int creditHours = 0; //varaible for to track creditHours. Private because the others parameters are private. 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);

            // TO DO - Create code to validate user selection (the choice object)
            // and to display an error or a registation confirmation message accordinlgy
            // Also update the total credit hours textbox if registration is confirmed for a selected course 

            if (listBox.Items.Contains(choice)) //If statement for the listbox which is where the course show at
            {
                label3.Content = "You have already registered for this " + choice + " course."; //If the listbox contains choice then it tell you it's already registered.
            }

            else if (creditHours < 9) //Boolean Expression for creditHourse < 9. Thought it was <= at first but didn't work correctly. 
            {
                listBox.Items.Add(choice); //listBox is the the name of the box where the courses will appear.
                creditHours += 3; //Adding 3.
                textBox.Text = Convert.ToString(creditHours); //Converting to string.textBox is the name of the box that show credit hours.
                label3.Content = "Registration Confirmed for course " + choice + ".";  //Output the confirmed what course is registered.
            }

            else //else statement. When nothing fits above else is this. 
            {
                label3.Content = "You can not register for more than 9 credit hours."; //When over 9 credit it with outputs this since above is < 9.
            }
            //Note to self: Remember to close window after done. If you Try to build when window of the debugging open it gie errors below. 

        }

    }
}
