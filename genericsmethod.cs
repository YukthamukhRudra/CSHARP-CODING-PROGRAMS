using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    public class genericsmethod
    {
        private static void Main()
        {
            //variables of Calculator class written on same page

            bool Equal = Calculator.AreEqual<int>(10, 20);
            if(Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            //variables of another method
            
            bool Equals = Calculators<string>.areequl("A", "A");
            if (Equals)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    
}
