using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTests
    {
        [TestMethod]

        public void GetLanguagesTest()
        {
            // Arrange


            // Act


            // Assert
            Assert.Fail(); //remove me


        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange


            // Act


            // Assert


        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange



            // Act



            // Assert
            // SqlException is expected to be thrown
        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange


            // Act


            // Assert
            
        }
    }
}
