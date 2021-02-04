using SearchApplication.Search;
using SearchApplication.Util;
using System;
using System.Collections.Generic;

namespace SearchApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Step Two: Create TELog, and log the start of the application.
                //

                TELog.Log("Search application started");

                // Step Four: Instantiate a Search Domain
                //

                SearchDomain domain = new SearchDomain("data");
                TELog.Log(domain.ToString());

                // Step Six: Single word search
                //

                SearchEngine searchEngine = new SearchEngine(domain);
                searchEngine.IndexFiles();

                SearchAndPrintResults(searchEngine, "squirrel");
                SearchAndPrintResults(searchEngine, "Larry");
                // Step Seven: Multiple word search
                //

                SearchAndPrintResults(searchEngine, "telephone line");

            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception occurred:\n" + ex.StackTrace);
            }
        
        }
    
        private static void SearchAndPrintResults(SearchEngine searchEngine, string searchWord)
        {

            IList<string> matchingFileNames = searchEngine.Search(searchWord);
            
            Console.WriteLine($"Searching for: {searchWord}");

            if (matchingFileNames.Count == 0)
            {
                Console.WriteLine("No matching files are found.");
            }
            else
            {


                foreach (string fileName in matchingFileNames)
                {
                    Console.WriteLine(fileName);
                }

            }

        }

    }
}
