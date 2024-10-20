using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_space
{
    public struct HiringDate {

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int Day, int Month, int Year) {

            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }

        public HiringDate(int Day, int Month) : this(Day, Month, DateTime.Now.Year) { }
        public HiringDate(int Day) : this(Day, DateTime.Now.Month, DateTime.Now.Year) { }
        public override string ToString()
        {
            return $"Hired in {Day}/{Month}/{Year}";
        }

        public int NumOfDays() {
            DateTime hireDate = new DateTime(Year, Month, Day);
            TimeSpan timeSpan = DateTime.Now - hireDate;
            return timeSpan.Days;
        }
       

    }
    public class Employee
    {
        public int ID { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }

        string gender;
        public string Gender { get { return gender; } 
            set {

                value = value.ToUpper();
                if (value == "MALE" || value == "FEMALE")
                {
                     gender= value;
                }
                else gender = "";
            }
        }

        public override string ToString()
        {
            return $"ID:{ID}, Salary:{Salary}, Gender: {Gender},Hiring Date:{HireDate.ToString()} , Hired since: {HireDate.NumOfDays()} days";
        }

        public Employee(int ID, double Salary, string Gender, HiringDate hire) {

            this.ID = ID;
            this.Salary = Salary;
            Gender = Gender.ToUpper();
            if (Gender == "MALE" || Gender == "FEMALE")
            {
                gender = Gender;
            }
            else gender = "UNKNOWN";

            this.HireDate = hire;
        
        }


    }
}
