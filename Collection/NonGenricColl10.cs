using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class NonGenricColl10
    {
        static void Main(string[] args)
        {
            List<int> lst1 = new List<int>(); // Syntax | we can use all classes of generic in non-generic
            lst1.Add(10);
            lst1.Add(20);
            lst1.Add(25);

            foreach(int item in lst1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
