//6. Write a function that reverse a string without using builtin Reverse function

using System;
namespace mylab2 {
class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            int len= str.Length;
            for(int i = len - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}


