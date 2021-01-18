using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionTese
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Showdata(101, "Mess Thailand", "5 Thai Rd.");
            Showdata(101, "Mess Thailand", "5 Thai Rd.");
        }
        static void Showdata(double id, string name,  string address)
        {
            Console.WriteLine("Customer ID is {0}", id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }

        static void ShowdataEdit(double id, string name, string address)
        {
            double ID = changeID(id);
            string Name = ChangeName(name);
            Console.WriteLine("Customer ID is {0}", ID);
            Console.WriteLine("Customer name is {0}", Name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }
        
        static double changeID(double id)
        {
            Console.Write("Enter your ID:");
            id = double.Parse(Console.ReadLine());
            return id;
        }

        static string ChangeName(string name)
        {
            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine();
            return name;
        }
    }
}
