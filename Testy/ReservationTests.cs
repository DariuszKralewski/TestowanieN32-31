using Aplikacja.Podstawy;
using NUnit.Framework;


namespace Testy
{
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //AAA
            //Arrange
            var reservation = new Reservation(); //tworzę obiekt rezerwacji

            //Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true }); //wywołuję metodę CanBeCancelledBy z użytkownikiem, który jest administratorem

            //Assert
            Assert.That(result, Is.True); //sprawdzam, czy wynik jest prawdziwy, ponieważ administrator powinien mieć możliwość anulowania rezerwacji
        }

        [Test]
        public void CanBeCancelledBy_UserIsCreator_ReturnsTrue()
        {
            var user = new User(); //tworzę obiekt użytkownika
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCancelledBy(user); //wywołuję metodę CanBeCancelledBy z użytkownikiem, który jest twórcą rezerwacji)
            Assert.That(result, Is.True); //sprawdzam, czy wynik jest prawdziwy, ponieważ osoba, która dokonała rezerwacji, powinna mieć możliwość jej anulowania
        }

        [Test]
        public void CanBeCancelledBy_UserIsNeitherAdminNorCreator_ReturnsFalse()
        {
            var reservation = new Reservation { MadeBy = new User() }; //tworzę obiekt rezerwacji z użytkownikiem, który nie jest administratorem ani twórcą rezerwacji
            var result = reservation.CanBeCancelledBy(new User()); //wywołuję metodę CanBeCancelledBy z użytkownikiem, który nie jest administratorem ani twórcą rezerwacji
            Assert.That(result, Is.False); //sprawdzam, czy wynik jest fałszywy, ponieważ użytkownik nie powinien mieć możliwości anulowania rezerwacji
        }
    }
}
