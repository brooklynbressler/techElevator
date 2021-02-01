using System.Collections.Generic;

namespace PetElevator.Shared
{
    interface IBillable
    {
        
        double GetBalanceDue(Dictionary<string, double> servicesRendered)
        {
            servicesRendered.Add("Grooming", 10.00);
            servicesRendered.Add("Walking", 5.00);
            servicesRendered.Add("Sitting", 20.00);

            double costOfGrooming = servicesRendered["Grooming"];
            double costOfWalking = servicesRendered["Walking"];
            double costOfSitting = servicesRendered["Sitting"];

            double totalCostOfServices = costOfGrooming + costOfWalking + costOfSitting;

            return totalCostOfServices;
        }
    }
}
