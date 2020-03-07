using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    class Program
    {
        static void Main(string[] args)
        {
            FileContent fileContent = new FileContent("test.txt");
            Iterator charIterator = fileContent.CharIterator();
            Iterator wordIterator = fileContent.WordIterator();

            StatisticalAnalysis obj = new StatisticalAnalysis(wordIterator);
            int countOf = obj.CountOf("This", "is");
            Console.WriteLine(countOf);
            int dictSize = obj.DictionarySize();
            Console.WriteLine(dictSize);
            int size = obj.Size();
            Console.WriteLine(size);
            ISet<string> occure = obj.OccurMoreThan(4);
            foreach(string ele in occure)
            {
                Console.WriteLine(ele);
            }
            

            //Console.WriteLine("\n\n{0}", wordIterator.MoveNext());

        }
    }
}
