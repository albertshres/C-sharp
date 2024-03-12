// 5 . Handle Exceptions in a program that reads numbers from user and  divide by another number (zero) . Also use finally keyword
using System;
namespace Mylab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine()); 
            
            try
            {
                int ans = n / 0;
                Console.WriteLine(ans);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("number can't be divided by zero");
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }
        }
    }
}
