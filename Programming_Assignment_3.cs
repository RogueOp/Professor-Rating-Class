/*  
    Programmer:Jon DeFrees
    Date: 9/17/2018(Last Update: 9/21/2018
    Program: This program has 2 classes the first of which calls to the second and runs the display method after completeion. The second class either
    allows the user to input a students first, and last names, as well as their university, and assigns default grades of 3. Or the user can input first,
    and last names, university, easiness, and helfulness grades. It also prevents the names from being changed once input. University can be change but
    only by a property, and the grades can be change via accessor and mutator methods.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastName = GetLastName();
            string firstName = GetFirstName();
            string university = "Indiana University";
            double easinessGrade = 3;
            double helpfulnessGrade = 3;
            //Allows the user to input the professors first and last names, and sets the defaults for university, easiness, and helpfulness grades.


            ProfessorRating p1 = new ProfessorRating(lastName, firstName, university, easinessGrade, helpfulnessGrade);
            // shows that if no grades are entered program will automatically assign a 3 out of 5
            ProfessorRating p2 = new ProfessorRating(lastName, firstName, university, easinessGrade, helpfulnessGrade);
            // Takes first and last names, the university, easiness, and helpfulness grades( grades through accessor and mutator methods)


            p2.University = GetUniversity();
            p2.SetEasinessGrade(GetEasinessGrade());
            p2.SetHelpfulnessGrade(GetHelpfulnessGrade());


            Console.WriteLine(p1);
            //displays ToString method for 1st student
            Console.WriteLine(p2);
            //displays ToString method for 2nd student
        }


        public static string GetLastName()
        {
            //This is the code that allows the user to input their professor's last name.
            Console.Write("Enter Professor's Last Name Here:");
            return (Console.ReadLine());
        }


        public static string GetFirstName()
        {
            //This is the code that allows the user to input their professor's first name.
            Console.Write("Enter Professor's First Name Here:");
            return (Console.ReadLine());
        }


        public static string GetUniversity()
        {
            //This allows the user to input a university name that will jump through the property to override the default university name.
            Console.Write("Enter University Professor Instructs At Here:");
            return (Console.ReadLine());
        }

        public static double GetEasinessGrade()
        {
            //This allows the user to input a easiness grade for the professor to overwrite the default.
            Console.Write("Enter Professor's Easiness Grade Here:");
            return (double.Parse(Console.ReadLine()));
        }

        public static double GetHelpfulnessGrade()
        {
            //This allows the user to input a helpfulness grade to overwrite the default.
            Console.Write("Enter Professor's Helpfulness Grade Here:");
            return (double.Parse(Console.ReadLine()));
        }
    }

    class ProfessorRating
    {
        private string lastName;
        private string firstName;
        private string university;
        private double easinessGrade;
        private double helpfulnessGrade;
        //makes all variables unacessible unless some kind of accessability added later in program

        public ProfessorRating(string l, string f, string u, double e, double h)
        {
            lastName = l;
            firstName = f;
            university = u;
            easinessGrade = e;
            helpfulnessGrade = h;
            // brings information from program class to professor rating class
        }


        public string University
        {
            set
            {
                university = value;
                //Property Allowing the university string to be changed
            }
        }



        public double GetEasinessGrade()
        {
            return easinessGrade;
        }
        public void SetEasinessGrade(double ne)
        {
            easinessGrade = ne;
        }
        //accessor and mutator methods for the easiness grade.


        public double GetHelpfulnessGrade()
        {
            return helpfulnessGrade;
        }
        public void SetHelpfulnessGrade(double nh)
        {
            helpfulnessGrade = nh;
        }
        // accessor and mutator methods for the helpfulness grade.



        public override string ToString()
        {
            return "Professor " + firstName + " " + lastName + " instructs at " + university + ", has an easiness grade of " + easinessGrade + " out of 5, and a helpfulness grade of " + helpfulnessGrade + " out of 5.";
        }
        // ToString method to deliver output info in the manner desired

    }
}
