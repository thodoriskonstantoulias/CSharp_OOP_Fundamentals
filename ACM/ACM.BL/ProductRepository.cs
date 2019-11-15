using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            //Code to find appropriate product 

            //Hardcoded data for now
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Size 4 yellow sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        //Saves the current product
        public bool Save(Product product)
        {
            //Code that saves the passed in product
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call insert stored procedure
                    }
                    else
                    {
                        //call update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
