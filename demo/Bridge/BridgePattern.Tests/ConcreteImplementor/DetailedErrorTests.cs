using Bogus;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Implementor;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.ConcreteImplementor
{
    public class DetailedErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new DetailedError();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetDetailedErrorMessage()
        {
            var errorMessage = error.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }. StackTrace: { ex.StackTrace } InnerException: { ex.InnerException } Message: { ex.Message }");
        }
    }
}