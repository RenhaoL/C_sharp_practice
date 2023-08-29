using System;

namespace Text
{

    class Program
    {
        static void Main(string[] args)
        {
            // C# Characters
            char c = 'a';
            char d = '1';
            char s = '*';

            int i = sizeof(char); // sizeof return the bits of char, which is 2 in this case
        
            // C# Strings
            string s1 = "hello";
            string s2 = "1234";
            string s3 = "***";


            Console.WriteLine("hello, world");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            // Different ways to represent strings
            string str1 = "world";
            // Verbatim using the @
            string str2 = @"c:\myfolder\test.txt";
            // interpolated
            string str3 = $"hello {str1}"; // will print hello world

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
    }

}