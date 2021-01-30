using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        NonStart nonStart = new NonStart();

        [TestMethod]
        public void TestNonStart()
        {

            string actual = nonStart.GetPartialString("Hello", "There");
            string actual2 = nonStart.GetPartialString("java", "code");
            string actual3 = nonStart.GetPartialString("shotl", "java");

            //GetPartialString("Hello", "There") → "ellohere"
            //GetPartialString("java", "code") → "avaode"
            //GetPartialString("shotl", "java") → "hotlava"

            Assert.AreEqual("ellohere", actual);
            Assert.AreEqual("avaode", actual2);
            Assert.AreEqual("hotlava", actual3);


        }
    }
}
