using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class MyDatabase
    {
        /*************************************************
         * Properties/Field zone
        *************************************************/
        int customerID;
        string strName;
        string strAddress;

        /*************************************************
        * Method zone
        *************************************************/

        public MyDatabase()
        {
            customerID = -1;
            strName = "Unkhow";
            strAddress = "Unkhow";
        }

        public MyDatabase(int id, string name, string address)
        {
            customerID = id;
            strName = name;
            strAddress = address;
        }

        public void ShowCustomer()
        {
            Console.WriteLine("Customer ID is {0}", customerID);
            Console.WriteLine("Customer name is {0}", strName);
            Console.WriteLine("Customer address is {0}", strAddress);
            Console.WriteLine();
        }
    }
}
