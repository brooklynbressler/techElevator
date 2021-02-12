using System;
using System.Collections.Generic;
using System.IO;

namespace Assessment
{
    static class Program
    {


        static void Main(string[] args, int year, string make, bool isClassicCar)
        {

            Car car = new Car(year, make, isClassicCar);

            List<Car> listOfCars = new List<Car>();

            string directory = Environment.CurrentDirectory;
            string filename = "CarInput.csv";
            string fullPath = Path.Combine(directory, filename);

            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {

                        string line = sr.ReadLine();
                        string[] words = line.Split(',');

                        year = int.Parse(words[0]);
                        make = words[2];
                        isClassicCar = bool.Parse(words[3]);

                        if(year == 1965)
                        {

                            listOfCars.Add(car);

                        }
                        else if(year == 2019)
                        {

                            listOfCars.Add(car);
                        
                        }
                        else if(year == 1920)
                        {

                            listOfCars.Add(car);
                        
                        }
                        else if(year == 1970)
                        {
                            listOfCars.Add(car);
                        }
                        else if (year == 2018)
                        {
                            listOfCars.Add(car);
                        }
                        else
                        {
                            continue;
                        }

                    }


                }

            }

            catch (Exception)
            {
                Console.WriteLine("There was an error reading the input file");
            }


            Console.WriteLine($"The sum for the ages of all the cars is ): ");
        
        
        
        
        }
    }
}
