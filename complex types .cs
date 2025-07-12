using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sorting_list_of_complex_types
{
    public class Program
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

            Console.WriteLine("Before Sorting");
            foreach(Customer c in listcust)
            {
                Console.WriteLine(c.Salary);
            }
            listcust.Sort();

            Console.WriteLine("After Sorting ");
            foreach(Customer cr in listcust)
            {
                Console.WriteLine(cr.Salary);
            }
        }
    }
    //comp types will have private properties like name,id,salary & sort can't undstnd which to sort so we use compareto()
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer obj)
        {
            //if(this.Salary  < obj.Salary)
            //{
            //    return 1;
            //}
            //else if(this.Salary > obj.Salary)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.Salary.CompareTo(obj.Salary);
        }
    }
}
