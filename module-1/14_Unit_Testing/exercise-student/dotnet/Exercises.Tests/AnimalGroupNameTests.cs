using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTests
    {
        AnimalGroupName animalGroup = new AnimalGroupName();

        [TestMethod]
        public void TestAnimalGroupName()
        {
            string actual = animalGroup.GetHerd("giraffe");
            string actual2 = animalGroup.GetHerd("");
            string actual3 = animalGroup.GetHerd("walrus");
            string actual4 = animalGroup.GetHerd("Rhino");
            string actual5 = animalGroup.GetHerd("rhino");
            string actual6 = animalGroup.GetHerd("elephants");
            //* GetHerd("giraffe") ? "Tower"
            //* GetHerd("") -> "unknown"
            //* GetHerd("walrus") -> "unknown"
            //* GetHerd("Rhino") -> "Crash"
            //* GetHerd("rhino") -> "Crash"
            //* GetHerd("elephants") -> "unknown"
            Assert.AreEqual("Tower", actual);
            Assert.AreEqual("unknown", actual2);
            Assert.AreEqual("unknown", actual3);
            Assert.AreEqual("Crash", actual4);
            Assert.AreEqual("Crash", actual5);
            Assert.AreEqual("unknown", actual6);
            Assert.AreEqual("unknown", actual2);

        }
    }
}
