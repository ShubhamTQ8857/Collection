using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    //IComparable Interface → compare data between two objects
    public class Product : IComparable
    {
        private int pid;
        private int price;
        private string pname;

        public Product(int pid, int price, string pname)
        {
            this.pid = pid;
            this.price = price;
            this.pname = pname;
        }
        public int CompareTo(object obj)
        {
            //convert object to Product class
            Product p = (Product)obj;
            //this --> samsunng, p --> sony
            if(this.price < p.price)
            {
                return 1;
            }
            else if(this.price > p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{pid}{pname}{price}";
        }
    }

    internal class InterfacesInColl8
    {
        static void Main(string[] args)
        {
            Product tv1 = new Product(2568, 42000, "SamsungS987K");
            Product tv2 = new Product(1459, 45000, "SonyX75K");

            int result = tv1.CompareTo(tv2);
            if(result == -1)
            {
                Console.WriteLine("Samsung TV Price Is Higher Than Sony TV");
            }
            else if (result == 1)
            {
                Console.WriteLine("Samsung TV Price Is Less Than Sony TV");
            }
            else
            {
                Console.WriteLine("Both TV Has Same Price");
            }
        }
    }
}
