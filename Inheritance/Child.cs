using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Child : Parent
    {
        private string studentName;
        private int grade;

        public Child()
        {
            studentName = null;
            grade = 1;
        }

        public string getStudentName()
        {
            return studentName;
        }
        public void setStudentName(string studentName)
        {
            this.studentName = studentName;
        }
        public int getGrade()
        {
            return grade;
        }
        public void setGrade(int grade)
        {
            this.grade = grade;
        }
        public new void display()
        {
            Console.WriteLine("Student Name: " + studentName + " " + getFamilyName() + "\nStudent ID#: " + getID() + "\nAddress: " + getAddr() + "\nGrade: " + grade);
        }
    }
}
