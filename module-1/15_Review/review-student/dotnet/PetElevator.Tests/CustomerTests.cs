using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;
using System.Collections.Generic;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {
            Customer customer = new Customer("Brooklyn", "Bressler", "");

            double totalCostOfServices = 35.00;

            Dictionary<string, double> servicesRendered = new Dictionary<string, double>();

            servicesRendered.Add("Grooming", 10.00);
            servicesRendered.Add("Walking", 5.00);
            servicesRendered.Add("Sitting", 20.00);


            double actual = customer.GetBalanceDue(servicesRendered);

            Assert.AreEqual(totalCostOfServices, actual);
        }
    }
}
