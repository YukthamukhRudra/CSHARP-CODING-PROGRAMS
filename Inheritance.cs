using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(Firstname + " " + Lastname);
        }
    }

    public class FullTimeEmployee :Employee
    {
        public float yearlysalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.Firstname = "Pragim";
            FTE.Lastname = "Tech";
            FTE.yearlysalary = 50000;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.Firstname = "Tech ";
            PTE.Lastname = "stack";
            PTE.HourlyRate = 3000;
            PTE.PrintFullName();
        }   

        
    }

    
}
