using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        Less20 less20 = new Less20();

        [TestMethod]
        public void TestLess20()
        {

            bool actual = less20.IsLessThanMultipleOf20(18);
            bool actual2 = less20.IsLessThanMultipleOf20(19);
            bool actual3 = less20.IsLessThanMultipleOf20(20);
            //less20(18) → true
            //less20(19) → true
            //less20(20) → false
            Assert.AreEqual(true, actual);
            Assert.AreEqual(true, actual2);
            Assert.AreEqual(false, actual3);


        }
    }
}
