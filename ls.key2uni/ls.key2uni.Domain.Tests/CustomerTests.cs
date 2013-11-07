using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ls.key2uni.Entities;

namespace ls.key2uni.Domain.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        private Customer obj;

        [SetUp]
        public void Setup()
        {
            obj = new Customer();
        }

        [Test]
        public void CheckDataType_ValidString_ReturnsString()
        {
            obj.FirstName = "John";
            var expected = "John";

            Assert.AreEqual(expected, obj.FirstName);
        }

        [TearDown]
        public void TearDown()
        {
            obj = null;
        }
    }
}
