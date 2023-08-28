using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class GenericCollectionAssignments
    {
      public static int Addition (int a, int b) //demo to create method
        {
            int add = a + b;
            return add;
        }

        public static int Substraction (int a, int b) //demo to create method
        {
            int sub = a - b;
            return sub;
        }
        
        static void Main(string[] args)
        {
            /* int a = Convert.ToInt32(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine(Addition(a, b));*/

            //Console.WriteLine($"Substraction Is: {Substraction(5, 3)}");

            //Write Code to create an array of 5 integers. Initialize 5 values. Display Using For Each Loop.
            /*int[] array = new int[5];

            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Enter Array Value");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Using For Each Loop
            *//*foreach(int item in array)
            {
                Console.WriteLine(item);
            }*//*
            //Using For Loop
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }*/

            List<string> lst1 = new List<string>() {"Shubham", "Prakash", "Vikas", "Akshay", "Jay" };
            foreach(string names in lst1)
            {
                Console.WriteLine(names);
            }
            lst1.Sort();
            Console.WriteLine("Sorted Array:-------------");
            foreach (string names in lst1)
            {
                Console.WriteLine(names);
            }
            foreach (string names in lst1)
            {
                Console.WriteLine(names);
            }

        }
    }
}
