using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            CustomerRepository custRepo = new CustomerRepository();
            Customer actual = custRepo.Retrieve(1);
            var expected = new Customer(1)
            {
                Email = "ted@gmail.com",
                FirstName = "Ted",
                LastName = "Kos"
            };
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.Email, actual.Email);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }
    }
}
