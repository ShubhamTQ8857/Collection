using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;

namespace Collection
{
    internal class Collection1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection");
           
            ArrayList list = new ArrayList();
            list.Add(11);
            list.Add(22);
            list.Add(38);

            list.Insert(1, 2); // It will add 2 at index 1
            int[] arr = new int[] { 67, 45, 12, 78 };
            list.AddRange(arr); //add multiple values at time | for this we declare an seperate array 

            //remove the element based on index
            //list.Remove(1);
            //remove multiple element at once
           list.RemoveRange(2, 3); //it will remove 3 elements from index 2

            list.Sort();
            list.Reverse();
            //Console.WriteLine("Count of total elements: " + list.Count);
            //Console.WriteLine("Capacity: " + list.Capacity);

            foreach(var item in list)
            {
                Console.WriteLine(item);
            }


        }
    }
}
