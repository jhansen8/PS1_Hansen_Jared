using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    /// <summary>
    /// This filter is used to format text from the standard input.
    /// A positive interger, n, is expected in the first element of the
    /// args array as a parameter.  If no valid integer is provided or 
    /// their is no parameter, default format will be 1. The tokens
    /// will be printed out, n tokens per line. If the input ends
    /// when there are between 1 and n-1 (inclusive) words, the final
    /// line will contain the remaining tokens. All lines must contain
    /// n tokens except for the final line.
    /// </summary>
    /// <param name="args">Number of Tokens</param>
    class Format
    {
        static void Main(string[] args)
        {
            // Get and parse argument from the args array if exist
            // Default is 1 unless valid parameter is passed in
            int argument = 1;
            if (args.Length > 0)
            {
                int.TryParse(args[0], out argument);
            }

            if ( argument < 1)
            {
                argument = 1;
            }

            // Queue to keep tokens in order
            var queue = new Queue<string>();

            // Reads each line and enqueues tokens, prints in formatted output
            string lineToFormat;
            while ((lineToFormat = Console.ReadLine()) != null)
            {
                // separate the line into individual tokens
                var tokens = lineToFormat.Split().Where(t => !t.Equals("")).ToArray();

                // Enqueue each token in array
                foreach (var token in tokens)
                {
                    queue.Enqueue(token);
                }

                // Dequeue and print with spacing
                while (queue.Count >= argument)
                {
                    for (var idx = 0; idx < argument; idx++)
                    {
                        Console.Write(queue.Dequeue());
                        if (idx < argument - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

            // Write final line of output, no matter the number of tokens
            while (queue.Count() > 0)
            {
                Console.Write(queue.Dequeue());
                if (queue.Count > 0)
                {
                    Console.Write(" ");
                }
            }
        }
    }
}
