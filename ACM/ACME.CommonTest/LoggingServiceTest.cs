using ACM.BL;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ACME.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                Email = "ted@gmail.com",
                FirstName = "Ted",
                LastName = "Kos",
                AddressList = null
            };
            changedItems.Add(customer);
            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden rake",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            LoggingService.WriteToFile(changedItems);
        }

    }
}
