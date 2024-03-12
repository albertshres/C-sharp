//Declear variables of different datatypes and use type casting

using System;
namespace myapp
{
    class Program
    {
        static void Main(string [] args)
        {
            int x = 5;
            double y = 2.4;
            //implict type casting i.e from smaller to larger size
            double X = x;
            Console.WriteLine(X);

            //explict type casting i.e from larger size to smaller
            int Y= (int)y;
            Console.WriteLine(Y);   


        }
    }
}
