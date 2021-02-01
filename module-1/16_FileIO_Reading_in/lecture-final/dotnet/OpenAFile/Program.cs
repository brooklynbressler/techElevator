using System;
using System.IO;

namespace OpenAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fully Qualified Path To a File");

            string pathToFile = Console.ReadLine();
            //once you have file open and reading working ok
            pathToFile = @"C:\test\test.txt";
            bool fileExist = File.Exists(pathToFile);
            

            if (fileExist)
            {
                try
                {

                    using (StreamReader sr = new StreamReader(pathToFile))
                    {
                        ProcessLine(sr.ReadLine());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("not good");
                    //throw;
                }
            }
        }

        static void ProcessLine(string lineToProcess)
        {
            Console.WriteLine(lineToProcess);
        }
    }
}
