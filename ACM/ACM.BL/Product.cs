﻿using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName 
        { 
            get 
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value; 
            }
        }
        public string ProductDescription { get; set; }
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
        public string Log()
        {
            return $"{ProductId} : {ProductName} ProductDescription : {ProductDescription} Status :  {EntityState.ToString()}";
        }
    }
}
