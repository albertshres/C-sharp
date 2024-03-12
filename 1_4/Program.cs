// 1.Implement a simple if-else statement check if given number is even or odd

using System;
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        string num = Console.ReadLine();
        int n = Convert.ToInt32(num);

        if (n % 2 == 0)
        {
            Console.WriteLine($"the given number {n} is even ");
        }
        else
        {
            Console.WriteLine($"the given number {n} is odd");
        }
    }
}


