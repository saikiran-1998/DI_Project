using DI_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Project.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<ProductModel> GetAllProducts();
        public ProductModel GetProductById(int Id);
    }
}
