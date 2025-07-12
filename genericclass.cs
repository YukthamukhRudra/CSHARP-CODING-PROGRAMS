using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{

    //this is just a method , and this method is calledd in another main method
    public class Calculators<T>
    {
        public static bool areequl(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
