using System;
using System.Xml.Serialization;

interface ICustomer
{
    void Print();
    interface I2
    {
        void I2Method();
    }
    interface ICustomer1
    {
        void Print1();
    }
    //7 
    interface ICustomer2 : ICustomer1
    {
        void Print2();
    }
    public class Customer : ICustomer,ICustomer2,I2
    {
        public void Print()
        {
            Console.WriteLine("Interface Print Method");
        }
        public void I2Method()
        {
            Console.WriteLine("I2 method");
        }
        public void Print2()
        {
            Console.WriteLine("Print2 method");
        }
        public void Print1()
        {
            Console.WriteLine("Print1 method");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Customer c1 = new Customer();
            c1.Print1();
            c1.Print2();

            //8 - can't crte inst of inter ,but an int ref var can point to derived cls object
            ICustomer1 cust = new Customer();
            cust.Print1();
        }
    }
}
