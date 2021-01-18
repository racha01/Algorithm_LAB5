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
            int n_person;
            Console.Write("Enter umber of person to present:");
            n_person = int.Parse(Console.ReadLine());
            ArrayStack stack = new ArrayStack(n_person);
            //ArrayStack stack = new ArrayStack(10);

            int i = 0;
            while (i < n_person)
            {
                i++;
                string objToPush = "obj" + i;
                Console.Write("Enter person to present is");
                objToPush = Console.ReadLine();

                stack.push(objToPush);
            }

            /*for (int i = 0; i < 10; i++)
            {
                string objToPush = "obj" + i;

                Console.WriteLine("Pushing: {0}", objToPush);

                stack.push(objToPush);
            }*/

            while (!stack.isEmpty())
            {
                string objPoped = (string)stack.pop();
                Console.WriteLine("The next person to present is: {0}", objPoped);    
            }
        }
    }
}
