using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem
{
    internal class UC1_Integers
    {
        public static void TestCase()
        {
            Console.WriteLine("Enter First Number: ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int y=Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter Third Number: ");
            int z=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if(x>y && x>z)
            {
                Console.WriteLine(x + "Is Maximum");
            }
            else if(y>z && y>x)
            {
                Console.WriteLine(y + "Is Maximum");
            }
            else if(z>x && z>y)
            {
                Console.WriteLine(z + "Is Maximum");
            }
            else
            {
                Console.WriteLine("You Entered Same Inputs");            }
        }
    }
}
