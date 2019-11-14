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

        [TestMethod]
        public void StaticTest()
        {
            Customer c1 = new Customer();
            Customer.InstanceCount += 1;
            Customer c2 = new Customer();
            Customer.InstanceCount += 1;
            Customer c3 = new Customer();
            Customer.InstanceCount += 1;

            int expected = 3;
            int actual = Customer.InstanceCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            var cust1 = new Customer();
            cust1.LastName = "Kos";
            cust1.Email = "xxx@gmail.com";

            bool expected = true;
            bool actual = cust1.Validate();

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateMissingLastNameValid()
        {
            var cust1 = new Customer();
            cust1.Email = "xxx@gmail.com";

            bool expected = false;
            bool actual = cust1.Validate();

            Assert.AreEqual(expected, actual);
        }
    }
}
