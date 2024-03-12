// Create a list to store names and display in loop
using System;
class Program
{
    static void Main(string[] args)
    {
        List<string> names= new List<string> { "Ram", "shyam", "Hari" };

        Console.WriteLine(names);
        foreach(string i in names)
        {
            Console.WriteLine(i);
        }
    }
}
