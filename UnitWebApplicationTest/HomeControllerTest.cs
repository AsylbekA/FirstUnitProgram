using Microsoft.AspNetCore.Mvc;
using UnitWebApplication.Controllers;
using Xunit;

namespace UnitWebApplicationTest
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexViewDataMessageIsHelloWork()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);
            Assert.NotNull(result);
            Assert.Equal("Index", result?.ViewName);
        }
    }
}
