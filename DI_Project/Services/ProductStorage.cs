using DI_Project.Interfaces;
using DI_Project.Models;
using System.Collections.Generic;

namespace DI_Project.Services
{
    public class ProductStorage : IProductStorage
    {
        List<ProductModel> lstProducts = new List<ProductModel>();

        public IEnumerable<ProductModel> LoadProducts()
        {
            lstProducts.Add(new ProductModel { Product_Id = 1, Product_Name = "Product1", Cost = 10 });
            lstProducts.Add(new ProductModel { Product_Id = 2, Product_Name = "Product2", Cost = 100 });
            lstProducts.Add(new ProductModel { Product_Id = 3, Product_Name = "Product3", Cost = 1000 });
            lstProducts.Add(new ProductModel { Product_Id = 4, Product_Name = "Product4", Cost = 101 });
            lstProducts.Add(new ProductModel { Product_Id = 5, Product_Name = "Product5", Cost = 10001 });
            lstProducts.Add(new ProductModel { Product_Id = 6, Product_Name = "Product6", Cost = 1001 });
            return lstProducts;
        }

    }
}
