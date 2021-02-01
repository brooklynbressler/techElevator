using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetElevator.Shared;

namespace PetElevator.Tests
    
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinationsTest()
        {
            Pet pet = new Pet("Jake","Golden Retriever");

            string actual = pet.ListVaccinations();

            string actual2 = "Rabies, Distemper, Parvo";

            Assert.AreEqual(actual2, actual);
        }
    }
}
