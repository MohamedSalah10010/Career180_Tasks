using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingEmployeeToClub
{
    public class Employee {

        public event Action<Employee> addEmp;
        public int ID { get; set; }
        public string EMP_NAME { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int salary, int age) {


            ID = id;
            EMP_NAME = name;
            Salary = salary;
            Age = age;
        }

        public void AddEmployee() {

            addEmp.Invoke(this);
        }

        public override string ToString()
        {

            return $"employee{ID}: {EMP_NAME} is working with salary of {Salary} @ age of {Age}. ";
        }




    }

    public  class Club {

        public int ID { get; set; }
        public string Name { get; set; }
        public String Location{ get; set; }

        public Club(int id, string name, string location) {

            ID = id;
            Name = name;
            Location = location;

        }

        public void addToClub(Employee emp) {

            Console.WriteLine($"{emp} \nHe's currently working in club {Name} at {Location}");

        }

        public override string ToString()
        {
            return $"Club {Name} is located at {Location}.";
        }

    }


    public class SocialInsurance {

        public int SocialInsuranceNumber { get; set; }
        public int Emp_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public SocialInsurance(int SocialNum, Employee emp, DateTime start, DateTime end) {

            SocialInsuranceNumber = SocialNum;
            Emp_ID = emp.ID;
            StartDate = start;
            EndDate = end;
        
        }

        public  void addInsurance(Employee emp) {

            Console.WriteLine($"Empolyee{emp.ID} : {emp.EMP_NAME} is succesfully got his insurance number [{SocialInsuranceNumber}].");
        }
        public override string ToString()
        {
            return $"Employee {Emp_ID}'s insurance number is {SocialInsuranceNumber}.";
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Ahmed = new Employee(1, "Ahmed Salah", 2500, 25);
            Employee Mohamed = new Employee(2, "Mohamed Salah", 2800, 22);
            Employee Ali = new Employee(3, "Ali Salah", 3500, 23);

            Club LiverPool = new Club(1500, "LiverPool Club", "Liverpool City, England");
            SocialInsurance insurance1 = new SocialInsurance(112255, Ahmed, DateTime.Today, DateTime.Today.AddYears(2));
            SocialInsurance insurance2 = new SocialInsurance(113344, Mohamed, DateTime.Today, DateTime.Today.AddYears(3));
            SocialInsurance insurance3 = new SocialInsurance(227788, Ali, DateTime.Today, DateTime.Today.AddYears(4));

            Ahmed.addEmp += LiverPool.addToClub;
            Ahmed.addEmp += insurance1.addInsurance;


            Mohamed.addEmp += LiverPool.addToClub;
            Mohamed.addEmp += insurance2.addInsurance;


            Ali.addEmp += LiverPool.addToClub;
            Ali.addEmp += insurance3.addInsurance;

            Ahmed.AddEmployee();
            Console.WriteLine();
            Mohamed.AddEmployee();
            Console.WriteLine();
            Ali.AddEmployee();
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
