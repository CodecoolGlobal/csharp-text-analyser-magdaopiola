using System;
using System.Collections.Generic;

namespace csharp_text_analyser_magdaopiola
{
    class WordIterator : Iterator
    {
        public WordIterator(FileContent fileContent) : base(fileContent)
        {
            List<string> tempList = new List<string>();
            int i = 0;
            
            //while iterait through words
            while(i < fileContent.Content.Length)
            {
                int start = WordStartIndex(fileContent.Content, i);
                int end = -1;
                if(start > -1)
                {
                    end = WordEndIndex(fileContent.Content, start); 
                }

                if(start > -1 && end > -1 && end > start)
                {
                    tempList.Add(fileContent.Content.Substring(start, end - start));
                    i = end;
                }
                else
                {
                    i = fileContent.Content.Length;
                }
                     
            }
            textArray = tempList.ToArray();
            

        }
        private int WordStartIndex(string content, int index)
        {
            for(int j = index; j < content.Length; j++)
            {
                if(!Char.IsWhiteSpace(content[j]))
                {
                    return j;       
                }
                
            }
            
            return -1;
        }

        private int WordEndIndex(string content, int index)
        {
            for(int j = index; j < content.Length; j++)
            {
                if(Char.IsWhiteSpace(content[j]))
                {
                    return j;
                }
            }

            return -1;
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