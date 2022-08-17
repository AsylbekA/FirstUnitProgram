using Microsoft.AspNetCore.Mvc;
using System;
using UnitWebApplication.Controllers;
using Xunit;

namespace UnitWebApplicationTest
{
    public class HomeControllerTest : IDisposable
    {
        private HomeController _controller;

        // setup
        public HomeControllerTest()
        {
            _controller = new HomeController();
        }

        [Fact]
        public void IndexViewDataMessageIsHelloWork()
        {
            //Act
            ViewResult result = _controller.Index() as ViewResult;

            //Assert
            Assert.Equal("Hello world!", result?.ViewData["Message"]);
            Assert.NotNull(result);
            Assert.Equal("Index", result?.ViewName);
        }

        // teardown
        public void Dispose()
        {
            _controller.Dispose();
            _controller = null;
        }
    }
}
