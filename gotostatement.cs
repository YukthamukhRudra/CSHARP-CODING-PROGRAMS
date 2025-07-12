using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchgotostatement
{
    //goto statement is used to jump from one control to another locations which makes the debugging very complex ,so goto is
    // not recommended and it is a bad programming style instead we use  loops
    class gotostatement
    {
        static void Main(string[] args)
        {
            int TotalCoffeecost = 0;
        Start:
            Console.WriteLine("1-Small 2-Medium 3-Large ");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            

            switch (userchoice)
            {
                case 1:
                    TotalCoffeecost += 1;
                    break;
                case 2:
                    TotalCoffeecost += 2;
                    break;
                case 3:
                    TotalCoffeecost += 3;
                    break;
                default:
                    Console.WriteLine("Please enter a valid input,your choice {0} is invalid", userchoice);
                    goto Start;
            }
            Decide:
            Console.WriteLine("Do you want to buy another coffee : Yes or No");
            string input = Console.ReadLine();
            switch (input.ToUpper())
            {
                case "YES":
                    goto Start;
                    break;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice is {0} is invalid ", input);
                    goto Decide;
            }
            Console.WriteLine("Thankyou for shopping with us ");
            Console.WriteLine("Your bill amount is {0}", TotalCoffeecost);
        }
    }
}
