using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace list_collctions
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
                Salary = 5000

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
            Customer cust4 = new Customer()
            {
                Id = 104,
                Name = "Paxy",
                Salary = 8000
            };


            //creating an array 
            Customer[] arrcust = new Customer[2];
            arrcust[0] = cust1;
            arrcust[1] = cust2;

            //if we add 3rd eelement thought build succeeds ,runtime exception occcur
            //arrcust[2] = cust3;

            //Creating  alist
            List<Customer> listcust = new List<Customer>(2);

            //adding obj to list
            listcust.Add(cust1);
            listcust.Add(cust2);

            // however the given size is 2 , on adding 3 rd elements won't give any exception 
           //as list out grow the size automatically
            listcust.Add(cust3);

            //Printing all elements of list
            Console.WriteLine("Printing all elements of list using foreach loop");
            foreach (Customer cust in listcust)
            {
                
                Console.WriteLine("Id = {0}, Name = {1},Salary = {2}" ,cust.Id,cust.Name,cust.Salary);
            }
            Console.WriteLine("__________________________");

            //using for loop
            Console.WriteLine("Printing elements using forloop");
            for(int i=0;i < listcust.Count(); i++)
            {
                Customer c = listcust[i]; //created a list to store all the elements
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2} ",c.Id,c.Name,c.Salary);
            }

            //lists are strongltyped,it means we created Customer obj , if we try to add an obj 
            //of diff type we get compile time error

            // cannot convert from 'int' to 'list_collctions.Customer' 
            // listcust.Add(101); 
            Console.WriteLine("__________________________");

            //using Insert() method to insert any obj at specifies index,as cust4 not added at first now i 've inserted it
            Console.WriteLine("Using insert method");
            listcust.Insert(1, cust4);
            Console.WriteLine("Id = {0}, Name ={1},Salary = {2}", listcust[1].Id, listcust[1].Name, listcust[1].Salary);

            Console.WriteLine("Elements after insertion");
            for (int i = 0; i < listcust.Count(); i++)
            {
                Customer c = listcust[i]; //created a list to store all the elements
                Console.WriteLine("Id = {0} , Name = {1} , Salary = {2} ", c.Id, c.Name, c.Salary);
            }
            Console.WriteLine("__________________________");

            //to get index of specific item we use indexof method
            Console.WriteLine("INdex at customer 3 =" + listcust.IndexOf(cust3));
            Console.WriteLine("___________________________");
            
            Console.WriteLine("INdex at customer 3 =" + listcust.IndexOf(cust3,1));


        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
