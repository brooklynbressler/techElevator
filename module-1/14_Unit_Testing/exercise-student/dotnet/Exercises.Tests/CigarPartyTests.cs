using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        CigarParty cigarParty = new CigarParty();

        [TestMethod]
        public void TestCigarParty()
        {

            bool actual = cigarParty.HaveParty(30, false);
            bool actual2 = cigarParty.HaveParty(50, false);
            bool actual3 = cigarParty.HaveParty(70, true);
            //haveParty(30, false) → false
            //haveParty(50, false) → true
            //haveParty(70, true) → true
            Assert.AreEqual(false, actual);
            Assert.AreEqual(true, actual2);
            Assert.AreEqual(true, actual3);


        }
    }
}
