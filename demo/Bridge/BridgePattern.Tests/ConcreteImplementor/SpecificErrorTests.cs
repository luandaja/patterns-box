using Bogus;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Implementor;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.ConcreteImplementor
{
    public class SpecificErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new SpecificError();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetSpecificErrorMessage()
        {
            var errorMessage = error.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now } with message { ex.Message }");
        }
    }
}