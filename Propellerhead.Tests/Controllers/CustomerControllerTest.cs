using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Propellerhead.Controllers;

namespace Propellerhead.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
