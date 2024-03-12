
//Implement a recursice function to calculate fibonacci series
using System;
class Program
{
    static int fibo( int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        return fibo(n - 1) + fibo(n - 2);
    }

    static void Main(string[] args)
    {
        int count = 5;
        int i ;
        for (i = 0; i < count; i++)
        {
            Console.Write(fibo(i) + " ");
        }
    }
}