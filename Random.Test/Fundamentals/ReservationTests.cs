using NUnit.Framework;
using Random.Fundamentals;

namespace Random.Test.Fundamentals
{
    [TestFixture]
    class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling__ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result == true);
        }
    }
}
