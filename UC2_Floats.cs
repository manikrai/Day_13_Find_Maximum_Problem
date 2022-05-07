using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem
{
    internal class UC2_Floats
    {
        public static void Max()
        {
            Console.WriteLine("Enter First Number: ");
            double x =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Third Number: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (x > y && x > z)
            {
                Console.WriteLine(x + "Is Maximum");
            }
            else if (y > z && y > x)
            {
                Console.WriteLine(y + "Is Maximum");
            }
            else if (z > x && z > y)
            {
                Console.WriteLine(z + "Is Maximum");
            }
            else
            {
                Console.WriteLine("You Entered Same Inputs");
            }
        
         }
    }
}
