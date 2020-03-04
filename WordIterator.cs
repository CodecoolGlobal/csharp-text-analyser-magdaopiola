using System;

namespace csharp_text_analyser_magdaopiola
{
    class WordIterator : Iterator
    {
        public WordIterator(FileContent fileContent) : base(fileContent)
        {
            this.fileContent = fileContent;
        }

        public override bool HasNext()
        {
            return false;
        }
        public override string MoveNext()
        {
            return "";
        }
        
    }
}