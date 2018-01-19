using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{   
    class Palindrome
    {
        static void Main(string[] args)
        {
            string currentLine;
            while ((currentLine = Console.ReadLine()) != null)
            {
                char[] reversedLineArray = currentLine.ToCharArray();
                Array.Reverse(reversedLineArray);
                string reversedLine = new string(reversedLineArray);

                if ( reversedLine.Equals(currentLine))
                {
                    Console.WriteLine(reversedLine);
                }
            }

        }
    }
}
