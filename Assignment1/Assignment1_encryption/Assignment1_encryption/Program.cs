using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_encryption
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            StringBuilder encr_str = new StringBuilder();
            StringBuilder decr_str = new StringBuilder();
            int key = 3;

            while (x != "0")
            {
                encr_str.Clear(); 
                decr_str.Clear();
                Console.Write("Write the data to be encrypted: ");
                x = Console.ReadLine();
                // exit if entered 0
                if (x == "0")  break; 
                // for encryption 
                for (int i = 0; i < x.Length; i++)
                {
                    encr_str.Append((char)(x[i] ^ key));
                }
                // for decryption
                for (int i = 0; i < encr_str.Length; i++)
                {
                    decr_str.Append((char)(encr_str[i] ^ key));
                }
                Console.WriteLine($"Entered String: {x}");
                Console.WriteLine("Encrypted String: " + encr_str.ToString());

                Console.WriteLine("Decrypted String: " + decr_str.ToString());
            }
        }
    }
}
