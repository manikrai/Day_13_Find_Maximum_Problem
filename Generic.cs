using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Maximum_Problem
{
    internal class Generic
    {
        public static T findMax<T>(T x,T y,T z) where T : IComparable<T>
        {

            T max = x;
            if(y.CompareTo(max)>0)
            {
                max = y;
            }
            else if(z.CompareTo(max)>0)
            {
                max=z;
            }
            return max;
            
            
        }
      
    }
 }

