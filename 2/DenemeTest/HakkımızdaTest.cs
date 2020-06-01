using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRestaurant.Controllers;

namespace DenemeTest
{
    [TestClass]
    public class HakkımızdaTest
    {
        public bool result { get; private set; }

        [TestMethod]
        public void Index()
        {
            //Arrange
            hakkımızdaController controller = new hakkımızdaController();

            //Act
            var hakkımızdaController = new hakkımızdaController();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
