
//Write a program which read a text file , perform some processing such as append , write and copy the changes to another file
using System;
using System.IO;
namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1......Reading the text file 
            /*
              string value=File.ReadAllText("C:\\Downloads\\file.txt");
              Console.WriteLine(value);
            */

            //Another methods of reading text file
            /*
            string input = "C:\\Downloads\\file.txt";
            string [] lines=File.ReadAllLines(input);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            */

            // 2...performing write 
            /*
            StreamWriter sw=new StreamWriter("C:\\Downloads\\Next.txt");
            Console.WriteLine("Enter the message to write in a file");
            string str=Console.ReadLine();
            sw.WriteLine(str);
            sw.Close();
            */

            //Another way to write in a file.
            /*
            using (StreamWriter writer = new StreamWriter("C:\\Downloads\\Next.txt")) {
                writer.WriteLine("hi");
                writer.Close();
            }
            */

            //3...copy file in another file

            /*
            string sourceFilePath = "C:\\Downloads\\file.txt";
            string destinationFilePath = "C:\\Downloads\\another.txt";

            try
            {
                File.Copy(sourceFilePath, destinationFilePath);
                Console.WriteLine("Sucessfully copied");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occured {ex.Message}");
                
            }
            */


            //4....append
            
        }
    }
}