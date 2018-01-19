using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    /// <summary>
    /// This filter reads lines of text from the standard input and converts
    /// any UpperCase characters to LowerCase characters. Each word is 
    /// printed out to standard output one word per line.  Each word will
    /// be printed out regardless of if it has UpperCase characters or not.
    /// </summary>
    class LowerCase
    {
        static void Main(string[] args)
        {

            // Scans every line and changes upper case to lowercase
            // words are then printed on individual lines
            string currentLine;
            while((currentLine = Console.ReadLine()) != null)
            {
                var tokens = currentLine.ToLower().Split().Where(t => !t.Equals(""));

                foreach(var token in tokens)
                {
                    Console.WriteLine(token);
                }
            }
        }
    }
}
