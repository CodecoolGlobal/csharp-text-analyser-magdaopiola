using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    class CharIterator : Iterator
    {
        public CharIterator(FileContent fileContent) : base(fileContent)
        {
            List<string> tempList = new List<string>();
            for(int i = 0; i < fileContent.Content.Length; i++)
            {
                Char temp = fileContent.Content[i];
                if(!Char.IsWhiteSpace(temp))
                {
                    tempList.Add(Char.ToString(temp));
                }
            }
            textArray = tempList.ToArray();
        }

        public override bool HasNext()
        {
            if (pos >= textArray.Length || textArray[pos] == null) 
                return false; 
            else
                return true; 
        }
        public override string MoveNext()
        {
            string str = textArray[pos]; 
            pos += 1; 
            return str;
        }
        
    }
}