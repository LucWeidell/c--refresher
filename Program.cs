// REVIEW using: import
using System;

// NOTE allow access to all other pieces of code within the namespace, a way of grouping our code (like a filesystem)
namespace csharp_day_1
{
    // REVIEW Class : Class
    class Program
    {
        //  REVIEW Method : Method
        // access modifier, return type, name, parameter
        static void Main(string[] args)
        {
            // REVIEW Console.WriteLine (cs + tab) === console.log
            Console.WriteLine("Hello World!");

            // SECTION variables
            // let, const, var,  NOW
            // implicit typing var (The variable type is implied by the set value)
            var x = "Hello";
            var z = 'a';
            var z2 = "a";
            // explicit typing uses the type as the variable declaration (does not require value assignment on initialization)
            string y = "World";
            char y2 = 'w';

            // SECTION Strings
            // REVIEW Concatenation : Concatenation
            string myString = x + " " + y;
            // NOTE interpolation : interpolation (start string with # to use variables in {})
            string myString2 = $"{x} {y}";
            string myString2_5 = $"{0} {1}";
            System.Console.WriteLine(myString2_5, x, y);





                    }
    }
}
