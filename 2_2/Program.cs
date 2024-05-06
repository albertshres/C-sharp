//write a function that calculates the factorial of given numbers

using System;
class Program
{
    static int facto (int n)
    {
        if(n == 0 || n==1) {
            return 1;
        }
        else
        {
            return n * facto(n - 1);
        }
    }

    static void Main(string[] args)
    {
        int ans= facto(6);
        Console.WriteLine($" The factorial of a number is {ans}");
    }
}
