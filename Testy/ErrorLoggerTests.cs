using Aplikacja;
using NUnit.Framework;

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
    }
}
