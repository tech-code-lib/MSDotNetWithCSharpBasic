using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            //Length

            int stringLength = name.Length;
            Console.WriteLine("String Length:");
            Console.WriteLine(stringLength);

            //Converting string to UpperCase or Lower Case

            //ToUpper(), ToLower()

            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());

            //Concatenation

            string firstName = "John";
            string lastName = "Smith";

            Console.WriteLine(firstName + " " + lastName);

            //String Interpolation
            // $"{}-{} {}"

            Console.WriteLine($"{firstName} {lastName}");

            //IndexOf: position of a char or string, position/index starts with Zero
            string sentence = "I live in New York City.";
            Console.WriteLine($"Position of Period {sentence.IndexOf('.')}");//23
            Console.WriteLine($"Position of 'New' {sentence.IndexOf("New")}");//10

            //Substring
            //Substring(startIndex), Substring(startIndex, length)
            Console.WriteLine(sentence.Substring(10));
            Console.WriteLine(sentence.Substring(10, 8));

            //Escape Character Backslash \

            string sample = "My Name is John Smith. \\I live in New York City.";
            Console.WriteLine(sample);

            // New Line \n
            Console.ForegroundColor = ConsoleColor.Green;
            string sampleNewLine = "My Name is John Smith.\nI live in New York City.";
            Console.WriteLine(sampleNewLine);
            Console.ForegroundColor = ConsoleColor.White;


            //Replace
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine(sample.Replace("New York", "Atlanta"));
            Console.WriteLine(sample.Replace('.', ';'));
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
