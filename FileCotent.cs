using System;
using System.IO;

namespace csharp_text_analyser_magdaopiola
{
    public class FileContent
    {
        public Iterator CharIterator {get; set;}
        public Iterator WordIterator {get; set;}
        string content;
        string FileName {get;}
    
    
        public FileContent(string fileName)
        {
            FileName = fileName;
            try
            {   
                StreamReader f = File.OpenText(fileName);
                // StreamReader -> string
                content = f.ReadToEnd();
                f.Close();

            } catch(IOException exc)
            {
                Console.WriteLine(exc);
            }
        }      
    }
}