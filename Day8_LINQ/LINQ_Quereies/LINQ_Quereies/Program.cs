

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LINQ_Quereies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region list of int with its quereies
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            // Query1: Display numbers without any repeated Data and sorted
            var q1 = numbers.Order().Distinct();
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Query1: Display numbers without any repeated Data and sorted \n");
            foreach (var number in q1) {
                Console.WriteLine(  number );
            }

            // Query2: using Query1  result and show each number and it’s multiplication
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Query2: using Query1  result and show each number and it’s multiplication\n ");
            var q2 = q1;

            foreach (var number in q2)
            {
                Console.WriteLine($"number: {number} , Multiply: {number*number}");
            }
            #endregion
            #region list of strings
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            // Query3: Select names with length equal 3.
            var q3 = names.Where(s => s.Length == 3);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Query3: Select names with length equal 3.\n "); 
            foreach (var item in q3) 
            {
                Console.WriteLine( item );
            }
            // Query4: Select names that contains “a” letter (Capital or Small )then sort them by length  
            var q4 = names.Where(s => s.Contains('a') || s.Contains('A')).OrderBy(s=>s.Length);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Query4: Select names that contains “a” letter (Capital or Small )then sort them \n");
            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            //Query5: Display the first 2 names
            var q5 = names.Take(2);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Query5: Display the first 2 names\n");
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }

            #endregion
            #region Subject and Student classes quereies

            List<Student> students = new List<Student>()
            {
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},
                new Student(){ ID=2, FirstName="Mona", LastName="Gala",subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject []{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},
                new Student(){ ID=1, FirstName="Ali", LastName="Ali", subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},

            };
            // Query6: Display Full name and number of subjects for each student as follow  
            var q6 = students.Select(s=> new {FullName = s.FirstName + " "+ s.LastName, NoOfSubjects = s.subjects.Count() });
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(" Query6: Display Full name and number of subjects for each student as follow \n ");
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }

            //Query7: Write a query which orders the elements in the list by FirstName Descending
            //then by LastName Ascending and result of query displays only first names
            //and last names for the elements in list as follow 

            var q7 = students.OrderByDescending(s=>s.FirstName).ThenBy(s=>s.LastName).Select(s =>  s.FirstName + " " + s.LastName );
            Console.WriteLine("-------------------------------------------------------------- ");
            Console.WriteLine("Query7: Last querey \n");
            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }


            #endregion

            Console.ReadKey();
        }
    }
}
