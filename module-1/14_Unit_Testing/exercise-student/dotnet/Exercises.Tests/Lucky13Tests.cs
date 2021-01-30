using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        Lucky13 lucky13 = new Lucky13();

        [TestMethod]
        public void TestLucky13()
        {
            int[] array1 = { 0, 2, 4 };
            int[] array2 = { 1, 2, 3 };
            int[] array3 = { 1, 2, 4 };
            bool actual = lucky13.GetLucky(array1);
            bool actual2 = lucky13.GetLucky(array2);
            bool actual3 = lucky13.GetLucky(array3);
            //GetLucky([0, 2, 4]) → true
            //GetLucky([1, 2, 3]) → false
            //GetLucky([1, 2, 4]) → false
            Assert.AreEqual(true, actual);
            Assert.AreEqual(false, actual2);
            Assert.AreEqual(false, actual3);


        }
    }
}
