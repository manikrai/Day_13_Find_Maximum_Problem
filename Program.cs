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
            //int[] Numbers = new int[3];
            //Numbers[0] = 11;
            //Numbers[1] = 12;
            //Numbers[2]=40;
          
            Console.WriteLine(Generic.findMax(11,40,12));
            
            
            
            Console.WriteLine();
         
            // double[] Numbers2 = new double[3];
            //Numbers2[0] =609;
            //Numbers2[1]=21.34;
            //Numbers2[2]=12.1;
           
            Console.WriteLine(Generic.findMax(60.9,21.34,12.1));
            
            Console.WriteLine();
           
            //Sstring[] Names = new string[3];
           // Names[0] ="shubham";
            //Names[1] ="Rai";
            //Names[2]= "Manik";
            
            Console.WriteLine(Generic.findMax("shubham","Rai","Manik"));
            



        }
    }   }
