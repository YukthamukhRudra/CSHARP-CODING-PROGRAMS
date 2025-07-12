using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class Program
    {

        //overloading is only possible based upon the count of parameters 
        public static void Main()
        {
            Program.Add(2, 3, 4);
            Program.Add(2, 3);

        }
        public static void Add(int FN, int LN)
        {
            
            Console.WriteLine("Sum {0}:", FN + LN);

        }
        public static void Add(int FN, int LN, int total)
        {
            Console.WriteLine("Sum : {0}", FN + LN + total);
        }

    }


}
