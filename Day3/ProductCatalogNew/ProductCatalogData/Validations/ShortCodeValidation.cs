﻿using ProductCatalogData.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogData.Validations
{
    public class ShortCodeValidation
    {
        public string ShortCodeValidatingproducts()
        {
            string givenShortCode = Console.ReadLine();
            foreach (Product products in OperationOnEntities.OperationOnProduct.ProductList)
            {
                if (givenShortCode == products.ShortCode)
                {
                    Console.WriteLine("Short Code must be unique");
                    Console.WriteLine("\nEnter Short Code Again : ");
                    ShortCodeValidatingproducts();
                }
                if (givenShortCode.Length > 4)
                {
                    Console.WriteLine("Short Code  length must be less than 4");
                    Console.WriteLine("\nEnter Short Code Again : ");
                    ShortCodeValidatingproducts();
                }
            }
            return givenShortCode;
        }
        public string ShortCodeValidatingCategory()
        {
            string givenShortCode = Console.ReadLine();
            foreach (Category category in OperationOnEntities.OperationOnCategory.categoryList)
            {
                if (givenShortCode == category.ShortCode)
                {
                    Console.WriteLine("Short Code must be unique");
                    Console.WriteLine("\nEnter Short Code Again : ");
                    ShortCodeValidatingCategory();
                }
                if (givenShortCode.Length > 4)
                {
                    Console.WriteLine("Short Code  length must be less than 4");
                    Console.WriteLine("\nEnter Short Code Again : ");
                    ShortCodeValidatingCategory();
                }
            }
            return givenShortCode;
        }
    
}
}
