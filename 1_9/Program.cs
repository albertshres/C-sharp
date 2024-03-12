//use a foreach loop to iterate through an array and perform an operation on each element

using System;
class Program
{
    static void Main(string[] args)
    {
        int[] num = { 1, 2, 3, 4 };
        Console.WriteLine("original array is");
        foreach(int i in num) {
            Console.WriteLine(i);
        }
        Console.WriteLine("array after doubling each array elements");
        foreach(int n in num) {
            int doubled_num = n * 2;
            Console.WriteLine(doubled_num);
        }
    }
}