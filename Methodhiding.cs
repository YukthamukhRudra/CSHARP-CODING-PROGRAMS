using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodhiding
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        //this code makes the above Prntfuname method hidden:to add contractor to name :
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Constructor");
        }

    }

    public class FullTimeEmployee : Employee
    {

    }

    public class Program
    {
        public static void Main(string[] args)
        {

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "FullTime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();


            
            //PartTimeEmployee PTE= new PartTimeEmployee();
            //we can assing var  using parent class : THIS REMOVES HIDDEN METHOD AND PRINTS IT 
            Employee PTE = new PartTimeEmployee();
            PTE.FirstName = "PartTime";
            PTE.LastName = "Employee";
            //wE CAN TYPECAST AND CALL THE PTE : PTE is object is converted to  employee :REMOVES HIDDEN METHOD ADN PRINTS IT 
            ((Employee)PTE).PrintFullName();

            //PTE.PrintFullName();

        }
    }
}
