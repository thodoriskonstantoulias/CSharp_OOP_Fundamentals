using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string  ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        //Validates product data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
        //Test overriding method from object class
        public override string ToString()
        {
            return ProductName;
        }
    }
}
