using Aplikacja;
using NUnit.Framework;
using System;

namespace Testy
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void LogError_MessageIsProvided_StoresErrorMessage()
        {
            // Arrange
            var logger = new ErrorLogger();
            var errorMessage = "Test error message";

            // Act
            logger.LogError(errorMessage);

            // Assert
            Assert.That(logger.LastError, Is.EqualTo(errorMessage)); // Verify that the LastError property contains the expected error message
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public void LogError_MessageIsInvalid_ThrowsArgumentException(string invalidMessage)
        {
            // Arrange
            var logger = new ErrorLogger();

            //Act & Assert
            Assert.That(() => logger.LogError(invalidMessage), Throws.ArgumentException); // Verify that an ArgumentException is thrown for invalid error messages
            Assert.That(() => logger.LogError(invalidMessage), Throws.Exception.TypeOf<ArgumentException>()); // Verify that the exception thrown is of type ArgumentException
        }
    }
}
