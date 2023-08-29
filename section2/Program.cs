using System;

namespace Basics
{
    class Program
    {
        /// <summary>
        /// Basics of the C# language
        /// </summary>
        /// 

        static void Main(string[] args)
        {
            /// C# Statements
            // Single instruction of code
            Console.WriteLine("Hello");

            // C# Blocks
            // Group of statements
            // starts with { and end with }

            if(true)
            {
                int a = 100;
                int b = a;
            }

            // C# Comments
            // 3 types of comments
            // Single line comments
            // multiline comments /* and */
            
            /// documentation comments ///
            /// 

            // C# Read and Write
            string str = Console.ReadLine();
            Console.WriteLine("Hello World");
            Console.Write("hello");
            Console.WriteLine(str);

        }
    }
}