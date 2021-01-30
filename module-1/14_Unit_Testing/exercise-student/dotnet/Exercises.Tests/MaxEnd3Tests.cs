using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        MaxEnd3 maxEnd3 = new MaxEnd3();

        [TestMethod]
        public void TestMaxEnd3()
        {
            int[] array1 = new int[] { 1, 2, 3};
            int[] array2 = new int[] { 11, 5, 9};
            int[] array3 = new int[] { 2, 11, 3};
            int[] array4 = new int[] {3, 3, 3};
            int[] array5 = new int[]{11, 11, 11};
            int[] array6 = new int[] {3, 3, 3};

            int[] actual = maxEnd3.MakeArray(array1);
            int[] actual2 = maxEnd3.MakeArray(array2);
            int[] actual3 = maxEnd3.MakeArray(array3);

            //MakeArray([1, 2, 3]) → [3, 3, 3]
            //MakeArray([11, 5, 9]) → [11, 11, 11]
            //MakeArray([2, 11, 3]) → [3, 3, 3]

            CollectionAssert.AreEqual(array4, actual);
            CollectionAssert.AreEqual(array5, actual2);
            CollectionAssert.AreEqual(array6, actual3);


        }
    }
}
