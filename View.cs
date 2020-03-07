using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    public class View
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }

        public void Print(List<string> list)
        {
            foreach(string ele in list)
            {
                Console.Write("{0} ", ele);
            }
            Console.WriteLine();
        }

        public void Print(Dictionary<string, int> dict)
        {
            foreach(string key in dict.Keys)
            {
                Console.WriteLine("{0} : {1}", key, dict[key]);
            }
            
        }
    }
}