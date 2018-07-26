using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "Hello World";
            Console.WriteLine(output);

            // or it can be done on a single line
            Console.WriteLine("Hello World");

            // We use this console.readline() to stop the application automatically closing.
            Console.ReadLine();
        }
    }
}
