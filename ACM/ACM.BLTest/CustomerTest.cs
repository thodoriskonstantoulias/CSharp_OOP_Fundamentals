using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.FirstName = "Ted";
            customer.LastName = "Kos";

            string expected = "Kos,Ted";
            //Act
            string actual = customer.FullName;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameTestValid()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Kos";

            string expected = "Kos";
            //Act
            string actual = customer.LastName;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
