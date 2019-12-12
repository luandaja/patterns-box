using Bogus;
using BridgePattern.RefinedAbstraction;
using BridgePattern.Tests.RefinedAbstraction.Infraestructure;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class TextFileLoggerTests
    {
        private TextFileLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            ex = new Faker<Exception>().Generate();
            logger = new TextFileLogger(IErrorMock.GetIErrorMock());
        }

        [Test]
        public void LogToTextFile_Success()
        {
            logger.Write(ex);
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToTextFile_Fail()
        {
            logger.Write(ex);
            var success = false;
            success.Should().BeFalse();
        }
    }
}