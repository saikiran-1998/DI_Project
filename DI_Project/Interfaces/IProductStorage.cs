using DI_Project.Models;
using System.Collections.Generic;

namespace DI_Project.Interfaces
{
    public interface IProductStorage
    {
        public IEnumerable<ProductModel> LoadProducts();
    }
}
