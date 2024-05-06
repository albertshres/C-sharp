//6. Use a loop to print numbers from 1 to 10 using for loop ,while loop, and do while loop


using System;
class Program
{
    static void Main(string[] args) {
        int num = 1;
        for (num = 1; num <= 10; num++)
        {
            Console.Write(num);
            Console.WriteLine();


        }
        Console.WriteLine();
        int n = 1;
        while (n <= 10)
        {
            Console.Write(n);
            Console.WriteLine();

            n++;

        }
        Console.WriteLine();
        int x = 1;
        do
        {
            Console.Write(x);
            Console.WriteLine();

            x++;
        }
        while (x <= 10);
    }
}


