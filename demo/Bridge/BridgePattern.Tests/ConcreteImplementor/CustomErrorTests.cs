using Bogus;
using BridgePattern.ConcreteImplementor;
using BridgePattern.Implementor;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.ConcreteImplementor
{
    public class CustomErrorTests
    {
        private IError error;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            error = new CustomError();
            ex = new Faker<Exception>().Generate();
        }

        [Test]
        public void GetCustomErrorMessage()
        {
            var errorMessage = error.GetErrorMessage(ex);
            errorMessage.Should().Be($"An exception ocurred in date: { DateTime.Now }.\n - StackTrace: { ex.StackTrace } \n - InnerException: { ex.InnerException } \n - Message: { ex.Message }");
        }
    }
}