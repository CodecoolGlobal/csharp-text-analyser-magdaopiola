using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    class StatisticalAnalysis
    {
        private Dictionary<string, int> dict = new Dictionary<string, int>();
        private List<string> list = new List<string>();
        private string str;
        public View view = new View();

        public StatisticalAnalysis(Iterator iterator)
        {
            while(iterator.HasNext())
            {
                string element = iterator.MoveNext().ToLower();
                list.Add(element);

                if(dict.ContainsKey(element))
                {
                    dict[element]++;
                }
                else
                {
                    dict.Add(element, 1);
                }
            }
            str = list.ToString();
        }

        public int CountOf(params string[] args)
        {
            int sum = 0;
            foreach(string ele in args)
            {
                if(dict.ContainsKey(ele.ToLower()))
                {
                    sum += dict[ele.ToLower()];
                }
            }
            return sum;
        }

        public int DictionarySize()
        {
            return dict.Count;
        }

        public int Size()
        {
            return list.Count;
        }

        public ISet<string> OccurMoreThan(int n)
        {
            ISet<string> set = new HashSet<string>();

            foreach(string key in dict.Keys)
            {
                if(dict[key] > n)
                {
                    set.Add(key);
                }
            }
            return set;
        }
    }
}