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
            UInt64 ID = 101;
            string Name = "Mess Thailand";
            string Address = "5 Thai Rd.";
            Showdata(ID, Name, Address);
            ShowdataEdit(ID, Name, Address);
        }
        static void Showdata(UInt64 id, string name,  string address)
        {
            Console.WriteLine("Customer ID is {0}", id);
            Console.WriteLine("Customer name is {0}", name);
            Console.WriteLine("Customer address is {0}", address);
            Console.WriteLine();
        }

        static void ShowdataEdit(UInt64 id, string name, string address)
        {
            UInt64 ID = changeID(id);
            string Name = ChangeName(name);
            Console.WriteLine("Customer ID is :{0}", ID);
            Console.WriteLine("Customer name is :{0}", Name);
            Console.WriteLine("Customer address is :{0}", address);
            Console.WriteLine();
        }
        
        static UInt64 changeID(UInt64 id)
        {
            Console.Write("Enter your ID:");
            id = UInt64.Parse(Console.ReadLine());
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
