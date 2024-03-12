//Strings and Exception Handling
//4.Concatenate two strings and display the result .Also find length of resulting string.
using System;
namespace mylab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Ram";
            string str2 = "Shah";
            string str = string.Concat(str1, str2);
            int len=str.Length;
            Console.WriteLine(str);
            Console.WriteLine($"The of the concatinated string is {len}");
        }
    }
}