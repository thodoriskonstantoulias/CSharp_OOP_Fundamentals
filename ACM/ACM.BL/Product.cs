﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
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
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        //Retrieve one Product 
        public Product Retrieve(int productId)
        {
            return new Product();
        }
        public bool Save()
        {
            return true;
        }
    }
}
