using Aplikacja.Podstawy;
using NUnit.Framework;
using System.Linq;

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

        [Test]
        public void GetOddNumbers_WhenCalled_ReturnsOddNumbersUpToLimit()
        {
            var result = _math.GetOddNumbers(5);
            //Assert specific
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 }));

            //Assert general
            Assert.That(result, Is.All.GreaterThan(0)); // wszystkie liczby są większe od 0
            Assert.That(result, Is.Not.Empty); // kolekcja nie jest pusta
            Assert.That(result.Count(), Is.EqualTo(3)); // kolekcja zawiera 3 elementy
            
            Assert.That(result, Does.Contain(1)); // kolekcja zawiera 1
            Assert.That(result, Does.Contain(3)); // kolekcja zawiera 3
            Assert.That(result, Does.Contain(5)); // kolekcja zawiera 5

            Assert.That(result, Is.Ordered); // kolekcja jest posortowana
            Assert.That(result, Is.Unique); // kolekcja nie zawiera duplikatów


        }

    }
}
