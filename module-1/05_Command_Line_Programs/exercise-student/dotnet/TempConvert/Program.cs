using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");

            string userInput = Console.ReadLine();

            int userInputAsAnInt = int.Parse(userInput);
            

            Console.Write("Is the temperature in (C)elsius, or (F)ahrenheit? ");

            string celsiusOrFahrenheit = Console.ReadLine();

            double convertedTemp;

            if (celsiusOrFahrenheit == "C")
            {
                convertedTemp = (int)(userInputAsAnInt * 1.8) + 32;
                Console.WriteLine($"{userInputAsAnInt}C is {(int)convertedTemp}F");
            }
            else if (celsiusOrFahrenheit == "F")
            {
               convertedTemp = (int)(userInputAsAnInt - 32) / 1.8;
               Console.WriteLine($"{userInputAsAnInt}F is {(int)convertedTemp}C");
            }

            

        }  
    }
}
