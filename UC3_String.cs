using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem
{
    internal class UC3_String
    {
        

        public static void str()
        {
            

            Console.WriteLine("Enter First String: ");
            string x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Second String: ");
            string y = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Third String: ");
            string z = Convert.ToString(Console.ReadLine());

            Console.WriteLine();

            if (x.Length > y.Length && x.Length > z.Length)
            {
                Console.WriteLine(x + "Is Maximum ");
            }
            else if(y.Length > z.Length && y.Length > x.Length)
            {
                Console.WriteLine(y + "Is Maximum");
            }
            else if(z.Length > x.Length && z.Length > y.Length)
            {
                Console.WriteLine(z + "Is Maximum");
            }
            else
            {
                Console.WriteLine("Strings Has Same Length");
            }

            
        }
        
    }
}
