using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        FrontTimes frontTimes = new FrontTimes();

        [TestMethod]
        public void TestFrontTimes()
        {

            string actual = frontTimes.GenerateString("Chocolate", 2);
            string actual2 = frontTimes.GenerateString("Chocolate", 3);
            string actual3 = frontTimes.GenerateString("Abc", 3);
            //frontTimes("Chocolate", 2) → "ChoCho"
            //frontTimes("Chocolate", 3) → "ChoChoCho"
            //frontTimes("Abc", 3) → "AbcAbcAbc"
            Assert.AreEqual("ChoCho", actual);
            Assert.AreEqual("ChoChoCho", actual2);
            Assert.AreEqual("AbcAbcAbc", actual3);


        }
    }
}
