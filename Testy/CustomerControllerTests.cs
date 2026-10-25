using Aplikacja.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsLessThanOrEqualToZero_ReturnsNotFound()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(0);
            // Assert
            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsGreaterThanZero_ReturnsOk()
        {
            // Arrange
            var controller = new CustomerController();
            // Act
            var result = controller.GetCustomer(1);
            // Assert
            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
