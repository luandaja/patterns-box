
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using RepositoryDemo.Controllers;
using RepositoryDemo.Tests.RepositoryMockBuilder;
using System.Net;

namespace RepositoryDemo.Tests
{
    [TestFixture]
    public class EnrolleeControllerTests
    {
        private EnrolleeController _controller;
        private EnrolleeRepositoryMockBuilder _enrolleeRepositoryBuilder;

        [SetUp]
        public void Configuration()
        {
            _enrolleeRepositoryBuilder = new EnrolleeRepositoryMockBuilder();
            _controller = new EnrolleeController(_enrolleeRepositoryBuilder.BuildObject());
        }

        [Test]
        public void GetEnrollee_ExistingId_ReturnOK()
        {
            //Arrange
            _enrolleeRepositoryBuilder.WithGetEnrolleeReturnsOk();

            //Action
            var result = _controller.GetEnrollee(1) as ObjectResult;

            //Assert
            result.Value.Should().NotBeNull();
        }

        [Test]
        public void GetEnrollee_NonExistingId_ReturnNotFound()
        {
            //Arrange
            _enrolleeRepositoryBuilder.WithGetEnrolleeReturnsNotFound();

            //Action
            var result = _controller.GetEnrollee(2) as StatusCodeResult;

            //Assert
            result.StatusCode.Should().Be((int)HttpStatusCode.NotFound);
        }
    }
}
