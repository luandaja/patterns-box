using FluentAssertions;
using NUnit.Framework;
using RepositoryDemo.Controllers;
using RepositoryDemo.Tests.RepositoryMockBuilder;

namespace RepositoryDemo.Tests
{
    [TestFixture]
    public class BookControllerTests
    {
        private BookController _controller;
        private BookRepositoryMockBuilder _bookRepositoryBuilder;

        [SetUp]
        public void Configuration()
        {
            _bookRepositoryBuilder = new BookRepositoryMockBuilder();
            _controller = new BookController(_bookRepositoryBuilder.BuildObject());
        }

        [Test]
        public void GetBook_ExistingId_ReturnOK()
        {
            //Arrange
            _bookRepositoryBuilder.WithGetBook();

            //Action
            var result = _controller.GetBook(1);

            //Assert
            result.Should().NotBeNull();
        }
    }
}
