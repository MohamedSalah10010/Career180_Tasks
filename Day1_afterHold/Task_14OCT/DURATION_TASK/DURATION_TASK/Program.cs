using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DURATION_TASK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.getString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.getString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.getString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.getString());
            Console.ReadKey();
        }
    }
}
