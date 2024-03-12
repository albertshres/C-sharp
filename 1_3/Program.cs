// Write a C# program that takes user input ( e.g. name) and two numbers and display name and their sum with different print methodology

using System;
namespace myapp
{
    class Program
    {
        static void Main(string [] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter any first number");
            int n1= Convert.ToInt32(Console.ReadLine());//readline return only stiring so we have to do type caste
            Console.WriteLine("Enter any second number");
            int n2= Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            Console.WriteLine("The name is " + name + "the sum of number is " + sum);
            Console.WriteLine($"The name is {name} and sum of number is {sum}");
            
            

        }
    }
}