using System;
#nullable enable

namespace Chapter02
{
    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Text
            //Some strings require an escape \t for a number of reasons
            string fullNameWithTabSeperator = "Bob\tSmith\n";

            //But if a URL or path to a file contains a \t it is misinterpreted as an escape.
            // In this case, use the @ symbol to make a verbatim literal string
            string filePath = @"C:\televisions\sony\bravia.txt";

            // To add a line in the console after verbatim literal strings
            string newLine = "\n";
            Console.WriteLine(newLine);

            Console.WriteLine("Text");
            Console.WriteLine(fullNameWithTabSeperator);
            Console.WriteLine("Verbatim String");
            Console.WriteLine(filePath);
            Console.WriteLine(newLine);

            // Numbers
            // Handy to check what ranges of number each number type can hold
            Console.WriteLine($"Numbers \nint uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.\n");

            // Object
            // The object type can store any type of data, but it comes at the cost of less flexibility and poorer performance
            object height = 1.88;
            object name = "Jeff";
            Console.WriteLine($"Objects \n{name} is {height} metres tall.");

            //int length1 = name.Length; will give a compile error for example, since the compiler doesn't know the data type of name.
            int length2 = ((string)name).Length; //this works because we are telling the compiler name is a string stored in object type
            Console.WriteLine($"{name} has {length2} characters.\n");

            // Dynamic Types
            // The dynamic type allows for storing any datatype, more than object type. This comes at cost to performance
            // You can invoke the type's members without explicitly casting the type (see line 33)
            // Intellisense also cannot suggest methods or members for this type as it is not explicitly stated to be a string type
            dynamic anotherName = "Geoff";
            int anotherNameLength = anotherName.Length;
            Console.WriteLine($"Dynamics \n{anotherName} has {anotherNameLength} characters.\n");


            // Null Values
            // Null is used when a variable that has not been set yet and different from 0 as that is a value of 0
            int? thisCouldBeNull = null;
            Console.WriteLine("Null Values\n");
            Console.WriteLine($"The value of thisCouldBeNull when set to null is: {thisCouldBeNull}");
            thisCouldBeNull = 7;
            Console.WriteLine($"The value of thisCouldBeNull when set to 7 is: {thisCouldBeNull}\n");

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;

            string authorName = null;

            //following throws a NullReferenceException
            //int authorNameLength = authorName.Length;
            //instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;
            Console.WriteLine($"Author name length is: {y}");

            //the null coalescing operator (??)
            //Result will be 3 if authorName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine("The coalesce operator has changed the author name length from null to: "+result);
        }
    }
}
