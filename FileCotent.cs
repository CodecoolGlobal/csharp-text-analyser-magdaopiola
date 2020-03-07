using System;
using System.IO;

namespace csharp_text_analyser_magdaopiola
{
    public class FileContent : IterableText
    {
        private Iterator charIterator;
        private Iterator wordIterator;
        public string Content {get;}
        string FileName {get;}
    
    
        public FileContent(string fileName)
        {
            FileName = fileName;
            try
            {   
                StreamReader f = File.OpenText(fileName);
                // StreamReader -> string
                Content = f.ReadToEnd();
                f.Close();

            } catch(IOException exc)
            {
                Console.WriteLine(exc);
            }
        }

        public Iterator CharIterator()
        {
            charIterator = new CharIterator(this);
            return charIterator;
        }

        public Iterator WordIterator()
        {
            wordIterator = new WordIterator(this);
            return wordIterator;
        }


    }
}