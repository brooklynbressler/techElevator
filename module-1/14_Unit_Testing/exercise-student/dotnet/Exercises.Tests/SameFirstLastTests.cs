using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        SameFirstLast sameFirstLast = new SameFirstLast();

        [TestMethod]
        public void TestSameFirstLast()
        {
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 1, 2, 3, 1 };
            int[] array3 = new int[] { 1, 2, 1 };

            bool actual = sameFirstLast.IsItTheSame(array1);
            bool actual2 = sameFirstLast.IsItTheSame(array2);
            bool actual3 = sameFirstLast.IsItTheSame(array3);

            //IsItTheSame([1, 2, 3]) → false
            //IsItTheSame([1, 2, 3, 1]) → true
            //IsItTheSame([1, 2, 1]) → true

            Assert.AreEqual(false, actual);
            Assert.AreEqual(true, actual2);
            Assert.AreEqual(true, actual3);


        }
    }
}
