using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStackTest
{
    public class ArrayStackTesr
    {
        public static void Main(string[] args)
        {

            ArrayStack stack = new ArrayStack(5);

            int i = 0;
            while (i < 5)
            {
                i++;
                string objToPush = "obj" + i;
                Console.Write("Enter person to present is :");
                objToPush = Console.ReadLine();

                stack.push(objToPush);
            }
        }

        public static void Cout()
        {

        }
    }
}
