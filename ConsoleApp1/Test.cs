using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test
    {
        // Attributes or variables3
        private string name;
        private int grade;

        // Explicitly defined construcctor
        public Test(string name, int grade)
        {
            this.name = name;
            this.grade = grade;
            Console.WriteLine("Non-static constructor called");

        }
        // Copy constructor
        // takes in another object as a parameter
        public Test(Test obj)
        {
            this.name = obj.name + " Jr.";
            this.grade = obj.grade - 4;
            Console.WriteLine("Non-static COPY constructor");
        }
        // Static constructor will always be called first and will always be called
        static Test()
        {
            Console.WriteLine("This is a static constructor call");
        }
        // Function or method
        public void printInfo()
        {
            Console.WriteLine("Name: " + name + "\nGrade: " + grade);
        }
        
    }
}
