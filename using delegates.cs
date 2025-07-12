using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace sorting_complex_list_using_comp__delegates
{
    public class using_delegates
    {
        public static void Main()
        {
            Customer customer = new Customer();

            Customer cust1 = new Customer()
            {
                Id = 101,
                Name = "Maxy",
                Salary = 5500

            };
            Customer cust2 = new Customer()
            {
                Id = 102,
                Name = "Mucin",
                Salary = 6000
            };
            Customer cust3 = new Customer()
            {
                Id = 103,
                Name = "Sravs",
                Salary = 7000
            };

            List<Customer> listcust = new List<Customer>();
            listcust.Add(cust1);
            listcust.Add(cust2);
            listcust.Add(cust3);


            Comparison<Customer> customerComparer =
            new Comparison<Customer>(Compcust);

            Console.WriteLine("Before sorting");
            foreach(Customer c in listcust)
            {
                Console.WriteLine(c.Id);

            }

            
            Console.WriteLine("After sorting");
            foreach(Customer c in listcust)
            {
                Console.WriteLine(c.Id);
            }
            listcust.Sort(Compcust);



        }

        private static int Compcust(Customer c1, Customer c2)
        {
            return c1.Id.CompareTo(c2.Id);
        }

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }

        }
        
    }
}
