using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CatCatalogue;
using CatCatalogue.Controllers;
using System.Threading.Tasks;

namespace CatCatalogue.Tests.Controllers
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
            Task<ActionResult> result = controller.Index() as Task<ActionResult>;

            // Assert
            Assert.IsNotNull(result);
            
        }
    }
}
