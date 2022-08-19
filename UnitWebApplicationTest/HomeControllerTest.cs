using Microsoft.AspNetCore.Mvc;
using Moq;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitWebApplication.Controllers;
using UnitWebApplicationBLL.Intercafes;
using UnitWebApplicationTest.ModelsTest;
using Xunit;

namespace UnitWebApplicationTest
{
    public class HomeControllerTest : IDisposable
    {
        private HomeController _controller;
        IRepository _repository;
        // setup
        public HomeControllerTest()
        {
            _controller = new HomeController(_repository);
        }

        [Fact]
        public void IndexViewDataMessageIsHelloWork()
        {
            //Act
            //var mock = new Mock<IRepository>();
            //mock.SetupGet(repo => repo.GetAll()).Returns(new UserTest().GetTestUsers());

            ViewResult result = _controller.Index() as ViewResult;
            var repo = new UserTest().GetTestUsers();
            //Assert

            var model= Assert.IsAssignableFrom<IEnumerable<UserTest>>(repo);
            Assert.Equal(new UserTest().GetTestUsers().Count, model.Count());
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
