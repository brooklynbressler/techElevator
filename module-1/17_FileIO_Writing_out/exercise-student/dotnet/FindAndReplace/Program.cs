using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the search word?");
            string userSearchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string userReplacementWord = Console.ReadLine();

            Console.WriteLine("What is the source file?");
            string userSourceFile = Console.ReadLine();

            Console.WriteLine("What is the destination file?");
            string userDestinationFile = Console.ReadLine();

            //C:\Users\Student\workspace\bbressler-c\module-1\17_FileIO_Writing_out\exercise-student\dotnet\FindAndReplace\werdz.txt
            //C:\Users\Student\workspace\bbressler-c\module-1\17_FileIO_Writing_out\exercise-student\dotnet\FindAndReplace\werdz-replace.txt

            try
            {
                // Open the existing file with the typo using a StreamReader
                using (StreamReader sr = new StreamReader(userSourceFile))
                {
                    // Open a StreamWriter where we will output the file
                    using (StreamWriter sw = new StreamWriter(userDestinationFile, false))
                    {
                        // For each line in the input file, read it in
                        while (!sr.EndOfStream)
                        {
                            // Read an individual line
                            string line = sr.ReadLine();

                            // Replace the occurence of the word langauge with language
                            string fixedLine = line.Replace(userSearchWord, userReplacementWord);


                            // Write the new line to the output file
                            sw.WriteLine(fixedLine);
                        }
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("couldnt do it, sorry");

            }
        }
    }
}
