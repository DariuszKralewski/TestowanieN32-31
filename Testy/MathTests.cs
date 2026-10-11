using Aplikacja.Podstawy;
using NUnit.Framework;

namespace Testy
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        //SetUp - metoda wykonywana przed każdym testem, aby przygotować środowisko testowe
        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        //TearDown - metoda wykonywana po każdym teście, aby posprzątać po teście
        [TearDown]
        public void TearDown()
        {
            _math = null;
        }

        [Test]
        [Ignore("Nie chce mi się już nad siedzieć. Zrobię go jutro!")]
        public void Add_WhenCalled_ReturnsTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }
        
        //testy parametryzowane
        [TestCase(1, 2, 2)]
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsTheGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));

        }

    }
}
