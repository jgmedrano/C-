using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling two instances of the Test class
            Test Try0 = new Test("Bob", 12); // Calls the explicit constructor
            Test Try1 = new Test(Try0); // Passing in an object as a parameter will call the copy constructor

            Try0.printInfo();
            Try1.printInfo();
        }
    }
}
