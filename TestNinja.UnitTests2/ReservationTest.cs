using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests2
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //we want to test three scenarios or three execution paths


            //Arrange

            var reservation = new Reservation();
            //Act
            var result =reservation.CanBeCancelledBy(new User { IsAdmin = true });

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_UserisOwner_ReturnsTrue()
        {
            //we want to test three scenarios or three execution paths


            //Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            //we want to test three scenarios or three execution paths


            //Arrange
            var reservation = new Reservation { MadeBy =new User()};
            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert
            Assert.IsFalse(result);
        }
    }
}
