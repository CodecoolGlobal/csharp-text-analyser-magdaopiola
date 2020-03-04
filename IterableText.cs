using System;

namespace csharp_text_analyser_magdaopiola
{
    interface IterableText
    {
            Iterator CharIterator();
        
            Iterator WordIterator();
    }
}