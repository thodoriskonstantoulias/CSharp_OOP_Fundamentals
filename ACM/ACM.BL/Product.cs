using Acme.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        //Overloading constructors
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        //Defining getters and setters
        public int ProductId { get; private set; }
        private string _productName;
        //Use of method of common library to get the field _productName
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
        //Overrides the parent class abstract method
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

        //Log method to show the use of interfaces 
        public string Log()
        {
            return $"{ProductId} : {ProductName} ProductDescription : {ProductDescription} Status :  {EntityState.ToString()}";
        }
    }
}
