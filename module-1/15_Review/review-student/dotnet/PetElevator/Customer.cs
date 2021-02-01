using PetElevator.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator
{
    public class Customer : Person, IBillable
    {
        public string PhoneNumber { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Customer(string firstName, string lastName, string phoneNumber)
            : base (firstName, lastName)
        {
            PhoneNumber = phoneNumber;
        }

        public Dictionary<string, double> GetBalanceDue(object servicesRendered)
        {
            throw new NotImplementedException();
        }

        public Customer(string firstName, string lastName) : this("Brooklyn", "Bressler", "")
        {

        }

        public double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {

            double costOfGrooming = servicesRendered["Grooming"];
            double costOfWalking = servicesRendered["Walking"];
            double costOfSitting = servicesRendered["Sitting"];

            double totalCostOfServices = costOfGrooming + costOfWalking + costOfSitting;

            return totalCostOfServices;
        }






    }
}
