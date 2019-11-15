using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void SaveTestMissingPrice()
        {
            var prodrepo = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductName = "Sunflowers",
                HasChanges = true
            };
            var result = prodrepo.Save(updatedProduct);
            Assert.AreEqual(false, result);
        }
    }
}
