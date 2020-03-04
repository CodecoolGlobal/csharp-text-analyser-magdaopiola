using System;

namespace csharp_text_analyser_magdaopiola
{
    public abstract class Iterator
    {   
        protected string[] textArray;
        int pos;
        protected FileContent fileContent;

        public Iterator(FileContent fileContent)
        {
            this.fileContent = fileContent;
            pos = 0;
        }
        public abstract bool HasNext();
        public abstract string MoveNext();
        void Remove()
        {
        
        }

        
    }
}