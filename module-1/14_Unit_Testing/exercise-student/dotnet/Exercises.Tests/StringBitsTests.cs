using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTests
    {
        StringBits stringBits = new StringBits();

        [TestMethod]
        public void TestStringBits()
        {

            string actual = stringBits.GetBits("Hello");
            string actual2 = stringBits.GetBits("Hi");
            string actual3 = stringBits.GetBits("Heeololeo");

            //GetBits("Hello") → "Hlo"
            //GetBits("Hi") → "H"
            //GetBits("Heeololeo") → "Hello"

            Assert.AreEqual("Hlo", actual);
            Assert.AreEqual("H", actual2);
            Assert.AreEqual("Hello", actual3);


        }
    }
}
