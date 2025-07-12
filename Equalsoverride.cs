using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEquals__
{
    public class Equalsoverride
    {
        public static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.FirstName = "Simon";
            c1.LastName = "Ton";

            Customer c2 = new Customer();
            c2.FirstName = "Simon";
            c2.LastName = "Ton";

            Console.WriteLine(c1==c2);
            Console.WriteLine(c1.Equals(c2));
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Customer))
            {
                return false;
            }

            return this.FirstName  == ((Customer)obj).FirstName  && 
                this.LastName == ((Customer)obj).LastName;
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
