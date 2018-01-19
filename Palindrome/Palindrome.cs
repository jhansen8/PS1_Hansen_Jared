using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{   
    /// <summary>
    /// This filter reads lines of text from the input and checks to see
    /// if the line contains a Palindrome. A Palindrome reads the
    /// same forwards as it does backwards. If the line contains
    /// a Palindrome, it will be printed out, ignoring other lines
    /// </summary>
    class Palindrome
    {
        static void Main(string[] args)
        {
            // Finds and prints lines containing palindromes
            string currentLine;
            while ((currentLine = Console.ReadLine()) != null)
            {
                // Store characters and reverse line
                char[] reversedLineArray = currentLine.ToCharArray();
                Array.Reverse(reversedLineArray);
                string reversedLine = new string(reversedLineArray);

                // Checks to see if the reversed line is the same as original
                if ( reversedLine.Equals(currentLine))
                {
                    Console.WriteLine(reversedLine);
                }
            }

        }
    }
}
