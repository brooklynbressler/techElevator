using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CitySqlDAOTests : WorldDAOTests
    {
        [TestMethod]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities()
        {
            // Arrange


            // Act
 

            // Assert

        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            

            // Act
 

            // Assert
 
 
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange


            // Act


            // Assert
            // SqlException is expected to be thrown
        }
    }
}
