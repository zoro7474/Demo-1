using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MvcRestaurant;
using MvcRestaurant.Controllers;


namespace DenemeTest
{
    [TestClass]
    public class HomeTest
    {
        public bool result { get; private set; }

        [TestMethod]
        public void Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var HomeController = new HomeController();

            //Assert
            Assert.IsNotNull(result);

        }
    }
}
