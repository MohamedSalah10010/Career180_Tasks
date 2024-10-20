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
            Console.WriteLine(D1.ToString());
            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            Duration D5 = new Duration(16);
            Console.WriteLine(D5.ToString());

            Duration sumD = D1 + D2;
            Console.WriteLine(sumD.ToString());
            Duration sumDurationSec = 666+D3;
            Console.WriteLine(sumDurationSec.ToString());
            sumD++;
            Console.WriteLine( sumD.ToString() );
            D3 = --D2;
            Console.WriteLine(D3.ToString());
            if (D1 <= D2) {
                Console.WriteLine("D1  <= D2");
            }
            else Console.WriteLine("D1 >= D2");
            Console.ReadKey();

        }
    }
}
