using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator
{
    public class Pet
    {

        public string PetName { get; set; }
        public string Species { get; set; }
        public List<string> Vaccinations { get; set; } = new List<string>() { "Rabies", "Distemper", "Parvo" };

        public Pet(string petName, string species)
        {
            PetName = petName;
            Species = species;
        }

        public string ListVaccinations()
        {

            string vaccinationString = string.Empty;


            foreach (var item in Vaccinations)
            {
                vaccinationString = vaccinationString + item + ", ";
            }


            vaccinationString = vaccinationString.Remove(vaccinationString.Length - 1);

            var newString = String.Join(", ", Vaccinations);

            return newString;
        }








    }
}
