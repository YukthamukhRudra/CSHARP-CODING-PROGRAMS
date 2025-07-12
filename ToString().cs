using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace override_and_tostring_method
{
    public class ToString__
    {
        public static void Main()
        {
            int number = 30;
            Console.WriteLine(number.ToString());

            Customer c1 = new Customer();
            c1.FirstName = "Simon";
            c1.LastName = "Ton";

            //Console.WriteLine(c1.ToString());
            Console.WriteLine(Convert.ToString(c1));


        }
    }

    public class Customer
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public override string ToString()
        {
            return this.FirstName + "," + this.LastName;
        }
    }
}
