using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRestaurant.Controllers;

namespace DenemeTest
{
    [TestClass]
    public class YardımTest
    {
        public bool result { get; private set; }


        [TestMethod]
        public void Index()
        {
            //Arrange
            yardimController controller = new yardimController();

            //Act
            var yardimController = new yardimController();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
