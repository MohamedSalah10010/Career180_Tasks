using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_Calc_using_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_op="";
            double x=0, y=0,sum=0;

            while (user_op != "e" && user_op != "E") {
                
                Console.Write("Enter the desired operation (+, -, *, /) or 'E' to exit: ");
                user_op = Console.ReadLine();

                switch (user_op) {

                    case "+":
                        Console.Write("Enter 1st number: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        y = double.Parse(Console.ReadLine());
                        sum = x + y;
                        Console.Write("res: {0} {1} {2} = {3}  \n", x, user_op, y, sum);
                        break;

                    case "-":
                        Console.Write("Enter 1st number: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        y = double.Parse(Console.ReadLine());
                        sum = x - y;
                        Console.Write("res: {0} {1} {2} = {3} \n", x,user_op, y, sum);
                        break;

                    case "*":
                        Console.Write("Enter 1st number: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        y = double.Parse(Console.ReadLine());
                        sum = x * y;
                        Console.Write("res: {0} {1} {2} = {3} \n", x, user_op, y, sum);
                        break;

                    case "/":
                        Console.Write("Enter 1st number: ");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("Enter 2nd number: ");
                        y = double.Parse(Console.ReadLine());
                        if (y != 0)
                        {
                            sum = x / y;
                            Console.Write("res: {0} {1} {2} = {3}  \n", x, user_op, y, sum);
                        }
                        else Console.Write("can't divide by 0\n");

                       
                        break;

                    case "E":
                    case "e":
                        Console.Write("EXITING....  ");
                        break;

                    default: Console.Write("invalid operation\n");break;


                }

            }
        }
    }
}
