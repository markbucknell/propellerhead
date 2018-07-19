using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propellerhead.Controllers;

namespace Propellerhead.Tests.Controllers
{
    [TestClass]
    public class NotesControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            NotesController controller = new NotesController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
