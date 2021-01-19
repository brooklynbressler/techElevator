using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter in a series of decimal values (separated by spaces): ");
            string userInput = Console.ReadLine();
            
            //userInput.split(' ') is what you do to get a string array of words seperated by spaces
            string[] decimals = userInput.Split(' ');
            //loop through the array a forEach/a forloop both could work foreach is just easier
            foreach (var decimalNumber in decimals)
            {
                //parse the string as an integer 
                int values = int.Parse(decimalNumber);
                //convert to binary 
                string binary = Convert.ToString(values, 2);
                //write a new line for each conversion
                Console.WriteLine(decimalNumber + " in binary is " + binary);
            }

           

            

        }
    }
}
