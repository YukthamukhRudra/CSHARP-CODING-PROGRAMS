using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_genericclassandrange
{
    public class list
    {
        public static void Main()
        {
            Customer customer = new Customer();

            Customer cust1 = new Customer()
            {
                Id = 101,
                Name = "Maxy",
                Salary = 5500,
                Type = "Corporate user"

            };
            Customer cust2 = new Customer()
            {
                Id = 102,
                Name = "Mucin",
                Salary = 6000,
                Type = "Corporate user"
            };
            Customer cust3 = new Customer()
            {
                Id = 103,
                Name = "Sravs",
                Salary = 7000,
                Type = "Corporate user"
            };
            Customer cust4 = new Customer()
            {
                Id = 104,
                Name = "Pavs",
                Salary = 7000,
                Type = "Retail user"
            };
            Customer cust5 = new Customer()
            {
                Id = 105,
                Name = "pankaj",
                Salary = 7000,
                Type = "Retail user"
            };

            List<Customer> cust = new List<Customer>();
            cust.Add(cust1);
            cust.Add(cust2);
            cust.Add(cust3);

            List<Customer> corpusers = new List<Customer>();
            corpusers.Add(cust4);
            corpusers.Add(cust5);

            //AddRange()
            Console.WriteLine("AddRange()");
            cust.AddRange(corpusers);
            foreach(Customer c in corpusers)
            {
                Console.WriteLine("Id = {0},Name = {1} ,Salary = {2} , Type = {3} ",c.Id,c.Name,c.Salary,c.Type);
            }
            Console.WriteLine("__________________");

            //GetRange()
            Console.WriteLine("gETRANGE() ");
            List<Customer> elements = cust.GetRange(0,4);
            foreach(Customer c in elements)
            {
                Console.WriteLine("Id = {0} ,Name ={1},Salary ={2},Type ={3} ", c.Id,c.Name,c.Salary,c.Type);
            }
            Console.WriteLine("___________________");

            //InsertRange()
            Console.WriteLine("Insertrange");
            cust.InsertRange( 0, corpusers);
            foreach (Customer cr in cust)
            {
                Console.WriteLine("Id = {0} ,Name ={1},Salary ={2},Type ={3} ", cr.Id, cr.Name, cr.Salary, cr.Type);
            }
            
            Console.WriteLine("___________________");

            cust.InsertRange(3, corpusers);
            foreach (Customer crs in cust)
            {
                Console.WriteLine("Id = {0} ,Name ={1},Salary ={2},Type ={3} ", crs.Id, crs.Name, crs.Salary, crs.Type);
            }


            //remove range()
            Console.WriteLine("Remove range");
            cust.Remove(cust1);
            cust.RemoveAt(1);
            cust.RemoveAll(x => x.Type == "Corporate user");
            foreach(Customer cus in cust)
            {
                Console.WriteLine("Id = {0} ,Name ={1},Salary ={2},Type ={3} ", cus.Id, cus.Name, cus.Salary, cus.Type);
            }

            Console.WriteLine( "removing range of elements ");
            cust.RemoveRange(0, 5);
            foreach (Customer rerr in cust)
            {
                Console.WriteLine("Id = {0} ,Name ={1},Salary ={2},Type ={3} ", rerr.Id, rerr.Name, rerr.Salary, rerr.Type);
            }



        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
