using Bogus;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Implementor;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.ConcreteImplementor
{
    public class DefaultErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new DefaultError();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetDefaultErrorMessage()
        {
            var errorMessage = error.GetErrorMessage(ex);
            errorMessage.Should().Be("An error ocurred in the application");
        }
    }
}