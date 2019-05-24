using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
        private string familyName;
        private int id;
        private string address;

        public Parent()
        {
            id = 0;
            address = null;
        }
        public int getID()
        {
            return id;
        }
        public void setID(int id)
        {
            this.id = id;
        }
        public string getAddr()
        {
            return address;
        }
        public void setAddr(string address)
        {
            this.address = address;
        }
        public string getFamilyName()
        {
            return familyName;
        }
        public void setFamilyName(string familyName)
        {
            this.familyName = familyName;
        }
        public void display()
        {
            Console.WriteLine("Family: " + familyName + "\nAddress: " + address + "\nID #: " + id);
        }

    }
}
