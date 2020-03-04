using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    class CharIterator : Iterator
    {
        public CharIterator(FileContent fileContent) : base(fileContent)
        {
            List<string> tempList = new List<string>();
            for(int i = 0; i < fileContent.content.Length; i++)
            {

            }
        }

        public bool HasNext()
        {

        }
        public string MoveNext()
        {

        }
        
    }
}