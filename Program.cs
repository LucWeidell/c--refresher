// REVIEW using: import
using System;
using System.Collections.Generic;
using System.Threading;
using csharp_day_1.Models;

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
            // #region SECTION Strings
            // REVIEW Concatenation : Concatenation
            string myString = x + " " + y;
            // NOTE interpolation : interpolation (start string with # to use variables in {})
            string myString2 = $"{x} {y}";
            // alternative way to use interpolation
            string myString2_5 = $"{0} {1}";
            System.Console.WriteLine(myString2_5, x, y);
            //  the @ symbol allows for line breaks
            string myString4 = @"
            Hello World
            ";
            System.Console.WriteLine(myString4);
            // #endRegion
            // SECTION Console
            Console.Clear();
            // Note ReadLine gets input from the console
            Console.WriteLine("Hello! What is your name?");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.WriteLine("Hello " + name);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            System.Console.WriteLine("Its a me");
            System.Console.WriteLine(@"

            ");
            Thread.Sleep(3000);
            System.Console.Beep();
            Console.ResetColor();
            Console.Clear();

            //  SECTION Numbers
            // Number : int, long float, Decimal, Double
            // INT (whole numbers), float (decimals)
            // var num = 1.3;
            // double is denoted with a 'd'
            double num = 1.34d;
            // float is denoted with 'f'
            float floatNum = 2.3f;
            // decimals is denoted with 'm'
            decimal bugNum = 32.434m;

            // SECTION Conditionals
            // (if, else if, else, switched) : (if, else if, else, switches)
            // === : == (there is no ===)
            // No 'Truthy'/'Falsey', No 'Undefined', No 'NaN'
            // Number Types are not 'nullable' meaning they will always have a value of atleast 0
            if(num != null) {
                // do thing
            }

            // SECTION Arrays
            // Arrays : Arrays (Arrays are not as flexible in C# as in JS)
            String[] cats = new String[3];
            cats[0] = "Garfield";
            cats[1] = "Mr. Snibbley";
            cats[0] = null;

            // C# Alternative: List
            // List<Type> (use System.Collections.Generic)
            // Must be instantiated
            // can use {} to add values at initialization
            List<String> catsList = new List<string>(){"Garfield", "Nermal"};
            // push: Add
            catsList.Add("Felix");
            // add at a position
            catsList.Insert(0, "Heathcliff");
            // remove
            catsList.RemoveAt(0);
            // find : find
            // catsList.Find("Garfield");

            // SECTION Disctionary
            //  {} : Dictionary (Do not us POCO)
            //  Dictionary<KeyType, ValueType>
            Dictionary<String, int> studentIds = new Dictionary<String, int>();
            studentIds.Add("jimmy", 23);
            System.Console.WriteLine("Jimmys Id is " + studentIds["jimmy"]);
            // DANGER Zone!
            if(studentIds.ContainsKey("tommy"))
            {
            System.Console.WriteLine("Tommy's Id is " + studentIds["tommy"]);

            }
            System.Console.WriteLine("Jimmys's Id is " + studentIds["jimmy"]);

            // BONUS: Convert string to number from user input
            Console.WriteLine("Give me a number");
            string input = Console.ReadLine();
            // unsafe
            // int inputNum = Int16.Parse(input);
            // if(inputNum > 3)
            // {
            //     System.Console.WriteLine("Thats a big number!");
            // }
            // BEtter
            if(Int32.TryParse(input, out int inputNum2))
            {
                if(inputNum2 > 3)
                {
                    System.Console.WriteLine("Thats a bigger than 3!");

                }

            }
            else
            {
                System.Console.WriteLine("not a number");
            }

            // SECTION Loops
            // array.length : list.Count
            for (int i = 0; i < catsList.Count; i++)
            {
                System.Console.WriteLine(catsList[i]);
            }


            // Section Using classes
            Cat myCat = new Cat("Mr. Snibbley", 100);
            myCat.Name = "Capt. Jack";
            System.Console.WriteLine(myCat.Feed("Fish"));
            myCat.Birthday();
            // myCat.Age = 10; Cant cause private in class setter









        }
    }
}
