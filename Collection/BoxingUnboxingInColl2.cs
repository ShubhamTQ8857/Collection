using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class BoxingUnboxingInColl2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(11); // boxing , implicit
            list.Add(5.6);
            list.Add("Pune");

            //unboxing --> explicit

            double d = Convert.ToDouble(list[1]);
            Console.WriteLine(d);

            string str = list[2].ToString();
            Console.WriteLine(str);
        }

    }
}
