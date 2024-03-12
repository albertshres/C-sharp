//Use a switch statement to perform different actions based on user input
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the rating between 1 and 5");
        string rating = Console.ReadLine();
        int rate = Convert.ToInt32(rating);

        switch (rate)
        {
            case 1:
                Console.WriteLine("your rating is 1 star.");
                break;
            case 2:
                Console.WriteLine("your rating is 2 star.");
                break;
            case 3:
                Console.WriteLine("your rating is 3 star.");
                break;

            case 4:
                Console.WriteLine("your rating is 4 star.");
                break;

            case 5:
                Console.WriteLine("your rating is 5 star.");
                break;
            default:
                Console.WriteLine("Invalid rating");
                break;
        }
    }
}
