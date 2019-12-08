using Moq;
using Repository;

namespace RepositoryDemo.Tests.RepositoryMockBuilder
{
    public class EnrolleeRepositoryMockBuilder
    {
        private readonly Mock<IEnrolleeRepository> _enrolleeRepository;
        public EnrolleeRepositoryMockBuilder()
        {
            _enrolleeRepository = new Mock<IEnrolleeRepository>();
        }

        public EnrolleeRepositoryMockBuilder WithGetEnrolleeReturnsOk()
        {
            _enrolleeRepository.Setup(x => x.GetById(It.IsAny<int>()))
                .Returns(new Models.Enrollees { Id = 1, FirstName = "Miguel", LastName = "Salas", IsActive = true });
            return this;
        }

        public EnrolleeRepositoryMockBuilder WithGetEnrolleeReturnsNotFound()
        {
            _enrolleeRepository.Setup(x => x.GetById(It.Is<int>(y => y == 2)))
                .Returns((Models.Enrollees)null);
            return this;
        }

        public IEnrolleeRepository BuildObject()
        {
            return _enrolleeRepository.Object;
        }
    }
}
