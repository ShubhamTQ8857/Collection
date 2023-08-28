using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class HashTableInColl5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(".docx", "Word File");
            ht.Add(".xlsx", "Excel File");
            ht.Add(".cs", "C# source code");
            ht.Add(".html", "Web page");

            ht.Remove(".docx");// based on key data will be removed from the hashtable

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }


    }
}
