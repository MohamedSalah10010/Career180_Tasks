using System;
using Student_class_library;

namespace Test_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Mohamed", "Salah", 24,80,"Computer Engineering");

            Student S2 = new Student("Ahmed", "Saleh", 21, 77, "Data Engineering");

            Console.WriteLine(S1.DisplayDetails());
            Console.WriteLine();
            Console.WriteLine(S2.DisplayDetails());
            Console.ReadKey();
        }
    }
}
