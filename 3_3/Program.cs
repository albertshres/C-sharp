//3 Write a program defining your custom exception
using System;
namespace myapp
{
    class MyException : ApplicationException { 
    
    public MyException() {
            Console.WriteLine("An Exception");
        }
    public void DivideZeroException()
        {
            Console.WriteLine("Divide By Zero Exception");
        }
    
    }

    class Program
    {
        static void Main(string[] args) {
            int num, div, res;
            Console.WriteLine("Enter a number :");
            num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a divisor");
            div = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (div == 0)
                {
                    throw new MyException();
                }
            }
            catch(MyException e) { 
            e.DivideZeroException();
                    }

        }
    }
}