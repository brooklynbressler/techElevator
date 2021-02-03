using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("What is the fully qualified name of the file that should be searched?");
            string userFilePath = Console.ReadLine(); 
            
            Console.WriteLine("What is the search word you are looking for?");
            string userWordSearch = Console.ReadLine();

            Console.WriteLine(@"Should the search be case sensitive? (Y\N)");
            string caseSensitivity = Console.ReadLine();

            int lineNumber = 1;
            
            try
            {
                
                using (StreamReader dataInput = new StreamReader(userFilePath))
                {
           
                    while (!dataInput.EndOfStream)
                    {
                        
                        string lineBeingRead = dataInput.ReadLine();

                        if(caseSensitivity.ToUpper() == "Y" && lineBeingRead.Contains(userWordSearch))
                        {
                            Console.WriteLine($"{lineNumber}) {lineBeingRead}");
                        }
                        else if(caseSensitivity.ToUpper() == "N" && lineBeingRead.Contains(userWordSearch, StringComparison.CurrentCultureIgnoreCase))
                        {
                            Console.WriteLine($"{lineNumber}) {lineBeingRead}");
                        }

                        lineNumber++;

                    }
                }
            }
            catch (IOException e) 
            {
                Console.WriteLine("Error finding word");
                Console.WriteLine(e.Message);
            }

            //C:\Users\Student\workspace\bbressler-c\module-1\16_FileIO_Reading_in\exercise-student\dotnet\alices_adventures_in_wonderland.txt
        }

    }
}
