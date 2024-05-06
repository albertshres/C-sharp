//Create a function that takes two parameters and return their sum.
using System;
class Program
{
    static int sum(int a, int b)
    {
        return a + b;
    }
    static void Main (String[] args)
    {
        int result = sum(8, 3);
        Console.WriteLine($"The sum of two number is {result}");
    }

    
}
