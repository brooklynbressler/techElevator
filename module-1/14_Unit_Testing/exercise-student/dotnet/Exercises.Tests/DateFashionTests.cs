using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        DateFashion dateFashion = new DateFashion();

        [TestMethod]
        public void TestDateFashion()
        {

            int actual = dateFashion.GetATable(5, 10);
            int actual2 = dateFashion.GetATable(5, 2);
            int actual3 = dateFashion.GetATable(5, 5);
            //dateFashion(5, 10) → 2
            //dateFashion(5, 2) → 0
            //dateFashion(5, 5) → 1
            Assert.AreEqual(2, actual);
            Assert.AreEqual(0, actual2);
            Assert.AreEqual(1, actual3);


        }
    }
}
