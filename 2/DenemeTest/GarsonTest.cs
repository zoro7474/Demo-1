using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRestaurant.Controllers;

namespace DenemeTest
{
    [TestClass]
    public class GarsonTest
    {
        public bool result { get; private set; }
        [TestMethod]
        
        public void Index()
        {

            //Arrange
            garsonpanelController controller = new garsonpanelController();

            //Act
            var garsonpanelController = new garsonpanelController();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
