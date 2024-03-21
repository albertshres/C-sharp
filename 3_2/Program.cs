//2 WAP which shows error handling when working with File I/O operation
using System;
using System.IO;
namespace myapp
{
    class Program
    {
        static void Main(string[] args) {


            /* one way
             
            string inputFile = "C:\\Downloads\\input.txt";
            string outputFile = "C:\\Downloads\\output.txt";
            StreamReader reader = null;
            StreamWriter writer = null;

            try
            {   //opening input file for reading
                reader = new StreamReader(inputFile);

                //opening output file for writing
                writer = new StreamWriter(outputFile);

                string line;
                //Read lines from input file and append text to each line
                while((line = reader.ReadLine()) != null)
                {
                    line += "appended text";
                    writer.WriteLine(line);
                }
                Console.WriteLine("Text appended to each line . check output .txt");
            }
           
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Error: the file {inputFile} not found");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Error : Unauthorized access to the file{inputFile} or {outputFile}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occured {ex.Message}");
            }
            finally
            {
                //close the reader and writer ,if they were successfully opened

                if( reader != null)
                {
                    reader.Close();
                }
                if( writer != null ) { 
                writer.Close();
                }
            }
            */



            /*
            //another way , just show file not found
            string inputFile = "C:\\Downloads\\error.txt";
            StreamReader reader = null;
            string line;
            try
            {
                reader = new StreamReader(inputFile);
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"The file {inputFile} is not found");
            }
            */


            string inputFile = "C:\\Downloads\\input.txt";
            StreamReader reader = null;
            string line;
            try
            {
                reader = new StreamReader(inputFile);
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Error: unauthorized access to  {inputFile} ");
            }

        }
    }
}