using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_class_library
{
    public class Student
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Grade { get; set; }
        public string Major { get; set; }

        public Student(string firstName, string lastName, int age, double grade, string major)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Grade = grade;
            Major = major;
        }

       

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        
        public string DisplayDetails()
        {
            return $"Name: {GetFullName()}\nAge: {Age}\nMajor: {Major}\nGrade: {Grade}  \"{getGrade()}\" ";
           
        }

        public char getGrade() {

            if (Grade >= 85)
                return 'A';
            else if (Grade >= 75)
                return 'B';
            else if (Grade >= 65)
                return 'C';
            else if (Grade >= 55)
                return 'D';
            else
                return 'F';

        }
    }
}
