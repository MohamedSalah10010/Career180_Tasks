using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{

    class Queue<thing> {

        int lastIndex;
        int firstIndex;
        thing[] arr;

        public Queue(int size = 10) {

            arr = new thing[size];
            firstIndex=0;
            lastIndex = 0;
        }

        public void push(thing item) {

            if (lastIndex < arr.Length)
            {
                arr[lastIndex++] = item;
            }
            else throw new InvalidOperationException("Queue is full.");

        }
        public thing pop() {

            if (firstIndex < lastIndex)
            {

                return arr[firstIndex++];
            }
            else
            {
                firstIndex = 0;
                lastIndex = 0;
                return default(thing);
            }
        }


    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> s = new Queue<int>(5);
            s.push(12);
            s.push(4);
            s.push(22);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            s.push(1122);
            s.push(450);
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Console.WriteLine(s.pop());
            Queue<string> st = new Queue<string>();
            st.push("mostafa");
            st.push("ahmed");
            st.push("Abosalah");
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());
            st.push("mostafa_again");
            st.push("ahmed_last");
            st.push("Abosalah_forever");
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());
            Console.WriteLine(st.pop());

            Console.ReadKey();

        }
    }
}
