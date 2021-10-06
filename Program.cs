using System;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            //text
            //Some strings require an escape \t for a number of reasons
            string fullNameWithTabSeperator = "Bob\tSmith";

            //But if a URL or path to a file contains a \t it is misinterpreted as an escape.
            // In this case, use the @ symbol to make a verbatim literal string
            string filePath = @"C:\televisions\sony\bravia.txt";

            Console.WriteLine(fullNameWithTabSeperator);
            Console.WriteLine(filePath);

            //numbers
            
        }
    }
}
