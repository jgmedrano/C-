using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class School
    {
        static void Main()
        {
            List<Child> children = new List<Child>();
            Parent one = new Parent();
                        
            Console.WriteLine("Hello, Administrator");
            
            for(; ;)
            {
                if (askToEnroll())
                {
                    Child kid = new Child();
                    //enroll();
                    Console.WriteLine("Enter child's first name:");
                    kid.setStudentName(Console.ReadLine());

                    Console.WriteLine("Enter last name: ");
                    kid.setFamilyName(Console.ReadLine());

                    kid.setID(1);

                    Console.WriteLine("Enter address: ");
                    kid.setAddr(Console.ReadLine());

                    Console.WriteLine("Enter " + kid.getStudentName() + "'s grade: ");
                    kid.setGrade(Convert.ToInt32(Console.ReadLine()));

                    children.Add(kid);

                }
                else
                    break;
            }
            Console.WriteLine("\nEnrolled Student' information: ");
            foreach (Child child in children)
            {
                child.display();
                Console.WriteLine();
            }
            Console.WriteLine("\nSession Concluded...");            
        }
        
        public static void enroll()
        {
            Child kid = new Child();

            Console.WriteLine("Enter child's first name:");
            kid.setStudentName(Console.ReadLine());

            Console.WriteLine("Enter last name: ");
            kid.setFamilyName(Console.ReadLine());

            kid.setID(1);

            Console.WriteLine("Enter address: ");
            kid.setAddr(Console.ReadLine());

            Console.WriteLine("Enter " + kid.getStudentName() + "'s grade: ");
            kid.setGrade(Convert.ToInt32(Console.ReadLine()));
        }

        public static bool askToEnroll()
        {
            string userAnswer = null;

            Console.WriteLine("Would you like to enroll more students? \nEnter yes or no (Y/N).");

            userAnswer = Console.ReadLine();

            if (userAnswer.ToUpper() == "Y" || userAnswer.ToUpper() == "YES")
            {
                return true;
            }
            else if(userAnswer.ToUpper() == "N" || userAnswer.ToUpper() == "NO")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Type in 'yes/y' or no/n'.");
                return false;
            }
        }
    }
}
