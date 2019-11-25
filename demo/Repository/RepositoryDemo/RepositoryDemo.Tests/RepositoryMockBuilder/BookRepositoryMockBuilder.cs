using Moq;
using Repository;

namespace RepositoryDemo.Tests.RepositoryMockBuilder
{
    public class BookRepositoryMockBuilder
    {
        private readonly Mock<IBookRepository> _bookRepository;
        public BookRepositoryMockBuilder()
        {
            _bookRepository = new Mock<IBookRepository>();
        }

        public BookRepositoryMockBuilder WithGetBook()
        {
            _bookRepository.Setup(x => x.GetById(It.IsAny<int>()))
                .Returns(new Models.Books { Id = 1, AuthorId = 1, Title = "Test Title Name", Description = "Test Description Name", IsActive = true });
            return this;
        }

        public IBookRepository BuildObject()
        {
            return _bookRepository.Object;
        }
    }
}
