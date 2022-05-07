// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
namespace Find_Maximum_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //UC1_Integers.TestCase();
            // UC2_Floats.Max();
            //UC3_String.str();
            int[] intArray = { 112, 432, 344, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "Apple", "Banana", "Peach" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();



        }
    }   }
