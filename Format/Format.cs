using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS1
{
    class Format
    {
        static void Main(string[] args)
        {
            int argument = 1;

            if (args.Length > 0)
            {
                int.TryParse(args[0], out argument);
            }

            if ( argument < 1)
            {
                argument = 1;
            }

            var queue = new Queue<string>();

            string lineToFormat;
            while ((lineToFormat = Console.ReadLine()) != null)
            {
                var tokens = lineToFormat.Split().Where(t => !t.Equals("")).ToArray();

                foreach (var token in tokens)
                {
                    queue.Enqueue(token);
                }

                while (queue.Count >= argument)
                {
                    for (var i = 0; i < argument; i++)
                    {
                        Console.Write(queue.Dequeue());
                        if (i < argument - 1)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }

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
