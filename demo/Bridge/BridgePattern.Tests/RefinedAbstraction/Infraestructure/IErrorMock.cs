using BridgePattern.Implementor;
using Moq;
using System;

namespace BridgePattern.Tests.RefinedAbstraction.Infraestructure
{
    public static class IErrorMock
    {
        public static IError GetIErrorMock()
        {
            var mock = new Mock<IError>();
            mock.Setup(x => x.GetErrorMessage(It.IsAny<Exception>()))
                .Returns(string.Empty);

            return mock.Object;
        }
    }
}
