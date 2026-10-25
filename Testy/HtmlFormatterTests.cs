using Aplikacja;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void Bold_WhenCalled_ReturnsBoldText()
        {
            // Arrange
            var formatter = new HtmlFormatter();
            var input = "Hello, World!";
            var expectedOutput = "<b>Hello, World!</b>";
            // Act
            var result = formatter.Bold(input);
            // Assert specific
            Assert.That(result, Is.EqualTo(expectedOutput));

            //Assert generic
            Assert.That(result, Does.StartWith("<b>")); //sprawdzenie czy wynik zaczyna się od <b>
            Assert.That(result, Does.EndWith("</b>")); //sprawdzenie czy wynik kończy się na </b>
            Assert.That(result, Does.Contain(input)); //sprawdzenie czy wynik zawiera tekst wejściowy
        }
    }
}
