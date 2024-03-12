
// Declear an array of interger and string . initialize it with values and display elements
using System;
class Program
{
    static void Main(string[] args)
    {
        //integer array
        int[] num_array;
        num_array = new int[] { 1, 2, 3, 4 };

        foreach(int c in num_array)
        {
            Console.WriteLine(c);
        }
        //alternative
        int[] nums = { 1, 2, 3, 4 };
        foreach(int a in nums)
        {
            Console.WriteLine(a);
        }

        string[] string_arr = new string[2] {"Ram","Shyam"};
        foreach(string b in string_arr)
        {
            Console.WriteLine(b);
        }

        // using for loop
        int i;
        for (i = 0; i <= string_arr.Length; i++)
        {
            Console.WriteLine(string_arr[i]);
        }

    }
}
