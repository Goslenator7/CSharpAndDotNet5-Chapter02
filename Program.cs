using System;

namespace Chapter02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Text
            //Some strings require an escape \t for a number of reasons
            string fullNameWithTabSeperator = "Bob\tSmith";

            //But if a URL or path to a file contains a \t it is misinterpreted as an escape.
            // In this case, use the @ symbol to make a verbatim literal string
            string filePath = @"C:\televisions\sony\bravia.txt";

            Console.WriteLine(fullNameWithTabSeperator);
            Console.WriteLine(filePath);

            // Numbers
            // Handy to check what ranges of number each number type can hold
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            // Object
            // The object type can store any type of data, but it comes at the cost of less flexibility and poorer performance
            object height = 1.88;
            object name = "Jeff";
            Console.WriteLine($"{name} is {height} metres tall.");

            //int length1 = name.Length; will give a compile error for example, since the compiler doesn't know the data type of name.
            int length2 = ((string)name).Length; //this works because we are telling the compiler name is a string stored in object type
            Console.WriteLine($"{name} has {length2} characters.");
        }
    }
}
