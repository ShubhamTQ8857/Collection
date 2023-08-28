using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class DictionaryInColl11
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>(); 

            dic.Add(".docx", "word file");
            dic.Add(".xlsx", "Excel file");
            dic.Add(".cs", "c# file");

            foreach(KeyValuePair<string,string> item in dic)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }

            Dictionary<int, string> dic1 = new Dictionary<int, string>();

            dic1.Add(101, "India");
            dic1.Add(102, "Pakistan");
            dic1.Add(103, "West Indies");

            foreach (KeyValuePair<int, string> item in dic1)
            {
                Console.WriteLine($"{item.Key}{item.Value}");
            }
        }
    }
}
