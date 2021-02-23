using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        static string Name = null;
        static UInt64 Amount = 0;
        static void Showdata()
        {

        }
        public Bank(string D_or_W)
        {
            Console.Write("Enter your name :");
            Name = Console.ReadLine();
            Console.Write("Enter amount :");
            Amount = UInt64.Parse(Console.ReadLine());

            if (D_or_W == "d")
            { 
                Console.WriteLine("{0} make a deposit in the amount {1}", Name, Amount);
            }
            else if (D_or_W == "w")
            {

                Console.WriteLine("{0} make a withdrawal in the amount {1}", Name, Amount);
            }
        }
    }
    
}

