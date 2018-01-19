using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class LowerCase
    {
        static void Main(string[] args)
        {

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
