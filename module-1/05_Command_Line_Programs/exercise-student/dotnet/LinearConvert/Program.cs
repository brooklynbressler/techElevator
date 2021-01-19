using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length: ");

            string userInput = Console.ReadLine();

            double userInputAsADouble = double.Parse(userInput);


            Console.Write("Is the measurement in (m)eter, or (f)eet? ");

            string metersOrFeet = Console.ReadLine();

            int convertedMeasurement;

            if (metersOrFeet == "m")
            {
                convertedMeasurement = (int)(userInputAsADouble * 3.2808399);
                Console.WriteLine($"{userInputAsADouble}m is {convertedMeasurement}f");
            }
            else if (metersOrFeet == "f")
            {
                convertedMeasurement = (int)(userInputAsADouble * 0.3048);
                Console.WriteLine($"{userInputAsADouble}f is {convertedMeasurement}m");
            }
        }
    }
}
