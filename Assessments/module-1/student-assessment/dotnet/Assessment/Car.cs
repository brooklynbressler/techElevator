using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class Car
    {
        //    * `year`: indicates the year that the car was manufactured.
        //    * `make`: indicates the make of the car.
        //    * `is classic car`: indicates if the car is a classic car.
        //    * `age`: indicates the age (in years) of the car from the current year.

        public int Year { get; set; }
        public int Age { get; set; }
        public string Make { get; set; }
        public bool IsClassicCar { get; set; }
        
        public Car(int year, string make, bool isClassicCar)
        {

            Year = year;
            Make = make;
            IsClassicCar = isClassicCar;

        }
    
        public bool ECheck(int yearToCheck)
        {
            bool isECheckNeeded = false;

            if(yearToCheck % 2 == 0 || yearToCheck % 2 != 0)
            {
                isECheckNeeded = true;
            }
            else if(yearToCheck < 4 || yearToCheck > 25 || IsClassicCar == true)
            {
                isECheckNeeded = false;
            }

            return isECheckNeeded;
        }

        public string ToString(int year, string make)
        {
            string descriptionOfCar = $"CAR - {year} - {make}";

            return descriptionOfCar;
        }
    
    
    }   
}
