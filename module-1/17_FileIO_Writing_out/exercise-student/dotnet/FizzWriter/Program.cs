using System;
using System.IO;

namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the destination file?");
            string destinationFile = Console.ReadLine();

            //C:\Users\Student\workspace\bbressler-c\module-1\17_FileIO_Writing_out\exercise-student\dotnet\FizzWriter\FizzDestination.txt

            try
            {
                // Open a StreamWriter where we will output the file
                using (StreamWriter sw = new StreamWriter(destinationFile))
                {

                    for (int i = 1; i <= 300; i++)
                    {

                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            sw.WriteLine("FizzBuzz");
                        }
                        else if (i % 5 == 0 || i.ToString().Contains("5"))
                        {
                            sw.WriteLine("Buzz");
                        }
                        else if (i % 3 == 0 || i.ToString().Contains("3"))
                        {
                            sw.WriteLine("Fizz");
                        }
                        else
                        {
                            sw.WriteLine(i);
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
