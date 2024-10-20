using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_space;

namespace Employee_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size,counter=1;
            Console.Write("Enter the number of employees: ");
            int.TryParse(Console.ReadLine(),out size);

           
            Employee[] employees = new Employee[size];

            foreach (Employee i in employees)
            {
                Console.WriteLine($"\nEnter details for employee {counter++}:");

                Console.Write("ID: ");
                int id;
                int.TryParse(Console.ReadLine(), out id);

                Console.Write("Salary: ");
                double salary;
                double.TryParse(Console.ReadLine(),out salary);

                Console.Write("Hire Day: ");
                int day;
                int.TryParse(Console.ReadLine(),out day);

                Console.Write("Hire Month: ");
                int month;
                int.TryParse(Console.ReadLine(), out month);

                Console.Write("Hire Year: ");
                int year;
                int.TryParse(Console.ReadLine(), out year);

                Console.Write("Gender(MALE or FEMALE): ");
                String gender = Console.ReadLine();

                if (year <= 0) employees[--counter] = new Employee(id, salary, gender, new HiringDate(day, month));
                else if (month <=0 && year <=0) employees[--counter] = new Employee(id, salary, gender, new HiringDate(day ));
                else employees[--counter] = new Employee(id, salary, gender, new HiringDate(day, month, year));
            }

            counter = 1;

            //Sorting the array based on NumOfDays
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[i].HireDate.NumOfDays() > employees[j].HireDate.NumOfDays())
                    { 
                        Employee temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                }
            }
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }

        }
    }
}
