﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood;
using OdeToFood.Controllers;

namespace OdeToFood.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
             ViewResult result = controller.Index() as ViewResult;

            // Assert
           Assert.IsNotNull(result);
           Assert.AreEqual("Home Page", result.ViewBag.Title);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("About Page", result.ViewBag.Title);
        }

        [TestMethod]
        public void AboutModel()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
            
        }
    }
}
