using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class user
    {
        static void Main(string[] args)
        {
            string D_or_W = null;
            Console.Write("You want to deposit or withdraw (d/w):");
            D_or_W = Console.ReadLine();
            Bank N = new Bank(D_or_W);
            //Banks n = new Banks();
      
        }
    }
}
