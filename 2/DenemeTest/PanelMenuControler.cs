using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRestaurant.Controllers;

namespace DenemeTest
{
    [TestClass]
    public class PanelMenuControler
    {
        public bool result { get; private set; }


        [TestMethod]
        public void Index()
        {
            //Arrange
            panelmenüController controller = new panelmenüController();

            //Act
            var panelmenüController = new panelmenüController();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
