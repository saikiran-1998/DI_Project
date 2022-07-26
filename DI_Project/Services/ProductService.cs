using DI_Project.Interfaces;
using DI_Project.Models;
using System.Collections.Generic;

namespace DI_Project.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductStorage productStorage;
        public ProductService(IProductStorage productStorage)
        {
            this.productStorage = productStorage;
        }
        public IEnumerable<ProductModel> GetAllProducts()
        {
            return productStorage.LoadProducts();
        }

        public ProductModel GetProductById(int Id)
        {
            ProductModel product = new ProductModel();
            foreach (var item in productStorage.LoadProducts())
            {
                if (item.Product_Id == Id)
                {
                    product = item;
                }
            }
            return product;
            // return productStorage.LoadProducts().Where(x => x.Product_Id == Id).FirstOrDefault();
        }
    }
}
