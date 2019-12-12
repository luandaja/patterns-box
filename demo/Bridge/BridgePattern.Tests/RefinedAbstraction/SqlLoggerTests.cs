using Bogus;
using BridgePattern.RefinedAbstraction;
using BridgePattern.Tests.RefinedAbstraction.Infraestructure;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace Tests.RefinedAbstraction
{
    public class SqlLoggerTests
    {
        private SqlLogger logger;
        private Exception ex;

        [SetUp]
        public void Setup()
        {
            ex = new Faker<Exception>().Generate();
            logger = new SqlLogger(IErrorMock.GetIErrorMock());
        }

        [Test]
        public void LogToSql_Success()
        {
            logger.Write(ex);
            var success = true;
            success.Should().BeTrue();
        }

        [Test]
        public void LogToSql_Fail()
        {
            logger.Write(ex);
            var success = false;
            success.Should().BeFalse();
        }
    }
}