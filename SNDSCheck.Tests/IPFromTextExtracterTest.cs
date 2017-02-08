using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SNDSCheck.Components;

namespace SNDSCheck.Tests
{
    [TestClass]
    public class IPFromTextExtracterTest
    {
        [TestMethod]
        public void TestSingleIPAddress()
        {
            // Arrange
            var input = "127.0.0.1";
            var expected = new List<String>() { "127.0.0.1" };

            // Act
            var extracted = new IPFromTextExtracter(input);

            // Assert
            CollectionAssert.AreEqual(extracted, expected);
        }

        [TestMethod]
        public void TestSingleIPAddressWithSemicolon()
        {
            // Arrange
            var input = "127.0.0.1;";
            var expected = new List<String>() { "127.0.0.1" };

            // Act
            var extracted = new IPFromTextExtracter(input);

            // Assert
            CollectionAssert.AreEqual(extracted, expected);
        }

        [TestMethod]
        public void TestSingleIPAddressWithSemicolons()
        {
            // Arrange
            var input = "127.0.0.1;;;";
            var expected = new List<String>() { "127.0.0.1" };

            // Act
            var extracted = new IPFromTextExtracter(input);

            // Assert
            CollectionAssert.AreEqual(extracted, expected);
        }

        [TestMethod]
        public void TestMultipleIPAdressesOverMultipleLines()
        {
            // Arrange
            var input = "127.0.0.1;;;\n192.168.0.1;;;\n1.2.3.4;;;\n256.256.256.256";
            var expected = new List<String>() { "127.0.0.1", "192.168.0.1", "1.2.3.4", "256.256.256.256" };

            // Act
            var extracted = new IPFromTextExtracter(input);

            // Assert
            CollectionAssert.AreEqual(extracted, expected);
        }
    }
}
